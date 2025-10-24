using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace Hotel_Management
{
    public partial class frmDanhSachPhong : DevExpress.XtraEditors.XtraForm
    {
        // THÊM DÒNG NÀY
        private string connectionString =
                @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";
        public frmDanhSachPhong()
        {
            InitializeComponent();
        }

        private void frmDanhSachPhong_Load(object sender, EventArgs e)
        {
            LoadLookUpData();
            LoadGridData();
            ClearForm();

            // Gán sự kiện
            gridViewPhong.FocusedRowChanged += gridViewPhong_FocusedRowChanged;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
        }

        #region HÀM TẢI DỮ LIỆU

        // Tải dữ liệu cho các ô LookUpEdit
        private void LoadLookUpData()
        {
            try
            {
                // Dùng 'using' để kết nối tự động đóng
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // 1. Load Loại phòng
                    SqlDataAdapter daLP = new SqlDataAdapter("SELECT MaLP, TenLP FROM LoaiPhong", conn);
                    DataTable dtLP = new DataTable();
                    daLP.Fill(dtLP);

                    lookUpLoaiPhong.Properties.DataSource = dtLP;
                    lookUpLoaiPhong.Properties.DisplayMember = "TenLP";
                    lookUpLoaiPhong.Properties.ValueMember = "MaLP";

                    // 2. Load Nhân viên
                    SqlDataAdapter daNV = new SqlDataAdapter("SELECT MaNV, HoTen FROM NhanVien", conn);
                    DataTable dtNV = new DataTable();
                    daNV.Fill(dtNV);

                    lookUpNhanVien.Properties.DataSource = dtNV;
                    lookUpNhanVien.Properties.DisplayMember = "HoTen";
                    lookUpNhanVien.Properties.ValueMember = "MaNV";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải dữ liệu danh mục: " + ex.Message);
            }
        }

        // Tải dữ liệu chính cho GridControl
        private void LoadGridData()
        {
            try
            {
                string query = @"
                    SELECT P.MaPhong, P.SoPhong, P.TinhTrang, 
                           P.MaLP, LP.TenLP, 
                           P.MaNV, NV.HoTen AS TenNV
                    FROM Phong P
                    LEFT JOIN LoaiPhong LP ON P.MaLP = LP.MaLP
                    LEFT JOIN NhanVien NV ON P.MaNV = NV.MaNV";

                SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridPhong.DataSource = dt;

                // Đặt tên cột
                gridViewPhong.Columns["MaPhong"].Caption = "Mã Phòng";
                gridViewPhong.Columns["SoPhong"].Caption = "Số Phòng";
                gridViewPhong.Columns["TinhTrang"].Caption = "Tình Trạng";
                gridViewPhong.Columns["TenLP"].Caption = "Loại Phòng";
                gridViewPhong.Columns["TenNV"].Caption = "NV Quản lý";

                // Ẩn các cột Mã
                gridViewPhong.Columns["MaLP"].Visible = false;
                gridViewPhong.Columns["MaNV"].Visible = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải danh sách phòng: " + ex.Message);
            }
        }

        // Xóa trắng form
        private void ClearForm()
        {
            txtMaPhong.Text = "";
            txtSoPhong.Text = "";
            lookUpLoaiPhong.EditValue = null;
            lookUpNhanVien.EditValue = null;
            cmbTinhTrang.SelectedItem = "Trống"; // Đặt mặc định
            txtMaPhong.ReadOnly = false;
            txtMaPhong.Focus();
        }

        #endregion

        #region SỰ KIỆN CONTROLS

        // Click vào một dòng trên lưới
        private void gridViewPhong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            try
            {
                DataRow dr = gridViewPhong.GetDataRow(e.FocusedRowHandle);
                if (dr == null) return;

                txtMaPhong.Text = dr["MaPhong"].ToString();
                txtSoPhong.Text = dr["SoPhong"].ToString();
                cmbTinhTrang.SelectedItem = dr["TinhTrang"].ToString();
                lookUpLoaiPhong.EditValue = dr["MaLP"];
                lookUpNhanVien.EditValue = dr["MaNV"];

                txtMaPhong.ReadOnly = true; // Không cho sửa Khóa chính
            }
            catch (Exception ex) { }
        }

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) || string.IsNullOrWhiteSpace(txtSoPhong.Text))
            {
                XtraMessageBox.Show("Mã phòng và Số phòng không được để trống!", "Cảnh báo");
                return;
            }

            string query = @"
                INSERT INTO Phong (MaPhong, SoPhong, MaLP, MaNV, TinhTrang) 
                VALUES (@MaPhong, @SoPhong, @MaLP, @MaNV, @TinhTrang)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim());
                        cmd.Parameters.AddWithValue("@SoPhong", txtSoPhong.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaLP", lookUpLoaiPhong.EditValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaNV", lookUpNhanVien.EditValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@TinhTrang", cmbTinhTrang.SelectedItem?.ToString() ?? "Trống");

                        cmd.ExecuteNonQuery();
                    }
                }

                XtraMessageBox.Show("Thêm phòng thành công!", "Thông báo");
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
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) || txtMaPhong.ReadOnly == false)
            {
                XtraMessageBox.Show("Vui lòng chọn một phòng từ lưới để sửa.", "Cảnh báo");
                return;
            }

            string query = @"
                UPDATE Phong 
                SET SoPhong = @SoPhong, MaLP = @MaLP, 
                    MaNV = @MaNV, TinhTrang = @TinhTrang
                WHERE MaPhong = @MaPhong";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoPhong", txtSoPhong.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaLP", lookUpLoaiPhong.EditValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaNV", lookUpNhanVien.EditValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@TinhTrang", cmbTinhTrang.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim()); // Điều kiện WHERE

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
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) || txtMaPhong.ReadOnly == false)
            {
                XtraMessageBox.Show("Vui lòng chọn phòng cần xóa.", "Cảnh báo");
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM Phong WHERE MaPhong = @MaPhong";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }

                    XtraMessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadGridData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    // Bẫy lỗi nếu phòng đang được thuê (FK constraint)
                    XtraMessageBox.Show("Lỗi khi xóa: Không thể xóa phòng này (có thể phòng đang được tham chiếu hoặc đang được thuê).", "Lỗi");
                }
            }
        }

        #endregion
    }
}