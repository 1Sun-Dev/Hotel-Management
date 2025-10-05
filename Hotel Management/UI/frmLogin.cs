using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class frmLogin : Form
    {

        private SqlConnection sqlConnection;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        
        }

        private void lblNameLogin_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNameLogin_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnQuanly_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LBDangnhap_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void LBDangnhap_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgotPassword f = new frmForgotPassword();
            f.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMaincs f = new frmMaincs();
            f.ShowDialog();
            //string username = txtUserName.Text.Trim();
            //string password = txtPassword.Text.Trim();

            //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //string connectionString = @"Data Source=Admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True";

            //try
            //{
            //    // Khởi tạo kết nối SQL
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open(); // Mở kết nối
            //        string query = "SELECT COUNT(*) FROM LOGIN WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau";

            //        using (SqlCommand cmd = new SqlCommand(query, conn))
            //        {
            //            // Gán giá trị tham số đúng tên trong câu truy vấn
            //            cmd.Parameters.AddWithValue("@TaiKhoan", username);
            //            cmd.Parameters.AddWithValue("@MatKhau", password);

            //            int count = (int)cmd.ExecuteScalar(); // Thực hiện truy vấn và lấy kết quả

            //            if (count > 0)
            //            {
            //                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //                // Mở form chính
            //                frmMaincs mainForm = new frmMaincs();
            //                this.Hide();
            //                mainForm.ShowDialog();
            //                this.Show();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Lỗi kết nối SQL Server: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void guna2ToggleSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtUserName.UseSystemPasswordChar = !guna2ToggleSwitch1.Checked;
            txtPassword.UseSystemPasswordChar = !guna2ToggleSwitch1.Checked;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
