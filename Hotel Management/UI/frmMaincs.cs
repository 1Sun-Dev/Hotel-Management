using DevExpress.XtraBars;

using DevExpress.XtraTabbedMdi;

using System;

using System.Data.SqlClient;

using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using Hotel_Management.Report;
using DevExpress.XtraReports.UI;
namespace Hotel_Management

{

    public partial class frmMaincs : DevExpress.XtraBars.Ribbon.RibbonForm

    {

        // Quản lý các tab con

        private XtraTabbedMdiManager mdiManager;

        private readonly string connectionString =

    @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";

        public frmMaincs()

        {

            InitializeComponent();

            InitializeMdiManager();

        }



        private void InitializeMdiManager()

        {

            mdiManager = new XtraTabbedMdiManager();

            mdiManager.MdiParent = this;

        }



        private void frmMaincs_Load(object sender, EventArgs e)

        {

            // Có thể load giao diện mặc định tại đây

        }



        #region === Mở form con ===

        private void OpenForm<T>() where T : Form, new()

        {

            // Kiểm tra form đã mở chưa

            var form = MdiChildren.FirstOrDefault(f => f is T);

            if (form == null)

            {

                form = new T();

                form.MdiParent = this;

                form.WindowState = FormWindowState.Maximized;

                form.Show();

            }

            else

            {

                form.Activate();

            }

        }

        #endregion



        #region === Xử lý click menu ===



        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)

        {

            // Khách hàng

            OpenForm<frmQLKhachHang>();

        }



        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)

        {

            // Đăng ký phòng

            OpenForm<frmDangKyPhong>();

        }



        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)

        {

            // Tìm kiếm khách hàng

            //OpenForm<frmTimKiemKhachHang>();

        }



        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)

        {

            // Danh sách phòng

            OpenForm<frmDanhSachPhong>();

        }



        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)

        {

            // Gói dịch vụ

            //OpenForm<frmGoiDichVu>();

        }



        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)

        {

            // Thanh toán

            //OpenForm<frmThanhToan>();

        }



        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)

        {

            // Nhân viên

            OpenForm<frmNhanVien>();

        }



        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)

        {

            // Quản lý phòng

            OpenForm<frmDanhSachPhong>();

        }



        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)

        {

            OpenForm<frmQuanLyDichVu>();

        }



        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)

        {

            // Phân quyền

            //OpenForm<frmPhanQuyen>();

        }



        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)

        {

            // Thanh toán nhanh

            //OpenForm<frmThanhToan>();

        }



        #endregion



        private void ribbonStatusBar_Click(object sender, EventArgs e)

        {

            // Tuỳ ý thêm sự kiện

        }



        private void ribbon_Click(object sender, EventArgs e)

        {

            // Tuỳ ý thêm sự kiện

        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)

        {

            MessageBox.Show("Chức năng Đổi mật khẩu chưa được cài đặt.", "Thông báo");

        }



        private void btnBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)

        {

            try

            {

                SaveFileDialog saveFileDialog = new SaveFileDialog

                {

                    Filter = "Backup files (*.bak)|*.bak",

                    Title = "Chọn nơi lưu file sao lưu",

                    FileName = "QuanLyKhachSan_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".bak"

                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)

                {

                    string backupPath = saveFileDialog.FileName;

                    using (SqlConnection conn = new SqlConnection(connectionString))

                    {

                        conn.Open();

                        string sql = $"BACKUP DATABASE QuanLyKhachSan TO DISK = '{backupPath}'";

                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Sao lưu dữ liệu thành công!", "Thành công");

                    }

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Lỗi sao lưu: " + ex.Message, "Lỗi");

            }

        }



        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)

        {

            try

            {

                OpenFileDialog openFileDialog = new OpenFileDialog

                {

                    Filter = "Backup files (*.bak)|*.bak",

                    Title = "Chọn file sao lưu để phục hồi"

                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)

                {

                    string backupPath = openFileDialog.FileName;

                    using (SqlConnection conn = new SqlConnection("Data Source=admin;Initial Catalog=master;Integrated Security=True"))

                    {

                        conn.Open();

                        string sql = @"

                    ALTER DATABASE QuanLyKhachSan SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

                    RESTORE DATABASE QuanLyKhachSan FROM DISK = @path WITH REPLACE;

                    ALTER DATABASE QuanLyKhachSan SET MULTI_USER;";

                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@path", backupPath);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Phục hồi dữ liệu thành công!", "Thành công");

                    }

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Lỗi phục hồi dữ liệu: " + ex.Message, "Lỗi");

            }

        }



        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)

        {

            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                this.Hide();

                frmLogin f = new frmLogin();

                f.ShowDialog();

                this.Close();

            }

        }



        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)

        {
            OpenForm<frmDangKyPhong>();


        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnBaoCaoDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT FORMAT(NgayThanhToan, 'yyyy-MM') AS Thang,
                                            SUM(TongTien) AS DoanhThu
                                     FROM HoaDon
                                     GROUP BY FORMAT(NgayThanhToan, 'yyyy-MM')
                                     ORDER BY Thang DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    XtraForm frm = new XtraForm();
                    frm.Text = "Báo cáo doanh thu";
                    DevExpress.XtraGrid.GridControl grid = new DevExpress.XtraGrid.GridControl { Dock = DockStyle.Fill };
                    DevExpress.XtraGrid.Views.Grid.GridView view = new DevExpress.XtraGrid.Views.Grid.GridView();
                    grid.MainView = view;
                    grid.DataSource = dt;
                    frm.Controls.Add(grid);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải báo cáo doanh thu: " + ex.Message);
            }
        }

        // === Báo cáo phòng ===
        private void btnBaoCaoPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT TenPhong,
                                            CASE WHEN TrangThai = 1 THEN N'Đang thuê' ELSE N'Trống' END AS TrangThai,
                                            GiaPhong
                                     FROM Phong";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    XtraForm frm = new XtraForm();
                    frm.Text = "Báo cáo phòng";
                    DevExpress.XtraGrid.GridControl grid = new DevExpress.XtraGrid.GridControl { Dock = DockStyle.Fill };
                    DevExpress.XtraGrid.Views.Grid.GridView view = new DevExpress.XtraGrid.Views.Grid.GridView();
                    grid.MainView = view;
                    grid.DataSource = dt;
                    frm.Controls.Add(grid);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải báo cáo phòng: " + ex.Message);
            }
        }

        // === Báo cáo dịch vụ ===
        private void btnBaoCaoDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT TenDichVu, Gia, COUNT(*) AS SoLanSuDung
                                     FROM ChiTietSuDungDichVu
                                     JOIN DichVu ON ChiTietSuDungDichVu.MaDichVu = DichVu.MaDichVu
                                     GROUP BY TenDichVu, Gia
                                     ORDER BY SoLanSuDung DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    XtraForm frm = new XtraForm();
                    frm.Text = "Báo cáo dịch vụ";
                    DevExpress.XtraGrid.GridControl grid = new DevExpress.XtraGrid.GridControl { Dock = DockStyle.Fill };
                    DevExpress.XtraGrid.Views.Grid.GridView view = new DevExpress.XtraGrid.Views.Grid.GridView();
                    grid.MainView = view;
                    grid.DataSource = dt;
                    frm.Controls.Add(grid);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải báo cáo dịch vụ: " + ex.Message);
            }
        }
        private void btnXemBaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // 1. Tạo một instance của report bạn đã thiết kế
                report baoCao = new report();

                // 2. (Tùy chọn) Truyền tham số vào report nếu cần
                // Ví dụ: Nếu report của bạn cần ngày bắt đầu, ngày kết thúc
                // baoCao.Parameters["TuNgay"].Value = DateTime.Now.AddMonths(-1); 
                // baoCao.Parameters["DenNgay"].Value = DateTime.Now;
                // baoCao.Parameters["TuNgay"].Visible = false; // Ẩn tham số nếu không muốn user nhập lại
                // baoCao.Parameters["DenNgay"].Visible = false;

                // 3. Tạo ReportPrintTool để xử lý report
                ReportPrintTool printTool = new ReportPrintTool(baoCao);

                // 4. Hiển thị cửa sổ xem trước (Preview)
                printTool.ShowPreviewDialog();
                // Hoặc nếu muốn hiển thị trong tab MDI (nhưng thường report sẽ xem ở cửa sổ riêng):
                // printTool.ShowRibbonPreview(this.LookAndFeel); // Cần using DevExpress.LookAndFeel
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G_ItemClick(object sender, ItemClickEventArgs e)
        {
           OpenForm<frmQuanLyDichVu>();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<frmDanhSachPhong>();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnThanhToan_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<frmThanhToan>();
        }
    }

}