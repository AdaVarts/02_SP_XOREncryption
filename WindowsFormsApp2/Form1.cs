using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int point = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                openFiletxtBox.Text = fileDialog.FileName;
            }
        }

        ThreadStart threadStart;
        Thread thread;

        private void encBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(openFiletxtBox.Text) && !String.IsNullOrEmpty(dataVoltxtBox.Text) && keytxtBox.Text.Length >= 6)
            {
                threadStart = new ThreadStart(ReadWriteFile);
                thread = new Thread(threadStart);
                thread.Start();
            }
            progressBar1.Value = 0;
            pos = 0;
        }

        private void ReadWriteFile()
        {
            if (pos > 0)
            {
                using (FileStream fs = new FileStream(openFiletxtBox.Text, FileMode.Open, FileAccess.ReadWrite))
                {
                    int n = Int32.Parse(dataVoltxtBox.Text);
                    byte[] text = new byte[pos];
                    pointBreak = pos;
                    fLength = pos;
                    pos = 0;
                    progressBar1.Invoke(new Action(() => progressBar1.Maximum = 100));
                    progressBar1.Invoke(new Action(() => progressBar1.Value = 0));
                    point = 0;
                    point = fs.Read(text, 0, pointBreak);
                    text = Encrypt(text, keytxtBox.Text);
                    fs.Position -= point;
                    fs.Write(text, 0, point);
                    progressBar1.Invoke(new Action(() => progressBar1.Value = 100));
                }
            }
            else
            {
                using (FileStream fs = new FileStream(openFiletxtBox.Text, FileMode.Open, FileAccess.ReadWrite))
                {
                    int n = Int32.Parse(dataVoltxtBox.Text);
                    byte[] text = new byte[n];
                    fLength = (int)fs.Length;
                    progressBar1.Invoke(new Action(() => progressBar1.Maximum = 100));
                    while ((point = fs.Read(text, 0, n)) > 0)
                    {
                        text = Encrypt(text, keytxtBox.Text);
                        fs.Position -= point;
                        fs.Write(text, 0, point);
                    }
                    progressBar1.Invoke(new Action(() => progressBar1.Value = 100));
                }
            }
        }

        TimeSpan span;
        private delegate void ProgressBarChangeV(int _value);
        int fLength;
        int pointBreak = 0;
        int pos = 0;

        private byte[] Encrypt(byte[] buffer, string key)
        {
            DateTime time = new DateTime();
            time = DateTime.Now;
            byte[] res = new byte[buffer.Length];
            for (int i = 0; i < buffer.Length; i++)
            {
                res[i] = (byte)(buffer[i] ^ key[i % key.Length]);
                pos++;
                progressBar1.Invoke(new ProgressBarChangeV(ProgressBarUpdate),(int)(pos/fLength*100));
            }
            DateTime time2 = new DateTime();
            time2 = DateTime.Now;
            span = time2 - time;
            return res;
        }

        private void ProgressBarUpdate(int _value)
        {
            progressBar1.Value = _value;
        }

        private void disBtn_Click(object sender, EventArgs e)
        {
            if (thread == null)
            {
                thread.Abort();
                Thread threadDis = new Thread(threadStart);
                threadDis.Start();
            }
        }

        private void progressBar1_MouseHover(object sender, EventArgs e)
        {
            int speed;
            if (span.Milliseconds == 0)
                speed = Int32.Parse(dataVoltxtBox.Text);
            else
                speed = (Int32.Parse(dataVoltxtBox.Text) / span.Milliseconds) / 100;
            ToolTip tip = new ToolTip();

            tip.Show($"{speed} Kb/msec", progressBar1);
        }
    }
}
