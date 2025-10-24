namespace Hotel_Management.Report
{
    partial class report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblReportTitle = new DevExpress.XtraReports.UI.XRLabel(); // Đổi tên thành lblReportTitle
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.detailTable = new DevExpress.XtraReports.UI.XRTable(); // Bảng chi tiết
            this.detailTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.detailTableCell_MaBC = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell_TenBC = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell_SoKhach = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell_TongPhong = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell_DoanhThu = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell_MaNV = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.TitleStyle = new DevExpress.XtraReports.UI.XRControlStyle(); // Đổi tên style
            this.PageInfoStyle = new DevExpress.XtraReports.UI.XRControlStyle(); // Đổi tên style
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand(); // Thêm PageHeader
            this.headerTable = new DevExpress.XtraReports.UI.XRTable(); // Bảng header
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.headerTableCell_MaBC = new DevExpress.XtraReports.UI.XRTableCell();
            this.headerTableCell_TenBC = new DevExpress.XtraReports.UI.XRTableCell();
            this.headerTableCell_SoKhach = new DevExpress.XtraReports.UI.XRTableCell();
            this.headerTableCell_TongPhong = new DevExpress.XtraReports.UI.XRTableCell();
            this.headerTableCell_DoanhThu = new DevExpress.XtraReports.UI.XRTableCell();
            this.headerTableCell_MaNV = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand(); // Thêm ReportFooter
            this.totalTable = new DevExpress.XtraReports.UI.XRTable(); // Bảng tổng cộng
            this.totalTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.totalCaptionTableCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalDoanhThuTableCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrControlStyle_TableHeader = new DevExpress.XtraReports.UI.XRControlStyle(); // Style cho header
            this.xrControlStyle_DetailData = new DevExpress.XtraReports.UI.XRControlStyle(); // Style cho detail
            this.xrControlStyle_TotalData = new DevExpress.XtraReports.UI.XRControlStyle(); // Style cho total
            this.xrControlStyle_EvenRow = new DevExpress.XtraReports.UI.XRControlStyle(); // Style cho dòng chẵn
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F; // Tăng khoảng cách lề trên
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.HeightF = 50F; // Tăng khoảng cách lề dưới
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 6F); // Căn chỉnh vị trí
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F); // Điều chỉnh kích thước
            this.pageInfo1.StyleName = "PageInfoStyle";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(331F, 6F); // Căn chỉnh vị trí
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(313F, 23F); // Điều chỉnh kích thước
            this.pageInfo2.StyleName = "PageInfoStyle";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblReportTitle});
            this.ReportHeader.HeightF = 60F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Font = new DevExpress.Drawing.DXFont("Arial", 18F, DevExpress.Drawing.DXFontStyle.Bold); // Font lớn hơn
            this.lblReportTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F); // Căn chỉnh
            this.lblReportTitle.Multiline = true;
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.SizeF = new System.Drawing.SizeF(650F, 39.99999F); // Tăng chiều cao
            this.lblReportTitle.StyleName = "TitleStyle";
            this.lblReportTitle.StylePriority.UseFont = false;
            this.lblReportTitle.StylePriority.UseTextAlignment = false;
            this.lblReportTitle.Text = "BÁO CÁO TỔNG HỢP"; // Tiêu đề rõ ràng hơn
            this.lblReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter; // Căn giữa
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.detailTable});
            this.Detail.HeightF = 25F;
            this.Detail.KeepTogether = true; // Giữ dòng detail trên cùng 1 trang
            this.Detail.Name = "Detail";
            // 
            // detailTable
            // 
            this.detailTable.EvenStyleName = "xrControlStyle_EvenRow"; // Áp dụng style dòng chẵn
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.detailTable.Name = "detailTable";
            this.detailTable.OddStyleName = "xrControlStyle_DetailData"; // Áp dụng style dòng lẻ
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow});
            this.detailTable.SizeF = new System.Drawing.SizeF(650F, 25F);
            // 
            // detailTableRow
            // 
            this.detailTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.detailTableCell_MaBC,
            this.detailTableCell_TenBC,
            this.detailTableCell_SoKhach,
            this.detailTableCell_TongPhong,
            this.detailTableCell_DoanhThu,
            this.detailTableCell_MaNV});
            this.detailTableRow.Name = "detailTableRow";
            this.detailTableRow.Weight = 11.5D;
            // 
            // detailTableCell_MaBC
            // 
            this.detailTableCell_MaBC.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MaBC]")});
            this.detailTableCell_MaBC.Name = "detailTableCell_MaBC";
            this.detailTableCell_MaBC.StylePriority.UseTextAlignment = false;
            this.detailTableCell_MaBC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.detailTableCell_MaBC.Weight = 0.11677326466355979D;
            // 
            // detailTableCell_TenBC
            // 
            this.detailTableCell_TenBC.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TenBC]")});
            this.detailTableCell_TenBC.Name = "detailTableCell_TenBC";
            this.detailTableCell_TenBC.StylePriority.UseTextAlignment = false;
            this.detailTableCell_TenBC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.detailTableCell_TenBC.Weight = 0.23789370891823908D;
            // 
            // detailTableCell_SoKhach
            // 
            this.detailTableCell_SoKhach.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SoLuongKhach]")});
            this.detailTableCell_SoKhach.Name = "detailTableCell_SoKhach";
            this.detailTableCell_SoKhach.StylePriority.UseTextAlignment = false;
            this.detailTableCell_SoKhach.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.detailTableCell_SoKhach.Weight = 0.14777647265818987D;
            // 
            // detailTableCell_TongPhong
            // 
            this.detailTableCell_TongPhong.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TongPhong]")});
            this.detailTableCell_TongPhong.Name = "detailTableCell_TongPhong";
            this.detailTableCell_TongPhong.StylePriority.UseTextAlignment = false;
            this.detailTableCell_TongPhong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.detailTableCell_TongPhong.Weight = 0.15535970267499839D;
            // 
            // detailTableCell_DoanhThu
            // 
            this.detailTableCell_DoanhThu.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DoanhThu]")});
            this.detailTableCell_DoanhThu.Name = "detailTableCell_DoanhThu";
            this.detailTableCell_DoanhThu.StylePriority.UseTextAlignment = false;
            this.detailTableCell_DoanhThu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.detailTableCell_DoanhThu.TextFormatString = "{0:N0}"; // Định dạng số
            this.detailTableCell_DoanhThu.Weight = 0.19832269521859976D;
            // 
            // detailTableCell_MaNV
            // 
            this.detailTableCell_MaNV.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MaNV]")});
            this.detailTableCell_MaNV.Name = "detailTableCell_MaNV";
            this.detailTableCell_MaNV.StylePriority.UseTextAlignment = false;
            this.detailTableCell_MaNV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.detailTableCell_MaNV.Weight = 0.14387413690184285D;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "admin.QuanLyKhachSan.dbo"; // Giữ nguyên connection
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "MaBC";
            table1.Name = "BaoCao"; // Chỉ cần query bảng BaoCao cho report này
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "TenBC";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "SoLuongKhach";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "TongPhong";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "DoanhThu";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "MaNV";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Name = "BaoCao"; // Đặt tên query là BaoCao
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1}); // Chỉ cần 1 query
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable"); // Giữ schema nếu cần
            // 
            // TitleStyle
            // 
            this.TitleStyle.BackColor = System.Drawing.Color.Transparent;
            this.TitleStyle.BorderColor = System.Drawing.Color.Black;
            this.TitleStyle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TitleStyle.BorderWidth = 1F;
            this.TitleStyle.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
            this.TitleStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.TitleStyle.Name = "TitleStyle"; // Đổi tên style
            this.TitleStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // PageInfoStyle
            // 
            this.PageInfoStyle.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfoStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfoStyle.Name = "PageInfoStyle"; // Đổi tên style
            this.PageInfoStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.headerTable});
            this.PageHeader.HeightF = 28F; // Chiều cao của header cột
            this.PageHeader.Name = "PageHeader";
            // 
            // headerTable
            // 
            this.headerTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.headerTable.Name = "headerTable";
            this.headerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.headerTableRow});
            this.headerTable.SizeF = new System.Drawing.SizeF(650F, 28F);
            this.headerTable.StyleName = "xrControlStyle_TableHeader"; // Áp dụng style header
            // 
            // headerTableRow
            // 
            this.headerTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.headerTableCell_MaBC,
            this.headerTableCell_TenBC,
            this.headerTableCell_SoKhach,
            this.headerTableCell_TongPhong,
            this.headerTableCell_DoanhThu,
            this.headerTableCell_MaNV});
            this.headerTableRow.Name = "headerTableRow";
            this.headerTableRow.Weight = 1D;
            // 
            // headerTableCell_MaBC
            // 
            this.headerTableCell_MaBC.Name = "headerTableCell_MaBC";
            this.headerTableCell_MaBC.Text = "Mã BC";
            this.headerTableCell_MaBC.Weight = 0.11677326466355979D;
            // 
            // headerTableCell_TenBC
            // 
            this.headerTableCell_TenBC.Name = "headerTableCell_TenBC";
            this.headerTableCell_TenBC.Text = "Tên Báo Cáo";
            this.headerTableCell_TenBC.Weight = 0.23789370891823908D;
            // 
            // headerTableCell_SoKhach
            // 
            this.headerTableCell_SoKhach.Name = "headerTableCell_SoKhach";
            this.headerTableCell_SoKhach.StylePriority.UseTextAlignment = false;
            this.headerTableCell_SoKhach.Text = "Số Khách";
            this.headerTableCell_SoKhach.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.headerTableCell_SoKhach.Weight = 0.14777647265818987D;
            // 
            // headerTableCell_TongPhong
            // 
            this.headerTableCell_TongPhong.Name = "headerTableCell_TongPhong";
            this.headerTableCell_TongPhong.StylePriority.UseTextAlignment = false;
            this.headerTableCell_TongPhong.Text = "Tổng Phòng";
            this.headerTableCell_TongPhong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.headerTableCell_TongPhong.Weight = 0.15535970267499839D;
            // 
            // headerTableCell_DoanhThu
            // 
            this.headerTableCell_DoanhThu.Name = "headerTableCell_DoanhThu";
            this.headerTableCell_DoanhThu.StylePriority.UseTextAlignment = false;
            this.headerTableCell_DoanhThu.Text = "Doanh Thu";
            this.headerTableCell_DoanhThu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.headerTableCell_DoanhThu.Weight = 0.19832269521859976D;
            // 
            // headerTableCell_MaNV
            // 
            this.headerTableCell_MaNV.Name = "headerTableCell_MaNV";
            this.headerTableCell_MaNV.Text = "Nhân Viên";
            this.headerTableCell_MaNV.Weight = 0.14387413690184285D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.totalTable});
            this.ReportFooter.HeightF = 50F; // Tăng chiều cao footer
            this.ReportFooter.Name = "ReportFooter";
            // 
            // totalTable
            // 
            this.totalTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F); // Căn chỉnh vị trí
            this.totalTable.Name = "totalTable";
            this.totalTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.totalTableRow});
            this.totalTable.SizeF = new System.Drawing.SizeF(650F, 25F);
            this.totalTable.StyleName = "xrControlStyle_TotalData"; // Áp dụng style total
            // 
            // totalTableRow
            // 
            this.totalTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.totalCaptionTableCell,
            this.totalDoanhThuTableCell});
            this.totalTableRow.Name = "totalTableRow";
            this.totalTableRow.Weight = 1D;
            // 
            // totalCaptionTableCell
            // 
            this.totalCaptionTableCell.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.totalCaptionTableCell.Name = "totalCaptionTableCell";
            this.totalCaptionTableCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 20, 0, 0, 100F); // Tăng padding phải
            this.totalCaptionTableCell.StylePriority.UseFont = false;
            this.totalCaptionTableCell.StylePriority.UsePadding = false;
            this.totalCaptionTableCell.StylePriority.UseTextAlignment = false;
            this.totalCaptionTableCell.Text = "Tổng Doanh Thu:";
            this.totalCaptionTableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.totalCaptionTableCell.Weight = 0.85612586309815711D; // Chiếm nhiều cột hơn
            // 
            // totalDoanhThuTableCell
            // 
            this.totalDoanhThuTableCell.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DoanhThu])")}); // Tính tổng DoanhThu
            this.totalDoanhThuTableCell.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.totalDoanhThuTableCell.Name = "totalDoanhThuTableCell";
            this.totalDoanhThuTableCell.StylePriority.UseFont = false;
            this.totalDoanhThuTableCell.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report; // Tính tổng cho cả report
            this.totalDoanhThuTableCell.Summary = xrSummary1;
            this.totalDoanhThuTableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.totalDoanhThuTableCell.TextFormatString = "{0:N0}"; // Định dạng số
            this.totalDoanhThuTableCell.Weight = 0.14387413690184285D; // Giữ nguyên weight của cột MaNV
            // 
            // xrControlStyle_TableHeader
            // 
            this.xrControlStyle_TableHeader.BackColor = System.Drawing.Color.Gainsboro; // Màu nền header
            this.xrControlStyle_TableHeader.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrControlStyle_TableHeader.ForeColor = System.Drawing.Color.Black;
            this.xrControlStyle_TableHeader.Name = "xrControlStyle_TableHeader";
            this.xrControlStyle_TableHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrControlStyle_TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrControlStyle_DetailData
            // 
            this.xrControlStyle_DetailData.BorderColor = System.Drawing.Color.Transparent;
            this.xrControlStyle_DetailData.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrControlStyle_DetailData.BorderWidth = 1F;
            this.xrControlStyle_DetailData.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.xrControlStyle_DetailData.ForeColor = System.Drawing.Color.Black;
            this.xrControlStyle_DetailData.Name = "xrControlStyle_DetailData";
            this.xrControlStyle_DetailData.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrControlStyle_DetailData.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrControlStyle_TotalData
            // 
            this.xrControlStyle_TotalData.BackColor = System.Drawing.Color.WhiteSmoke; // Nền cho dòng tổng
            this.xrControlStyle_TotalData.BorderColor = System.Drawing.Color.Gray;
            this.xrControlStyle_TotalData.Borders = DevExpress.XtraPrinting.BorderSide.Top; // Chỉ kẻ viền trên
            this.xrControlStyle_TotalData.BorderWidth = 1F;
            this.xrControlStyle_TotalData.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrControlStyle_TotalData.ForeColor = System.Drawing.Color.Black;
            this.xrControlStyle_TotalData.Name = "xrControlStyle_TotalData";
            this.xrControlStyle_TotalData.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 2, 2, 100F); // Thêm padding trên dưới
            this.xrControlStyle_TotalData.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrControlStyle_EvenRow
            // 
            this.xrControlStyle_EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240))))); // Màu nền dòng chẵn
            this.xrControlStyle_EvenRow.Name = "xrControlStyle_EvenRow";
            this.xrControlStyle_EvenRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
          
            // 
            // report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader, // Thêm PageHeader
            this.Detail,
            this.ReportFooter}); // Thêm ReportFooter
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "BaoCao"; // Bind vào query BaoCao
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 50F, 50F); // Điều chỉnh lề
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.TitleStyle,
            this.PageInfoStyle,
            this.xrControlStyle_TableHeader, // Thêm các style mới
            this.xrControlStyle_DetailData,
            this.xrControlStyle_TotalData,
            this.xrControlStyle_EvenRow});
            this.Version = "23.2"; // Cập nhật phiên bản DevExpress bạn dùng (nếu cần)
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lblReportTitle; // Đổi tên
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle TitleStyle; // Đổi tên
        private DevExpress.XtraReports.UI.XRControlStyle PageInfoStyle; // Đổi tên
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader; // Thêm
        private DevExpress.XtraReports.UI.XRTable headerTable; // Thêm
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell headerTableCell_MaBC; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell headerTableCell_TenBC; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell headerTableCell_SoKhach; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell headerTableCell_TongPhong; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell headerTableCell_DoanhThu; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell headerTableCell_MaNV; // Thêm
        private DevExpress.XtraReports.UI.XRTable detailTable; // Thêm
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell_MaBC; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell_TenBC; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell_SoKhach; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell_TongPhong; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell_DoanhThu; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell_MaNV; // Thêm
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter; // Thêm
        private DevExpress.XtraReports.UI.XRTable totalTable; // Thêm
        private DevExpress.XtraReports.UI.XRTableRow totalTableRow; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell totalCaptionTableCell; // Thêm
        private DevExpress.XtraReports.UI.XRTableCell totalDoanhThuTableCell; // Thêm
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle_TableHeader; // Thêm
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle_DetailData; // Thêm
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle_TotalData; // Thêm
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle_EvenRow; // Thêm
    }
}