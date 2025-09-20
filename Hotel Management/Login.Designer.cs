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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNameLogin = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNameLogin = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LBDangnhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuanly = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(567, 240);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password";
            // 
            // lblNameLogin
            // 
            this.lblNameLogin.AutoSize = true;
            this.lblNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLogin.ForeColor = System.Drawing.Color.White;
            this.lblNameLogin.Location = new System.Drawing.Point(567, 164);
            this.lblNameLogin.Name = "lblNameLogin";
            this.lblNameLogin.Size = new System.Drawing.Size(85, 20);
            this.lblNameLogin.TabIndex = 14;
            this.lblNameLogin.Text = "Usename";
            this.lblNameLogin.Click += new System.EventHandler(this.lblNameLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(571, 277);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(264, 20);
            this.txtPassword.TabIndex = 17;
            // 
            // txtNameLogin
            // 
            this.txtNameLogin.Location = new System.Drawing.Point(571, 198);
            this.txtNameLogin.Name = "txtNameLogin";
            this.txtNameLogin.Size = new System.Drawing.Size(264, 20);
            this.txtNameLogin.TabIndex = 16;
            this.txtNameLogin.TextChanged += new System.EventHandler(this.txtNameLogin_TextChanged_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(749, 318);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LBDangnhap
            // 
            this.LBDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDangnhap.ForeColor = System.Drawing.Color.White;
            this.LBDangnhap.Location = new System.Drawing.Point(615, 80);
            this.LBDangnhap.Name = "LBDangnhap";
            this.LBDangnhap.Size = new System.Drawing.Size(170, 63);
            this.LBDangnhap.TabIndex = 15;
            this.LBDangnhap.Text = "Login";
            this.LBDangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.CausesValidation = false;
            this.panel1.Location = new System.Drawing.Point(46, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 215);
            this.panel1.TabIndex = 20;
            // 
            // btnQuanly
            // 
            this.btnQuanly.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnQuanly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanly.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuanly.Location = new System.Drawing.Point(571, 357);
            this.btnQuanly.Name = "btnQuanly";
            this.btnQuanly.Size = new System.Drawing.Size(96, 43);
            this.btnQuanly.TabIndex = 23;
            this.btnQuanly.Text = "Quản lý";
            this.btnQuanly.UseVisualStyleBackColor = false;
            this.btnQuanly.Click += new System.EventHandler(this.btnQuanly_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNhanVien.Location = new System.Drawing.Point(739, 357);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(96, 43);
            this.btnNhanVien.TabIndex = 24;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(943, 496);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnQuanly);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNameLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNameLogin);
            this.Controls.Add(this.LBDangnhap);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNameLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNameLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label LBDangnhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuanly;
        private System.Windows.Forms.Button btnNhanVien;
    }
}

