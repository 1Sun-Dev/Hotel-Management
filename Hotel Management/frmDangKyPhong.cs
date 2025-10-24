using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Hotel_Management
{
    public partial class frmDangKyPhong : DevExpress.XtraEditors.XtraForm
    {
        // 1. Chuỗi kết nối (Đảm bảo đúng!)
        private string connectionString =
            @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";

        public frmDangKyPhong()
        {
            InitializeComponent();
        }

        private void frmDangKyPhong_Load(object sender, EventArgs e)
        {
            // Thiết lập mặc định
            SetDefaultDates();

            // Tải dữ liệu
            LoadKhachHang();
            LoadPhongTrong();

            // Gán sự kiện
            searchLookUpKH.EditValueChanged += searchLookUpKH_EditValueChanged;
            searchLookUpPhong.EditValueChanged += searchLookUpPhong_EditValueChanged;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            btnDangKy.Click += btnDangKy_Click;
            btnHuy.Click += (s, args) => this.Close(); // Đóng form khi nhấn Hủy
        }

        #region HÀM TẢI DỮ LIỆU và THIẾT LẬP

        private void SetDefaultDates()
        {
            dateNgayThue.EditValue = DateTime.Now;
            // Mặc định ngày trả là ngày hôm sau
            dateNgayTra.EditValue = DateTime.Now.AddDays(1);
            // Giới hạn ngày trả không được nhỏ hơn ngày thuê (tùy chọn)
            dateNgayTra.Properties.MinValue = dateNgayThue.DateTime.Date;
            dateNgayThue.EditValueChanged += (s, args) => {
                dateNgayTra.Properties.MinValue = dateNgayThue.DateTime.Date;
                if (dateNgayTra.DateTime.Date < dateNgayThue.DateTime.Date)
                {
                    dateNgayTra.EditValue = dateNgayThue.DateTime.Date.AddDays(1);
                }
            };
        }

        private void LoadKhachHang()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaKH, HoTen, SDT, CCCD_HoChieu FROM KhachHang ORDER BY HoTen";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    searchLookUpKH.Properties.DataSource = dt;
                    // *** ĐẢM BẢO CÓ DÒNG NÀY VÀ ĐÚNG TÊN CỘT "HoTen" ***
                    searchLookUpKH.Properties.DisplayMember = "HoTen";
                    searchLookUpKH.Properties.ValueMember = "MaKH";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải danh sách khách hàng: " + ex.Message);
            }
        }

        private void LoadPhongTrong()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT P.MaPhong, P.SoPhong, LP.TenLP, LP.DonGia 
                FROM Phong P
                JOIN LoaiPhong LP ON P.MaLP = LP.MaLP
                WHERE P.TinhTrang = N'Trống'
                ORDER BY P.SoPhong";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    searchLookUpPhong.Properties.DataSource = dt;
                    // *** ĐẢM BẢO CÓ DÒNG NÀY VÀ ĐÚNG TÊN CỘT "SoPhong" ***
                    searchLookUpPhong.Properties.DisplayMember = "SoPhong";
                    searchLookUpPhong.Properties.ValueMember = "MaPhong";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải danh sách phòng trống: " + ex.Message);
            }
        }

        // Làm mới form sau khi đăng ký thành công hoặc khi cần
        private void ResetForm()
        {
            LoadPhongTrong(); // Tải lại phòng trống
            txtMaPTP.Text = "";
            txtMaPTP.ReadOnly = false; // Mở khóa
            searchLookUpKH.EditValue = null;
            searchLookUpPhong.EditValue = null;
            txtSDT.Text = "";
            txtCCCD.Text = "";
            txtLoaiPhong.Text = "";
            spinDonGia.Value = 0;
            SetDefaultDates(); // Đặt lại ngày thuê/trả
            txtMaPTP.Focus(); // Focus vào ô Mã PTP (nếu muốn nhập tay)
        }


        #endregion

        #region SỰ KIỆN CONTROLS

        // Khi chọn 1 khách hàng -> tự điền SĐT và CCCD
        private void searchLookUpKH_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as GridLookUpEdit;
            if (edit.EditValue == null) return;

            // Lấy dòng dữ liệu tương ứng với khách hàng được chọn
            DataRowView drv = edit.GetSelectedDataRow() as DataRowView;
            if (drv != null)
            {
                txtSDT.Text = drv["SDT"]?.ToString();
                txtCCCD.Text = drv["CCCD_HoChieu"]?.ToString();
            }
        }

        // Khi chọn 1 phòng -> tự điền Loại phòng và Đơn giá
        private void searchLookUpPhong_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as GridLookUpEdit;
            if (edit.EditValue == null) return;

            DataRowView drv = edit.GetSelectedDataRow() as DataRowView;
            if (drv != null)
            {
                txtLoaiPhong.Text = drv["TenLP"]?.ToString();
                spinDonGia.Value = Convert.ToDecimal(drv["DonGia"]);
            }
        }

        // Nút mở form QL Khách hàng (nếu khách mới)
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            // Mở form QLKhachHang
            frmQLKhachHang frm = new frmQLKhachHang();
            frm.ShowDialog(); // Hiển thị form (chờ đóng xong mới làm tiếp)

            // Sau khi form QLKhachHang đóng, tải lại danh sách khách hàng
            LoadKhachHang();
        }

        // Nút quan trọng nhất: Đăng ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu đầu vào
            if (searchLookUpKH.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn khách hàng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                searchLookUpKH.Focus();
                return;
            }
            if (searchLookUpPhong.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn phòng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                searchLookUpPhong.Focus();
                return;
            }
            if (dateNgayThue.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn ngày thuê.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNgayThue.Focus();
                return;
            }
            if (dateNgayTra.EditValue == null || dateNgayTra.DateTime.Date < dateNgayThue.DateTime.Date)
            {
                XtraMessageBox.Show("Ngày trả dự kiến không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNgayTra.Focus();
                return;
            }


            // 2. Tạo Mã PTP mới và lấy thông tin
            string maPTP = "PTP" + DateTime.Now.ToString("yyMMddHH");
            string maKH = searchLookUpKH.EditValue.ToString();
            string maPhong = searchLookUpPhong.EditValue.ToString();
            DateTime ngayThue = dateNgayThue.DateTime;
            // DateTime ngayTraDuKien = dateNgayTra.DateTime; // Lấy ngày trả dự kiến (chưa dùng để lưu)

            // 3. Thực hiện lưu vào CSDL bằng Transaction
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Lệnh 1: Tạo PhieuThuePhong (Chỉ lưu MaPTP, NgayThue, MaKH)
                    string queryPTP = "INSERT INTO PhieuThuePhong (MaPTP, NgayThue, MaKH) VALUES (@MaPTP, @NgayThue, @MaKH)";
                    using (SqlCommand cmd = new SqlCommand(queryPTP, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaPTP", maPTP);
                        cmd.Parameters.AddWithValue("@NgayThue", ngayThue);
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.ExecuteNonQuery();
                    }

                    // Lệnh 2: Tạo CT_ThuePhong
                    string queryCT_PTP = "INSERT INTO CT_ThuePhong (MaPTP, MaPhong) VALUES (@MaPTP, @MaPhong)";
                    using (SqlCommand cmd = new SqlCommand(queryCT_PTP, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaPTP", maPTP);
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.ExecuteNonQuery();
                    }

                    // Lệnh 3: Cập nhật Tình trạng Phòng -> Đang thuê
                    string queryPhong = "UPDATE Phong SET TinhTrang = N'Đang thuê' WHERE MaPhong = @MaPhong";
                    using (SqlCommand cmd = new SqlCommand(queryPhong, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.ExecuteNonQuery();
                    }

                    // Nếu không có lỗi, commit transaction
                    transaction.Commit();

                    XtraMessageBox.Show($"Đăng ký phòng thành công!\nMã Phiếu Thuê: {maPTP}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới form
                    ResetForm();

                }
                catch (SqlException sqlex) when (sqlex.Number == 2627) // Lỗi trùng Mã PTP (hiếm)
                {
                    transaction.Rollback();
                    XtraMessageBox.Show($"Lỗi trùng Mã Phiếu Thuê '{maPTP}'. Vui lòng thử lại.", "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Nếu có bất kỳ lỗi nào, hủy bỏ transaction
                    transaction.Rollback();
                    XtraMessageBox.Show("Đăng ký thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // Kết nối tự động đóng lại ở đây
        }

        #endregion
    }
}