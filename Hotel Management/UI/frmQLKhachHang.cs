using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Hotel_Management
{
    public partial class frmQLKhachHang : DevExpress.XtraEditors.XtraForm
    {
        // 1. Chuỗi kết nối
        private string connectionString =
            @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";

        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        // 2. Sự kiện Load Form
        private void frmQLKhachHang_Load_1(object sender, EventArgs e)
        {
            
            LoadGridData();
            ClearForm();

            // Gán sự kiện cho gridView
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;

            // Gán sự kiện cho các nút
            // (Bạn đã gán 2 nút này trong designer rồi, nhưng gán ở đây cũng tốt)
            // btnThem.Click += btnThem_Click_1;
            // btnXoa.Click += btnXoa_Click_1;
            btnSua.Click += btnSua_Click; // Gán sự kiện cho nút Sửa

           
            btnLamMoi.Click += btnLamMoi_Click;
         
        }

        #region HÀM TẢI DỮ LIỆU

        private void LoadGridData()
        {
            // ... (code hàm này giữ nguyên)
            try
            {
                string query = "SELECT MaKH, HoTen, SDT, CCCD_HoChieu, Email, LoaiKH, DiemTichLuy FROM KhachHang";
                SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridControlKH.DataSource = dt;
                //... (đặt tên cột)
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải danh sách khách hàng: " + ex.Message, "Lỗi");
            }
        }

        private void ClearForm()
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            txtEmail.Text = "";
            cmbLoaiKH.SelectedItem = "Vãng lai"; // Mặc định
            spinDiem.Value = 0;

            txtMaKH.ReadOnly = false; // <-- Quan trọng: Mở khóa ô Mã
            txtMaKH.Focus();          // <-- Quan trọng: Chuyển con trỏ về ô Mã
        }

        #endregion

        #region SỰ KIỆN CONTROLS

      
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
       
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // ... (code hàm này giữ nguyên)
            if (e.FocusedRowHandle < 0) return;
            try
            {
                DataRow dr = gridView1.GetDataRow(e.FocusedRowHandle);
                if (dr == null) return;
                // ... (gán dữ liệu)
                txtMaKH.Text = dr["MaKH"].ToString();
                txtHoTen.Text = dr["HoTen"].ToString();
                txtSDT.Text = dr["SDT"].ToString();
                txtCCCD.Text = dr["CCCD_HoChieu"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                cmbLoaiKH.SelectedItem = dr["LoaiKH"].ToString();
                spinDiem.Value = (dr["DiemTichLuy"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["DiemTichLuy"]);

                txtMaKH.ReadOnly = true;
            }
            catch (Exception ex) { }
        }

        private void gridControlKH_Click(object sender, EventArgs e)
        {
           
            if (gridView1.FocusedRowHandle >= 0)
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr == null) return;
                // ... (gán dữ liệu)
                txtMaKH.Text = dr["MaKH"].ToString();
                txtHoTen.Text = dr["HoTen"].ToString();
                txtSDT.Text = dr["SDT"].ToString();
                txtCCCD.Text = dr["CCCD_HoChieu"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                cmbLoaiKH.SelectedItem = dr["LoaiKH"].ToString();
                spinDiem.Value = (dr["DiemTichLuy"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["DiemTichLuy"]);

                txtMaKH.ReadOnly = true; // <-- Quan trọng: Khóa ô Mã
            }
        }

        // Nút Thêm
        private void btnThem_Click_1(object sender, EventArgs e)
        {
         
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập Mã Khách hàng!", "Cảnh báo");
                txtMaKH.Focus();
                return;
            }
            // ... (code SQL)
            try
            {
                // ... (code SQL Insert)
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    //...
                    using (SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO KhachHang (MaKH, HoTen, SDT, CCCD_HoChieu, Email, LoaiKH, DiemTichLuy)
                        VALUES (@MaKH, @HoTen, @SDT, @CCCD, @Email, @LoaiKH, @Diem)", conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@LoaiKH", cmbLoaiKH.SelectedItem?.ToString() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Diem", (spinDiem.Value == 0) ? (object)DBNull.Value : spinDiem.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                XtraMessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                LoadGridData();
                ClearForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi");
            }
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            // ... (code hàm này giữ nguyên)
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || txtMaKH.ReadOnly == false)
            {
                XtraMessageBox.Show("Vui lòng chọn một khách hàng từ lưới để sửa.", "Cảnh báo");
                return;
            }
            // ... (code SQL)
            try
            {
                // ... (code SQL Update)
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE KhachHang SET HoTen = @HoTen, SDT = @SDT, CCCD_HoChieu = @CCCD, 
                        Email = @Email, LoaiKH = @LoaiKH, DiemTichLuy = @Diem
                        WHERE MaKH = @MaKH", conn))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@LoaiKH", cmbLoaiKH.SelectedItem?.ToString() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Diem", (spinDiem.Value == 0) ? (object)DBNull.Value : spinDiem.Value);
                        cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim()); // Điều kiện WHERE
                        cmd.ExecuteNonQuery();
                    }
                }
                XtraMessageBox.Show("Cập nhật thành công!", "Thông báo");
                LoadGridData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi");
            }
        }

        // Nút Xóa
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            // ... (code hàm này giữ nguyên)
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || txtMaKH.ReadOnly == false)
            {
                XtraMessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Cảnh báo");
                return;
            }
            // ... (code SQL)
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // ... (code SQL Delete)
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM KhachHang WHERE MaKH = @MaKH", conn))
                        {
                            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadGridData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi khi xóa: Không thể xóa khách hàng này (có thể khách đang thuê phòng).", "Lỗi");
                }
            }
        }

        #endregion
    }
}