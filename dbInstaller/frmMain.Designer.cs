namespace dbInstaller
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Button4 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.txtport = new System.Windows.Forms.TextBox();
            this.txthost = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.Enabled = false;
            this.Button4.Location = new System.Drawing.Point(241, 126);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(143, 31);
            this.Button4.TabIndex = 9;
            this.Button4.Text = "สร้างฐานข้อมูล";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Visible = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 126);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(126, 31);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "ทดสอบการเชื่อมต่อ";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtpass);
            this.GroupBox1.Controls.Add(this.txtuid);
            this.GroupBox1.Controls.Add(this.txtport);
            this.GroupBox1.Controls.Add(this.txthost);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(372, 108);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "MySQL";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(103, 77);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(154, 20);
            this.txtpass.TabIndex = 8;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuid
            // 
            this.txtuid.Location = new System.Drawing.Point(103, 51);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(154, 20);
            this.txtuid.TabIndex = 7;
            this.txtuid.Text = "root";
            this.txtuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(298, 25);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(53, 20);
            this.txtport.TabIndex = 6;
            this.txtport.Text = "3306";
            this.txtport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txthost
            // 
            this.txthost.Location = new System.Drawing.Point(103, 25);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(154, 20);
            this.txthost.TabIndex = 5;
            this.txthost.Text = "localhost";
            this.txthost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(21, 80);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 13);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Password:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(21, 54);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(61, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "User name:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(263, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(29, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Port:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(21, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Host name/IP:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 166);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Installer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.TextBox txtuid;
        internal System.Windows.Forms.TextBox txtport;
        internal System.Windows.Forms.TextBox txthost;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

