namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.openFiletxtBox = new System.Windows.Forms.TextBox();
            this.keytxtBox = new System.Windows.Forms.TextBox();
            this.dataVoltxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encBtn = new System.Windows.Forms.Button();
            this.disBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 127);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(464, 36);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.MouseHover += new System.EventHandler(this.progressBar1_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFiletxtBox
            // 
            this.openFiletxtBox.Enabled = false;
            this.openFiletxtBox.Location = new System.Drawing.Point(104, 15);
            this.openFiletxtBox.Name = "openFiletxtBox";
            this.openFiletxtBox.Size = new System.Drawing.Size(372, 20);
            this.openFiletxtBox.TabIndex = 2;
            // 
            // keytxtBox
            // 
            this.keytxtBox.Location = new System.Drawing.Point(58, 50);
            this.keytxtBox.Name = "keytxtBox";
            this.keytxtBox.Size = new System.Drawing.Size(188, 20);
            this.keytxtBox.TabIndex = 3;
            // 
            // dataVoltxtBox
            // 
            this.dataVoltxtBox.Location = new System.Drawing.Point(376, 50);
            this.dataVoltxtBox.Name = "dataVoltxtBox";
            this.dataVoltxtBox.Size = new System.Drawing.Size(100, 20);
            this.dataVoltxtBox.TabIndex = 4;
            this.dataVoltxtBox.Text = "4096";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data volume";
            // 
            // encBtn
            // 
            this.encBtn.Location = new System.Drawing.Point(12, 88);
            this.encBtn.Name = "encBtn";
            this.encBtn.Size = new System.Drawing.Size(225, 23);
            this.encBtn.TabIndex = 7;
            this.encBtn.Text = "Encrypt";
            this.encBtn.UseVisualStyleBackColor = true;
            this.encBtn.Click += new System.EventHandler(this.encBtn_Click);
            // 
            // disBtn
            // 
            this.disBtn.Location = new System.Drawing.Point(251, 88);
            this.disBtn.Name = "disBtn";
            this.disBtn.Size = new System.Drawing.Size(225, 23);
            this.disBtn.TabIndex = 9;
            this.disBtn.Text = "Dismiss";
            this.disBtn.UseVisualStyleBackColor = true;
            this.disBtn.Click += new System.EventHandler(this.disBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 175);
            this.Controls.Add(this.disBtn);
            this.Controls.Add(this.encBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataVoltxtBox);
            this.Controls.Add(this.keytxtBox);
            this.Controls.Add(this.openFiletxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox openFiletxtBox;
        private System.Windows.Forms.TextBox keytxtBox;
        private System.Windows.Forms.TextBox dataVoltxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encBtn;
        private System.Windows.Forms.Button disBtn;
    }
}

