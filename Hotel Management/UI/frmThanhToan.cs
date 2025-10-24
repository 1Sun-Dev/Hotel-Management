using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns; // Needed for GridColumn Summary
using DevExpress.Data; // Needed for SummaryItemType

namespace Hotel_Management
{
    public partial class frmThanhToan : DevExpress.XtraEditors.XtraForm
    {
        // 1. Chuỗi kết nối
        private string connectionString =
            @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";

        // Biến lưu thông tin cần thiết khi chọn phòng
        private string selectedMaPTP = null;
        private DateTime ngayThue;
        private decimal donGiaPhong = 0;

        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            LoadPhongDangThue();
            dateNgayTra.EditValue = DateTime.Now; // Mặc định ngày trả là hôm nay

            // Gán sự kiện
            btnThanhToan.Click += btnThanhToan_Click;
            btnHuy.Click += (s, args) => this.Close();

            // Cấu hình cột Tổng cộng cho lưới Dịch vụ
            SetupDichVuGridSummary();
        }

        #region HÀM TẢI DỮ LIỆU VÀ TÍNH TOÁN

        // Tải danh sách phòng đang thuê vào LookUpEdit
        private void LoadPhongDangThue()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // *** ĐÂY LÀ CÂU QUERY QUAN TRỌNG NHẤT ***
                    // Nó chỉ lấy phòng nào CÓ PHIẾU THUÊ CHƯA TRẢ (NgayTra IS NULL)
                    string query = @"
                SELECT DISTINCT P.MaPhong, P.SoPhong, KH.HoTen 
                FROM Phong P
                JOIN CT_ThuePhong CTP ON P.MaPhong = CTP.MaPhong
                JOIN PhieuThuePhong PTP ON CTP.MaPTP = PTP.MaPTP
                JOIN KhachHang KH ON PTP.MaKH = KH.MaKH
                WHERE PTP.NgayTra IS NULL 
                ORDER BY P.SoPhong";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    lookUpPhongDangThue.Properties.DataSource = dt;
                    // DisplayMember và ValueMember đã được set trong Designer
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải danh sách phòng đang thuê: " + ex.Message, "Lỗi");
            }
        }

        // Sự kiện khi chọn phòng khác
        private void lookUpPhongDangThue_EditValueChanged(object sender, EventArgs e)
        {
            // Lấy LookUpEdit control
            LookUpEdit lookUp = sender as LookUpEdit;
            if (lookUp.EditValue == null || lookUp.EditValue == DBNull.Value)
            {
                ClearDetails();
                return;
            }

            // Lấy giá trị được chọn (chính là MaPhong vì đã set ValueMember)
            string maPhong = lookUp.EditValue.ToString();

            // Gọi hàm load chi tiết với MaPhong đã lấy được
            LoadThongTinThuePhong(maPhong);
        }

        // Tải thông tin chi tiết khi chọn phòng
        private void LoadThongTinThuePhong(string maPhong)
        {
            ClearDetails(); // Xóa thông tin cũ trước khi load mới
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT TOP 1 PTP.MaPTP, PTP.NgayThue, KH.HoTen, LP.TenLP, LP.DonGia
                FROM PhieuThuePhong PTP
                JOIN KhachHang KH ON PTP.MaKH = KH.MaKH
                JOIN CT_ThuePhong CTP ON PTP.MaPTP = CTP.MaPTP AND CTP.MaPhong = @MaPhong
                JOIN Phong P ON CTP.MaPhong = P.MaPhong
                JOIN LoaiPhong LP ON P.MaLP = LP.MaLP
                WHERE PTP.NgayTra IS NULL
                ORDER BY PTP.NgayThue DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read()) // *** KIỂM TRA KẾT QUẢ ***
                        {
                            // === Lấy dữ liệu ===
                            selectedMaPTP = reader["MaPTP"].ToString();
                            ngayThue = Convert.ToDateTime(reader["NgayThue"]);
                            donGiaPhong = Convert.ToDecimal(reader["DonGia"]);

                            txtTenKhachHang.Text = reader["HoTen"].ToString();
                            dateNgayThue.EditValue = ngayThue;
                            txtLoaiPhong.Text = reader["TenLP"].ToString();

                            reader.Close();

                            // === Tải thông tin phụ ===
                            LoadDichVuDaSuDung(selectedMaPTP);
                            CalculateCosts();
                            txtMaHD.Text = "HD" + DateTime.Now.ToString("yyMMddHHmmss");
                        }
                        else // *** NẾU KHÔNG CÓ DỮ LIỆU (KHÔNG NÊN XẢY RA) ***
                        {
                            reader.Close();
                            ClearDetails();
                            // Thông báo lỗi cụ thể hơn
                            XtraMessageBox.Show($"Lỗi dữ liệu không nhất quán!\nPhòng '{lookUpPhongDangThue.Text}' (Mã: {maPhong}) được chọn nhưng không tìm thấy phiếu thuê phòng đang hoạt động (NgayTra IS NULL).\n\nVui lòng kiểm tra lại trạng thái của phòng này trong CSDL.",
                                                "Lỗi Dữ Liệu Nghiêm Trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải thông tin thuê phòng: " + ex.Message, "Lỗi");
                ClearDetails();
            }
        }

        // Tải danh sách dịch vụ đã sử dụng
        private void LoadDichVuDaSuDung(string maPTP)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Lấy thông tin từ PhieuDV và TenDV từ DichVu
                    string query = @"
                        SELECT PDV.MaDV, DV.TenDV, PDV.SoLuong, DV.GiaDV, PDV.ThanhTien 
                        FROM PhieuDV PDV
                        JOIN DichVu DV ON PDV.MaDV = DV.MaDV
                        WHERE PDV.MaPTP = @MaPTP";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaPTP", maPTP);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControlDichVuSD.DataSource = dt;

                    // Cấu hình GridView Dịch Vụ
                    gridViewDichVuSD.Columns["MaDV"].Visible = false;
                    gridViewDichVuSD.Columns["TenDV"].Caption = "Tên Dịch Vụ";
                    gridViewDichVuSD.Columns["SoLuong"].Caption = "SL";
                    gridViewDichVuSD.Columns["GiaDV"].Caption = "Đơn Giá";
                    gridViewDichVuSD.Columns["GiaDV"].DisplayFormat.FormatString = "n0";
                    gridViewDichVuSD.Columns["GiaDV"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    gridViewDichVuSD.Columns["ThanhTien"].Caption = "Thành Tiền";
                    gridViewDichVuSD.Columns["ThanhTien"].DisplayFormat.FormatString = "n0";
                    gridViewDichVuSD.Columns["ThanhTien"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    gridViewDichVuSD.Columns["ThanhTien"].SummaryItem.SummaryType = SummaryItemType.Sum; // Tính tổng cột thành tiền
                    gridViewDichVuSD.Columns["ThanhTien"].SummaryItem.DisplayFormat = "Tổng: {0:n0}";

                    gridViewDichVuSD.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải danh sách dịch vụ: " + ex.Message, "Lỗi");
                gridControlDichVuSD.DataSource = null; // Xóa dữ liệu cũ nếu lỗi
            }
        }

        // Cấu hình Footer Summary cho GridView Dịch vụ
        private void SetupDichVuGridSummary()
        {
            gridViewDichVuSD.OptionsView.ShowFooter = true; // Bật footer
            GridColumn colThanhTien = gridViewDichVuSD.Columns["ThanhTien"];
            if (colThanhTien != null)
            {
                colThanhTien.SummaryItem.SummaryType = SummaryItemType.Sum;
                colThanhTien.SummaryItem.DisplayFormat = "Tổng cộng: {0:n0}";
            }
        }

        // Sự kiện khi thay đổi ngày trả
        private void dateNgayTra_EditValueChanged(object sender, EventArgs e)
        {
            CalculateCosts(); // Tính lại tiền khi ngày trả thay đổi
        }

        // Tính toán các chi phí
        private void CalculateCosts()
        {
            if (dateNgayTra.EditValue == null || ngayThue == DateTime.MinValue || donGiaPhong <= 0)
            {
                spinSoNgayO.Value = 0;
                calcTienPhong.Value = 0;
                calcTienDichVu.Value = 0;
                calcTongTien.Value = 0;
                return;
            }

            DateTime ngayTra = dateNgayTra.DateTime;

            // Tính số ngày ở (ít nhất 1 ngày)
            TimeSpan duration = ngayTra.Date - ngayThue.Date;
            int soNgay = (int)Math.Max(1, Math.Ceiling(duration.TotalDays)); // Làm tròn lên và tối thiểu 1 ngày
            spinSoNgayO.Value = soNgay;

            // Tính tiền phòng
            decimal tienPhong = soNgay * donGiaPhong;
            calcTienPhong.Value = tienPhong;

            // Tính tiền dịch vụ (lấy từ summary của GridView)
            decimal tienDichVu = 0;
            if (gridViewDichVuSD.Columns["ThanhTien"] != null)
            {
                object summaryValue = gridViewDichVuSD.Columns["ThanhTien"].SummaryItem.SummaryValue;
                if (summaryValue != null && summaryValue != DBNull.Value)
                {
                    tienDichVu = Convert.ToDecimal(summaryValue);
                }
            }
            calcTienDichVu.Value = tienDichVu;

            // Tính tổng tiền
            calcTongTien.Value = tienPhong + tienDichVu;
        }

        // Xóa các chi tiết khi không chọn phòng
        private void ClearDetails()
        {
            selectedMaPTP = null;
            ngayThue = DateTime.MinValue;
            donGiaPhong = 0;
            txtTenKhachHang.Text = "";
            dateNgayThue.EditValue = null;
            txtLoaiPhong.Text = "";
            spinSoNgayO.Value = 0;
            gridControlDichVuSD.DataSource = null;
            calcTienPhong.Value = 0;
            calcTienDichVu.Value = 0;
            calcTongTien.Value = 0;
            txtMaHD.Text = "";
        }

        #endregion

        #region XỬ LÝ THANH TOÁN

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu
            if (lookUpPhongDangThue.EditValue == null || string.IsNullOrEmpty(selectedMaPTP))
            {
                XtraMessageBox.Show("Vui lòng chọn phòng cần thanh toán.", "Thiếu thông tin");
                return;
            }
            if (dateNgayTra.EditValue == null || dateNgayTra.DateTime < ngayThue)
            {
                XtraMessageBox.Show("Ngày trả không hợp lệ.", "Lỗi nhập liệu");
                dateNgayTra.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập Mã Hóa Đơn.", "Thiếu thông tin");
                txtMaHD.Focus();
                return;
            }

            // Xác nhận thanh toán
            if (XtraMessageBox.Show($"Xác nhận thanh toán cho phòng {lookUpPhongDangThue.Text}?\nTổng tiền: {calcTongTien.Value:N0} VNĐ",
                                     "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            // 2. Lấy dữ liệu cần thiết
            string maHD = txtMaHD.Text.Trim();
            string maPhong = lookUpPhongDangThue.EditValue.ToString();
            DateTime ngayTra = dateNgayTra.DateTime;
            decimal tongTien = calcTongTien.Value;

            // 3. Thực hiện Transaction
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // Lệnh 1: Insert HoaDon
                    string sqlHD = "INSERT INTO HoaDon (MaHD, NgayVao, NgayRa, TongTien) VALUES (@MaHD, @NgayVao, @NgayRa, @TongTien)";
                    using (SqlCommand cmdHD = new SqlCommand(sqlHD, conn, trans))
                    {
                        cmdHD.Parameters.AddWithValue("@MaHD", maHD);
                        cmdHD.Parameters.AddWithValue("@NgayVao", ngayThue); // Lấy ngày thuê từ biến global
                        cmdHD.Parameters.AddWithValue("@NgayRa", ngayTra);
                        cmdHD.Parameters.AddWithValue("@TongTien", tongTien);
                        cmdHD.ExecuteNonQuery();
                    }

                    // Lệnh 2: Insert CT_HoaDon
                    // Giả định 1 hóa đơn chỉ cho 1 phiếu thuê phòng chính
                    string sqlCTHD = "INSERT INTO CT_HoaDon (MaHD, MaPTP, SoLuong, TongTien) VALUES (@MaHD, @MaPTP, @SoLuong, @TongTien)";
                    using (SqlCommand cmdCTHD = new SqlCommand(sqlCTHD, conn, trans))
                    {
                        cmdCTHD.Parameters.AddWithValue("@MaHD", maHD);
                        cmdCTHD.Parameters.AddWithValue("@MaPTP", selectedMaPTP); // Lấy MaPTP từ biến global
                        cmdCTHD.Parameters.AddWithValue("@SoLuong", 1); // Số lượng phiếu thuê trong hóa đơn
                        cmdCTHD.Parameters.AddWithValue("@TongTien", tongTien);
                        cmdCTHD.ExecuteNonQuery();
                    }

                    // Lệnh 3: Update PhieuThuePhong (Set NgayTra)
                    string sqlPTP = "UPDATE PhieuThuePhong SET NgayTra = @NgayTra WHERE MaPTP = @MaPTP";
                    using (SqlCommand cmdPTP = new SqlCommand(sqlPTP, conn, trans))
                    {
                        cmdPTP.Parameters.AddWithValue("@NgayTra", ngayTra);
                        cmdPTP.Parameters.AddWithValue("@MaPTP", selectedMaPTP);
                        cmdPTP.ExecuteNonQuery();
                    }

                    // Lệnh 4: Update Phong (Set TinhTrang)
                    string sqlPhong = "UPDATE Phong SET TinhTrang = N'Đang dọn' WHERE MaPhong = @MaPhong"; // Hoặc 'Trống'
                    using (SqlCommand cmdPhong = new SqlCommand(sqlPhong, conn, trans))
                    {
                        cmdPhong.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmdPhong.ExecuteNonQuery();
                    }

                    // Hoàn tất
                    trans.Commit();
                    XtraMessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới form
                    LoadPhongDangThue(); // Tải lại danh sách phòng
                    ClearDetails(); // Xóa chi tiết

                }
                catch (SqlException sqlex) when (sqlex.Number == 2627) // Lỗi trùng Mã Hóa Đơn
                {
                    trans.Rollback();
                    XtraMessageBox.Show($"Mã Hóa Đơn '{maHD}' đã tồn tại. Vui lòng nhập mã khác.", "Lỗi Trùng Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaHD.Focus();
                    txtMaHD.SelectAll();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    XtraMessageBox.Show("Thanh toán thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

    }
}