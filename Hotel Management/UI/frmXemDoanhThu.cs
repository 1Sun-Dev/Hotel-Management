using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraCharts; // Cần using này
using DevExpress.XtraEditors;

namespace Hotel_Management
{
    public partial class frmXemDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        // Chuỗi kết nối (Lấy giống form Main)
        private string connectionString =
            @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";

        public frmXemDoanhThu()
        {
            InitializeComponent();
        }

        private void frmXemDoanhThu_Load(object sender, EventArgs e)
        {
            // Thiết lập ngày mặc định (ví dụ: tháng hiện tại)
            DateTime today = DateTime.Today;
            dateTuNgay.EditValue = new DateTime(today.Year, today.Month, 1);
            dateDenNgay.EditValue = ((DateTime)dateTuNgay.EditValue).AddMonths(1).AddDays(-1);

            // Tải dữ liệu lần đầu
            LoadDoanhThu();
        }

        // Sự kiện click nút "Xem Báo Cáo"
        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }

        // Hàm chính để tải và vẽ biểu đồ doanh thu
        private void LoadDoanhThu()
        {
            // Lấy ngày bắt đầu và kết thúc từ DateEdit
            DateTime tuNgay = dateTuNgay.DateTime;
            // Cộng thêm gần hết ngày để bao gồm cả ngày kết thúc
            DateTime denNgay = dateDenNgay.DateTime.Date.AddDays(1).AddTicks(-1);

            if (tuNgay > denNgay)
            {
                XtraMessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Câu SQL: Tính tổng doanh thu theo từng ngày trong khoảng đã chọn
                    // Giả định ngày thanh toán là NgayRa trong bảng HoaDon
                    string query = @"
                        SELECT 
                            CAST(NgayRa AS DATE) AS Ngay, -- Lấy phần ngày
                            SUM(TongTien) AS DoanhThuNgay
                        FROM HoaDon
                        WHERE NgayRa >= @TuNgay AND NgayRa <= @DenNgay AND TongTien IS NOT NULL
                        GROUP BY CAST(NgayRa AS DATE)
                        ORDER BY Ngay; ";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@TuNgay", tuNgay);
                    da.SelectCommand.Parameters.AddWithValue("@DenNgay", denNgay);
                    da.Fill(dt);
                }

                // Cấu hình ChartControl
                chartControlDoanhThu.Series.Clear(); // Xóa series cũ

                if (dt.Rows.Count > 0)
                {
                    Series series1 = new Series("Doanh thu theo ngày", ViewType.Bar); // Dạng cột
                    series1.DataSource = dt;

                    // Chỉ định cột Argument (Trục X - Ngày) và Value (Trục Y - Doanh thu)
                    series1.ArgumentDataMember = "Ngay";
                    series1.ArgumentScaleType = ScaleType.DateTime; // Quan trọng: Trục X là kiểu ngày tháng
                    series1.ValueDataMembers.AddRange(new string[] { "DoanhThuNgay" });
                    series1.ValueScaleType = ScaleType.Numerical; // Trục Y là kiểu số

                    chartControlDoanhThu.Series.Add(series1);

                    // --- Tùy chỉnh biểu đồ ---
                    XYDiagram diagram = chartControlDoanhThu.Diagram as XYDiagram;
                    if (diagram != null)
                    {
                        // Trục X (Ngày)
                        diagram.AxisX.Title.Text = "Ngày";
                        diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                        diagram.AxisX.Label.TextPattern = "{A:dd/MM/yy}"; // Định dạng hiển thị ngày
                        diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day; // Đơn vị đo là ngày
                        diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Day; // Căn lưới theo ngày
                        diagram.AxisX.Label.Angle = -45; // Nghiêng nhãn cho dễ đọc nếu nhiều ngày

                        // Trục Y (Doanh thu)
                        diagram.AxisY.Title.Text = "Doanh thu (VNĐ)";
                        diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                        diagram.AxisY.Label.TextPattern = "{V:N0}"; // Định dạng số
                    }

                    // Tiêu đề
                    ChartTitle chartTitle = new ChartTitle();
                    chartTitle.Text = $"Biểu đồ Doanh thu từ {tuNgay:dd/MM/yyyy} đến {denNgay:dd/MM/yyyy}";
                    chartControlDoanhThu.Titles.Clear();
                    chartControlDoanhThu.Titles.Add(chartTitle);

                    // Tooltip (hiển thị khi di chuột qua cột)
                    series1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
                    series1.ToolTipPointPattern = "{A:dd/MM/yyyy}: {V:N0} VNĐ";

                    // Hiển thị giá trị trên cột (tùy chọn)
                    // series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                    // series1.Label.TextPattern = "{V:N0}";
                }
                else
                {
                    XtraMessageBox.Show("Không có dữ liệu doanh thu trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải dữ liệu doanh thu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}