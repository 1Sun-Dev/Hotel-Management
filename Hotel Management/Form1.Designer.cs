namespace Hotel_Management
{
    partial class frmLogin
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
            this.LBDangnhap = new System.Windows.Forms.Label();
            this.txtNameLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblNameLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.bttLogin = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBDangnhap
            // 
            this.LBDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDangnhap.Location = new System.Drawing.Point(278, 46);
            this.LBDangnhap.Name = "LBDangnhap";
            this.LBDangnhap.Size = new System.Drawing.Size(158, 44);
            this.LBDangnhap.TabIndex = 0;
            this.LBDangnhap.Text = "Đăng nhập";
            this.LBDangnhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNameLogin
            // 
            this.txtNameLogin.Location = new System.Drawing.Point(320, 147);
            this.txtNameLogin.Name = "txtNameLogin";
            this.txtNameLogin.Size = new System.Drawing.Size(183, 20);
            this.txtNameLogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(320, 204);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // lblNameLogin
            // 
            this.lblNameLogin.AutoSize = true;
            this.lblNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLogin.Location = new System.Drawing.Point(185, 147);
            this.lblNameLogin.Name = "lblNameLogin";
            this.lblNameLogin.Size = new System.Drawing.Size(129, 20);
            this.lblNameLogin.TabIndex = 0;
            this.lblNameLogin.Text = "Tên đăng nhập";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(185, 204);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Mật khẩu";
            this.lblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // bttLogin
            // 
            this.bttLogin.Location = new System.Drawing.Point(243, 279);
            this.bttLogin.Name = "bttLogin";
            this.bttLogin.Size = new System.Drawing.Size(92, 28);
            this.bttLogin.TabIndex = 3;
            this.bttLogin.Text = "Đăng nhập";
            this.bttLogin.UseVisualStyleBackColor = true;
            this.bttLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttExit
            // 
            this.bttExit.Location = new System.Drawing.Point(411, 279);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(92, 28);
            this.bttExit.TabIndex = 4;
            this.bttExit.Text = "Thoát";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 387);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.bttLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNameLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNameLogin);
            this.Controls.Add(this.LBDangnhap);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBDangnhap;
        private System.Windows.Forms.TextBox txtNameLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblNameLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.Button bttExit;
    }
}

