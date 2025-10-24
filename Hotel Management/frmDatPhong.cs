using DevExpress.XtraEditors;
using Microsoft.VisualBasic; // Cần add reference Microsoft.VisualBasic
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class frmDatPhong : DevExpress.XtraEditors.XtraForm
    {
        // 1. Chuỗi kết nối
        private string connectionString =
            @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";

        // 2. DataTables để quản lý dữ liệu động
        private DataTable dtPhongTrong;
        private DataTable dtPhongDat;
        private DataTable dtDichVu;
        private DataTable dtDichVuDaDung;

        public frmDatPhong()
        {
            InitializeComponent();
            SetupDataTables();
        }

        // Khởi tạo các DataTable
        private void SetupDataTables()
        {
            // Phòng đã đặt (chứa các phòng được chọn từ lưới bên trái)
            dtPhongDat = new DataTable();
            dtPhongDat.Columns.Add("MaPhong", typeof(string));
            dtPhongDat.Columns.Add("SoPhong", typeof(string)); // Đổi tên cột để tránh trùng
            dtPhongDat.Columns.Add("DonGia", typeof(decimal));
            gridPhongDat.DataSource = dtPhongDat;

            // Dịch vụ đã dùng (chứa dịch vụ được chọn từ lưới bên phải)
            dtDichVuDaDung = new DataTable();
            dtDichVuDaDung.Columns.Add("MaDV", typeof(string));
            dtDichVuDaDung.Columns.Add("TenDV", typeof(string)); // Đổi tên cột
            dtDichVuDaDung.Columns.Add("SoLuong", typeof(int));
            dtDichVuDaDung.Columns.Add("DonGiaDV", typeof(decimal)); // Đổi tên cột
            dtDichVuDaDung.Columns.Add("ThanhTien", typeof(decimal));
            gridDichVuDaDung.DataSource = dtDichVuDaDung;
        }


        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            LoadInitialData();
            AssignEventHandlers();
        }

        // Gán các sự kiện
        private void AssignEventHandlers()
        {
            // Menu
            btnLuu.ItemClick += btnLuu_ItemClick;
            btnBoQua.ItemClick += btnBoQua_ItemClick;

            // GridViews Double Click
            gridViewPhongTrong.DoubleClick += gridViewPhongTrong_DoubleClick;
            gridViewSanPhamDichVu.DoubleClick += gridViewSanPhamDichVu_DoubleClick;
            // (Thêm sự kiện DoubleClick cho gridViewPhongDat, gridViewDichVuDaDung nếu muốn xóa/sửa)

            // LookUpEdit
            searchLookUpKhachHang.EditValueChanged += searchLookUpKhachHang_EditValueChanged;
        }


        #region HÀM TẢI DỮ LIỆU BAN ĐẦU

        private void LoadInitialData()
        {
            LoadKhachHang();
            LoadPhongTrong();
            LoadSanPhamDichVu();
            SetDefaults();
        }

        private void LoadKhachHang()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaKH, HoTen, SDT FROM KhachHang";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    searchLookUpKhachHang.Properties.DataSource = dt;
                    searchLookUpKhachHang.Properties.DisplayMember = "HoTen";
                    searchLookUpKhachHang.Properties.ValueMember = "MaKH";
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Lỗi tải khách hàng: " + ex.Message); }
        }

        private void LoadPhongTrong()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Giả sử có cột TANG trong bảng Phong
                    string query = @"
                        SELECT P.MaPhong, P.SoPhong, LP.DonGia, P.TANG
                        FROM Phong P
                        JOIN LoaiPhong LP ON P.MaLP = LP.MaLP
                        WHERE P.TinhTrang = N'Trống'";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    dtPhongTrong = new DataTable(); // Gán vào biến global
                    da.Fill(dtPhongTrong);
                    gridPhongTrong.DataSource = dtPhongTrong;

                    // Group theo tầng
                    gridViewPhongTrong.Columns["TANG"].GroupIndex = 0;
                    gridViewPhongTrong.ExpandAllGroups(); // Mở rộng tất cả group
                    gridViewPhongTrong.Columns["TANG"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending; // Sắp xếp tầng

                    // Đổi tên cột hiển thị
                    gridViewPhongTrong.Columns["SoPhong"].Caption = "TÊN PHÒNG";
                    gridViewPhongTrong.Columns["DonGia"].Caption = "ĐƠN GIÁ";
                    gridViewPhongTrong.Columns["DonGia"].DisplayFormat.FormatString = "n0";
                    gridViewPhongTrong.Columns["DonGia"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    gridViewPhongTrong.Columns["MaPhong"].Visible = false; // Ẩn mã phòng
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Lỗi tải phòng trống: " + ex.Message); }
        }

        private void LoadSanPhamDichVu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaDV, TenDV, GiaDV FROM DichVu";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    dtDichVu = new DataTable(); // Gán vào biến global
                    da.Fill(dtDichVu);
                    gridSanPhamDichVu.DataSource = dtDichVu;

                    // Đổi tên cột hiển thị
                    gridViewSanPhamDichVu.Columns["TenDV"].Caption = "TÊN SP - DV";
                    gridViewSanPhamDichVu.Columns["GiaDV"].Caption = "ĐƠN GIÁ";
                    gridViewSanPhamDichVu.Columns["GiaDV"].DisplayFormat.FormatString = "n0";
                    gridViewSanPhamDichVu.Columns["GiaDV"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    gridViewSanPhamDichVu.Columns["MaDV"].Visible = false; // Ẩn mã DV
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Lỗi tải dịch vụ: " + ex.Message); }
        }

        private void SetDefaults()
        {
            dateNgayDat.EditValue = DateTime.Now;
            dateNgayTra.EditValue = DateTime.Now.AddDays(1);
            cboTrangThai.SelectedItem = "Đã đặt"; // Hoặc trạng thái mặc định của bạn
            spinSoNguoi.Value = 1;
            ClearSelection();
        }

        private void ClearSelection()
        {
            searchLookUpKhachHang.EditValue = null;
            memoGhiChu.Text = "";
            dtPhongDat.Clear();
            dtDichVuDaDung.Clear();
            CalculateTotal();
        }

        #endregion

        #region XỬ LÝ SỰ KIỆN CHỌN/THÊM/BỚT

        // Khi chọn khách hàng
        private void searchLookUpKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            // Có thể thêm code để hiển thị thêm thông tin khách hàng nếu cần
        }

        // Double click vào phòng trống -> chuyển sang phòng đặt
        private void gridViewPhongTrong_DoubleClick(object sender, EventArgs e)
        {
            int focusedRowHandle = gridViewPhongTrong.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                DataRow sourceRow = gridViewPhongTrong.GetDataRow(focusedRowHandle);
                if (sourceRow != null)
                {
                    // Thêm vào bảng Phòng đặt
                    dtPhongDat.Rows.Add(
                        sourceRow["MaPhong"],
                        sourceRow["SoPhong"], // Dùng tên cột đã đổi
                        sourceRow["DonGia"]
                    );

                    // Xóa khỏi bảng Phòng trống (DataSource)
                    // Cách 1: Remove trực tiếp (nếu DataSource là DataTable)
                    sourceRow.Delete();
                    dtPhongTrong.AcceptChanges(); // Commit việc xóa

                    // Cách 2: Nếu DataSource phức tạp hơn, cần tạo lại DataSource mới không chứa dòng đó
                    // dtPhongTrong.Rows.Remove(sourceRow); // Thử cách này trước
                    // gridPhongTrong.RefreshDataSource();
                }
            }
        }

        // Double click vào dịch vụ -> Thêm vào dịch vụ đã dùng
        private void gridViewSanPhamDichVu_DoubleClick(object sender, EventArgs e)
        {
            int focusedRowHandle = gridViewSanPhamDichVu.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                DataRow sourceRow = gridViewSanPhamDichVu.GetDataRow(focusedRowHandle);
                if (sourceRow != null)
                {
                    string maDV = sourceRow["MaDV"].ToString();
                    string tenDV = sourceRow["TenDV"].ToString();
                    decimal donGia = Convert.ToDecimal(sourceRow["GiaDV"]);

                    // Hỏi số lượng
                    string input = Interaction.InputBox($"Nhập số lượng cho '{tenDV}':", "Số lượng", "1");
                    int soLuong;
                    if (int.TryParse(input, out soLuong) && soLuong > 0)
                    {
                        // Kiểm tra xem dịch vụ đã có trong danh sách chưa
                        DataRow existingRow = dtDichVuDaDung.Select($"MaDV = '{maDV}'").FirstOrDefault();
                        if (existingRow != null)
                        {
                            // Cập nhật số lượng và thành tiền
                            existingRow["SoLuong"] = (int)existingRow["SoLuong"] + soLuong;
                            existingRow["ThanhTien"] = (int)existingRow["SoLuong"] * (decimal)existingRow["DonGiaDV"];
                        }
                        else
                        {
                            // Thêm mới
                            dtDichVuDaDung.Rows.Add(
                                maDV,
                                tenDV,
                                soLuong,
                                donGia,
                                soLuong * donGia
                            );
                        }
                        CalculateTotal(); // Tính lại tổng tiền
                    }
                    else if (!string.IsNullOrEmpty(input)) // Nếu người dùng nhập không phải số
                    {
                        XtraMessageBox.Show("Số lượng không hợp lệ!");
                    }
                }
            }
        }

        #endregion

        #region TÍNH TOÁN & LƯU

        // Tính tổng tiền dịch vụ
        private void CalculateTotal()
        {
            decimal tongTienDichVu = 0;
            foreach (DataRow row in dtDichVuDaDung.Rows)
            {
                tongTienDichVu += Convert.ToDecimal(row["ThanhTien"]);
            }

            // Hiển thị tổng tiền dịch vụ (Tạm thời coi đây là Tổng thanh toán)
            txtTongThanhToan.EditValue = tongTienDichVu;

            // Tổng tiền (bao gồm cả phòng) sẽ phức tạp hơn, tạm để = tiền DV
            txtTongTien.EditValue = tongTienDichVu;
        }

        // Sự kiện nút Lưu
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 1. Kiểm tra dữ liệu
            if (searchLookUpKhachHang.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn khách hàng.", "Thiếu thông tin");
                searchLookUpKhachHang.Focus();
                return;
            }
            if (dtPhongDat.Rows.Count == 0)
            {
                XtraMessageBox.Show("Vui lòng chọn ít nhất một phòng.", "Thiếu thông tin");
                // Nên focus vào gridPhongTrong hoặc gridPhongDat
                return;
            }
            // (Thêm kiểm tra ngày đặt, ngày trả hợp lệ)

            // 2. Lấy thông tin chung
            string maKH = searchLookUpKhachHang.EditValue.ToString();
            DateTime ngayDat = dateNgayDat.DateTime; // Ngày đặt phòng (dự kiến nhận)
            // DateTime ngayTraMongMuon = dateNgayTra.DateTime; // Ngày trả dự kiến
            string ghiChu = memoGhiChu.Text;
            string trangThai = cboTrangThai.SelectedItem.ToString();
            // int soNguoi = (int)spinSoNguoi.Value; // Có thể cần lưu

            // 3. Tạo Mã Phiếu Đặt Phòng (Tự động hoặc nhập tay)
            // Ví dụ tự động:
            string maPDP = "PDP" + DateTime.Now.ToString("yyMMddHHmmss");


            // 4. Lưu vào CSDL dùng Transaction
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // === Lưu PhieuDatPhong ===
                    string sqlPDP = "INSERT INTO PhieuDatPhong (MaPDP, NgayNhan, TinhTrang, MaKH) VALUES (@MaPDP, @NgayNhan, @TinhTrang, @MaKH)";
                    using (SqlCommand cmdPDP = new SqlCommand(sqlPDP, conn, trans))
                    {
                        cmdPDP.Parameters.AddWithValue("@MaPDP", maPDP);
                        cmdPDP.Parameters.AddWithValue("@NgayNhan", ngayDat); // Lưu ngày dự kiến nhận
                        cmdPDP.Parameters.AddWithValue("@TinhTrang", trangThai);
                        cmdPDP.Parameters.AddWithValue("@MaKH", maKH);
                        // (Thêm các cột khác nếu cần: Ghi chú, Số người...)
                        cmdPDP.ExecuteNonQuery();
                    }

                    // === Lưu CT_DatPhong (lặp qua các phòng đã chọn) ===
                    string sqlCTDP = "INSERT INTO CT_DatPhong (MaPDP, MaPhong) VALUES (@MaPDP, @MaPhong)";
                    foreach (DataRow rowPhong in dtPhongDat.Rows)
                    {
                        using (SqlCommand cmdCTDP = new SqlCommand(sqlCTDP, conn, trans))
                        {
                            cmdCTDP.Parameters.AddWithValue("@MaPDP", maPDP);
                            cmdCTDP.Parameters.AddWithValue("@MaPhong", rowPhong["MaPhong"]);
                            cmdCTDP.ExecuteNonQuery();

                            // !!! QUAN TRỌNG: Cập nhật trạng thái phòng thành "Đã đặt" hoặc tương tự?
                            // Tùy nghiệp vụ: Nếu đặt trước thì KHÔNG đổi trạng thái phòng ngay
                            // Nếu là check-in ngay thì đổi thành "Đang thuê"
                            /*
                            string sqlUpdatePhong = "UPDATE Phong SET TinhTrang = N'Đã đặt' WHERE MaPhong = @MaPhong";
                            using(SqlCommand cmdUpdatePhong = new SqlCommand(sqlUpdatePhong, conn, trans))
                            {
                                cmdUpdatePhong.Parameters.AddWithValue("@MaPhong", rowPhong["MaPhong"]);
                                cmdUpdatePhong.ExecuteNonQuery();
                            }
                            */
                        }
                    }

                    // === Lưu PhieuDV (lặp qua các dịch vụ đã chọn) ===
                    // Lưu ý: PhieuDV thường gắn với PhieuThuePhong khi check-in, chứ ít khi gắn với PhieuDatPhong
                    // Tạm thời bỏ qua bước lưu dịch vụ ở đây, sẽ lưu khi check-in hoặc gọi món sau
                    /*
                    string sqlPDV = "INSERT INTO PhieuDV (MaPDV, MaPTP, MaDV, SoLuong, ThanhTien) VALUES (...)";
                    foreach (DataRow rowDV in dtDichVuDaDung.Rows)
                    {
                       // ... Tạo mã PDV, lấy MaPTP (nếu có), ...
                    }
                    */

                    // === Hoàn tất ===
                    trans.Commit(); // Lưu tất cả nếu không lỗi
                    XtraMessageBox.Show("Đặt phòng thành công với Mã Phiếu: " + maPDP, "Thông báo");

                    // Reset form
                    LoadPhongTrong(); // Tải lại phòng trống (nếu có đổi trạng thái)
                    ClearSelection(); // Xóa các lựa chọn hiện tại

                }
                catch (Exception ex)
                {
                    trans.Rollback(); // Hủy tất cả nếu có lỗi
                    XtraMessageBox.Show("Đặt phòng thất bại! Lỗi: " + ex.Message, "Lỗi");
                }
            }
        }

        // Sự kiện nút Bỏ qua / Làm mới
        private void btnBoQua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Tải lại dữ liệu gốc và xóa lựa chọn
            LoadPhongTrong(); // Tải lại phòng trống (quan trọng nếu đã xóa nhầm)
            ClearSelection();
        }

        #endregion

    }
}