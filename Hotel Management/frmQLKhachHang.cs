using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class frmQLKhachHang : XtraForm
    {
        // Khai báo connection string
        private string connectionString = @"Data Source=Admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True";

        public frmQLKhachHang()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        // Load danh sách khách hàng lên DataGridView
        private void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT MaKH, HoTen, SDT, CCCD_HoChieu, Email, DiemTichLuy FROM KhachHang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["MaKH"].HeaderText = "Mã KH";
                dataGridView1.Columns["MaKH"].ReadOnly = true;
            }
        }

        // Khi click vào DataGridView, điền thông tin vào TextBox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            txtMaKH.Text = dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString();
            txtHoTen.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
            txtCCCD.Text = dataGridView1.CurrentRow.Cells["CCCD_HoChieu"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txtDiem.Text = dataGridView1.CurrentRow.Cells["DiemTichLuy"].Value.ToString();
        }

        // Thêm khách hàng mới

        // Sửa khách hàng
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE KhachHang
                                 SET HoTen=@HoTen, SDT=@SDT, CCCD_HoChieu=@CCCD_HoChieu, Email=@Email, DiemTichLuy=@DiemTichLuy
                                 WHERE MaKH=@MaKH";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@CCCD_HoChieu", txtCCCD.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiemTichLuy", int.Parse(txtDiem.Text.Trim()));
                    cmd.Parameters.AddWithValue("@MaKH", int.Parse(txtMaKH.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                    LoadKhachHang();
                }
            }
        }

        // Xóa khách hàng


        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM KhachHang WHERE MaKH=@MaKH";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", int.Parse(txtMaKH.Text));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa khách hàng thành công!");
                        LoadKhachHang();
                    }
                }
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO KhachHang (MaKH, HoTen, SDT, CCCD_HoChieu, Email, DiemTichLuy)
                         VALUES (@MaKH, @HoTen, @SDT, @CCCD_HoChieu, @Email, @DiemTichLuy)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim()); // Bắt buộc nhập
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@CCCD_HoChieu", txtCCCD.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                   // TextBox cho loại khách
                    cmd.Parameters.AddWithValue("@DiemTichLuy", int.Parse(txtDiem.Text.Trim()));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm khách hàng thành công!");
                    LoadKhachHang();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
