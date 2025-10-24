using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Hotel_Management
{
    public partial class frmQuanLyDichVu : DevExpress.XtraEditors.XtraForm
    {
        // 1. Chuỗi kết nối
        private string connectionString =
            @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";

        public frmQuanLyDichVu()
        {
            InitializeComponent();
        }

        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            LoadLoaiDichVu();
            LoadGridData();
            ClearForm();

            // Gán sự kiện
            gridViewDichVu.FocusedRowChanged += gridViewDichVu_FocusedRowChanged;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        #region HÀM TẢI DỮ LIỆU

        private void LoadLoaiDichVu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaLDV, TenLDV FROM LoaiDV";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    lookUpLoaiDV.Properties.DataSource = dt;
                    lookUpLoaiDV.Properties.DisplayMember = "TenLDV";
                    lookUpLoaiDV.Properties.ValueMember = "MaLDV";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải loại dịch vụ: " + ex.Message, "Lỗi");
            }
        }

        private void LoadGridData()
        {
            try
            {
                // Lấy cả Tên Loại Dịch Vụ để hiển thị
                string query = @"
                    SELECT DV.MaDV, DV.TenDV, DV.GiaDV, DV.MaLDV, LDV.TenLDV 
                    FROM DichVu DV 
                    LEFT JOIN LoaiDV LDV ON DV.MaLDV = LDV.MaLDV";

                SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridControlDichVu.DataSource = dt;

                // Cấu hình GridView
                gridViewDichVu.Columns["MaDV"].Caption = "Mã DV";
                gridViewDichVu.Columns["TenDV"].Caption = "Tên Dịch Vụ";
                gridViewDichVu.Columns["GiaDV"].Caption = "Đơn Giá";
                gridViewDichVu.Columns["GiaDV"].DisplayFormat.FormatString = "n0"; // Định dạng số
                gridViewDichVu.Columns["GiaDV"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridViewDichVu.Columns["TenLDV"].Caption = "Loại Dịch Vụ";
                gridViewDichVu.Columns["MaLDV"].Visible = false; // Ẩn cột mã loại

                gridViewDichVu.BestFitColumns(); // Tự chỉnh độ rộng cột
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải danh sách dịch vụ: " + ex.Message, "Lỗi");
            }
        }

        private void ClearForm()
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            spinGiaDV.Value = 0;
            lookUpLoaiDV.EditValue = null;
            txtMaDV.ReadOnly = false;
            txtMaDV.Focus();
        }

        #endregion

        #region SỰ KIỆN CONTROLS

        private void gridViewDichVu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            try
            {
                DataRow dr = gridViewDichVu.GetDataRow(e.FocusedRowHandle);
                if (dr == null) return;

                txtMaDV.Text = dr["MaDV"].ToString();
                txtTenDV.Text = dr["TenDV"].ToString();
                spinGiaDV.Value = (dr["GiaDV"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["GiaDV"]);
                lookUpLoaiDV.EditValue = dr["MaLDV"]; // Gán bằng ValueMember

                txtMaDV.ReadOnly = true;
            }
            catch (Exception ex) { /* Bỏ qua lỗi nhỏ khi load */ }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDV.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập Mã Dịch Vụ.", "Thiếu thông tin");
                txtMaDV.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenDV.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập Tên Dịch Vụ.", "Thiếu thông tin");
                txtTenDV.Focus();
                return;
            }

            string query = "INSERT INTO DichVu (MaDV, TenDV, GiaDV, MaLDV) VALUES (@MaDV, @TenDV, @GiaDV, @MaLDV)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDV", txtMaDV.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenDV", txtTenDV.Text.Trim());
                        cmd.Parameters.AddWithValue("@GiaDV", (spinGiaDV.Value > 0) ? (object)spinGiaDV.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaLDV", lookUpLoaiDV.EditValue ?? (object)DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
                XtraMessageBox.Show("Thêm dịch vụ thành công!", "Thông báo");
                LoadGridData();
                ClearForm();
            }
            catch (SqlException sqlex) when (sqlex.Number == 2627) // Lỗi trùng khóa chính
            {
                XtraMessageBox.Show($"Mã dịch vụ '{txtMaDV.Text.Trim()}' đã tồn tại. Vui lòng nhập mã khác.", "Lỗi Trùng Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDV.Focus();
                txtMaDV.SelectAll();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thêm dịch vụ: " + ex.Message, "Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDV.Text) || txtMaDV.ReadOnly == false)
            {
                XtraMessageBox.Show("Vui lòng chọn một dịch vụ từ lưới để sửa.", "Chưa chọn dịch vụ");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenDV.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập Tên Dịch Vụ.", "Thiếu thông tin");
                txtTenDV.Focus();
                return;
            }

            string query = "UPDATE DichVu SET TenDV = @TenDV, GiaDV = @GiaDV, MaLDV = @MaLDV WHERE MaDV = @MaDV";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDV", txtTenDV.Text.Trim());
                        cmd.Parameters.AddWithValue("@GiaDV", (spinGiaDV.Value > 0) ? (object)spinGiaDV.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaLDV", lookUpLoaiDV.EditValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaDV", txtMaDV.Text.Trim()); // Điều kiện WHERE

                        cmd.ExecuteNonQuery();
                    }
                }
                XtraMessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo");
                LoadGridData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi cập nhật dịch vụ: " + ex.Message, "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDV.Text) || txtMaDV.ReadOnly == false)
            {
                XtraMessageBox.Show("Vui lòng chọn dịch vụ cần xóa.", "Chưa chọn dịch vụ");
                return;
            }

            if (XtraMessageBox.Show($"Bạn có chắc chắn muốn xóa dịch vụ '{txtTenDV.Text}' (Mã: {txtMaDV.Text}) không?",
                                     "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM DichVu WHERE MaDV = @MaDV";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaDV", txtMaDV.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    XtraMessageBox.Show("Xóa dịch vụ thành công!", "Thông báo");
                    LoadGridData();
                    ClearForm();
                }
                catch (SqlException sqlex) when (sqlex.Number == 547) // Lỗi khóa ngoại
                {
                    XtraMessageBox.Show("Không thể xóa dịch vụ này vì đang được sử dụng trong phiếu dịch vụ.", "Lỗi Khóa Ngoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi khi xóa dịch vụ: " + ex.Message, "Lỗi");
                }
            }
        }

        #endregion
    }
}