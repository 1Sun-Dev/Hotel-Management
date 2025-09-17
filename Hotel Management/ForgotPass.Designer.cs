namespace Hotel_Management
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNameLogin = new System.Windows.Forms.Label();
            this.txtNameLogin = new System.Windows.Forms.TextBox();
            this.LBDangnhap = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(82, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 282);
            this.panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 282);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(124)))), ((int)(((byte)(254)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(504, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblNameLogin
            // 
            this.lblNameLogin.AutoSize = true;
            this.lblNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLogin.ForeColor = System.Drawing.Color.White;
            this.lblNameLogin.Location = new System.Drawing.Point(450, 198);
            this.lblNameLogin.Name = "lblNameLogin";
            this.lblNameLogin.Size = new System.Drawing.Size(53, 20);
            this.lblNameLogin.TabIndex = 23;
            this.lblNameLogin.Text = "Email";
            // 
            // txtNameLogin
            // 
            this.txtNameLogin.Location = new System.Drawing.Point(454, 221);
            this.txtNameLogin.Multiline = true;
            this.txtNameLogin.Name = "txtNameLogin";
            this.txtNameLogin.Size = new System.Drawing.Size(264, 32);
            this.txtNameLogin.TabIndex = 25;
            // 
            // LBDangnhap
            // 
            this.LBDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDangnhap.ForeColor = System.Drawing.Color.White;
            this.LBDangnhap.Location = new System.Drawing.Point(469, 66);
            this.LBDangnhap.Name = "LBDangnhap";
            this.LBDangnhap.Size = new System.Drawing.Size(233, 93);
            this.LBDangnhap.TabIndex = 24;
            this.LBDangnhap.Text = "Reset Password";
            this.LBDangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBDangnhap.Click += new System.EventHandler(this.LBDangnhap_Click);
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNameLogin);
            this.Controls.Add(this.txtNameLogin);
            this.Controls.Add(this.LBDangnhap);
            this.Name = "ForgotPass";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNameLogin;
        private System.Windows.Forms.TextBox txtNameLogin;
        private System.Windows.Forms.Label LBDangnhap;
    }
}