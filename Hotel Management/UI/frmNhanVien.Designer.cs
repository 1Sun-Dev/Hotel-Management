namespace Hotel_Management
{
    partial class frmNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupThongTin = new DevExpress.XtraEditors.GroupControl();
            this.panelButton = new DevExpress.XtraEditors.PanelControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtChucVu = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.dtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.lblLuong = new DevExpress.XtraEditors.LabelControl();
            this.lblChucVu = new DevExpress.XtraEditors.LabelControl();
            this.lblSDT = new DevExpress.XtraEditors.LabelControl();
            this.lblNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.lblGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lblMaNV = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelButton)).BeginInit();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.panelButton);
            this.groupThongTin.Controls.Add(this.txtLuong);
            this.groupThongTin.Controls.Add(this.txtChucVu);
            this.groupThongTin.Controls.Add(this.txtSDT);
            this.groupThongTin.Controls.Add(this.dtNgaySinh);
            this.groupThongTin.Controls.Add(this.rbNu);
            this.groupThongTin.Controls.Add(this.rbNam);
            this.groupThongTin.Controls.Add(this.txtHoTen);
            this.groupThongTin.Controls.Add(this.txtMaNV);
            this.groupThongTin.Controls.Add(this.lblLuong);
            this.groupThongTin.Controls.Add(this.lblChucVu);
            this.groupThongTin.Controls.Add(this.lblSDT);
            this.groupThongTin.Controls.Add(this.lblNgaySinh);
            this.groupThongTin.Controls.Add(this.lblGioiTinh);
            this.groupThongTin.Controls.Add(this.lblHoTen);
            this.groupThongTin.Controls.Add(this.lblMaNV);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupThongTin.Location = new System.Drawing.Point(0, 0);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(360, 520);
            this.groupThongTin.TabIndex = 0;
            this.groupThongTin.Text = "Thông tin nhân viên";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnLamMoi);
            this.panelButton.Controls.Add(this.btnXoa);
            this.panelButton.Controls.Add(this.btnSua);
            this.panelButton.Controls.Add(this.btnThem);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(2, 448);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(356, 70);
            this.panelButton.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(265, 22);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 30);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(180, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(95, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(105, 330);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(220, 22);
            this.txtLuong.TabIndex = 13;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(105, 290);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(220, 22);
            this.txtChucVu.TabIndex = 12;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(105, 250);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(220, 22);
            this.txtSDT.TabIndex = 11;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.EditValue = null;
            this.dtNgaySinh.Location = new System.Drawing.Point(105, 210);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtNgaySinh.Size = new System.Drawing.Size(220, 22);
            this.dtNgaySinh.TabIndex = 10;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(180, 175);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(47, 21);
            this.rbNu.TabIndex = 9;
            this.rbNu.Text = "Nữ";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Location = new System.Drawing.Point(105, 175);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(58, 21);
            this.rbNam.TabIndex = 8;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(105, 130);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 22);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(105, 90);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(220, 22);
            this.txtMaNV.TabIndex = 6;
            // 
            // Labels
            // 
            this.lblMaNV.Location = new System.Drawing.Point(25, 93);
            this.lblMaNV.Text = "Mã NV:";
            this.lblHoTen.Location = new System.Drawing.Point(25, 133);
            this.lblHoTen.Text = "Họ tên:";
            this.lblGioiTinh.Location = new System.Drawing.Point(25, 175);
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblNgaySinh.Location = new System.Drawing.Point(25, 213);
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblSDT.Location = new System.Drawing.Point(25, 253);
            this.lblSDT.Text = "SĐT:";
            this.lblChucVu.Location = new System.Drawing.Point(25, 293);
            this.lblChucVu.Text = "Chức vụ:";
            this.lblLuong.Location = new System.Drawing.Point(25, 333);
            this.lblLuong.Text = "Lương:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(360, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Size = new System.Drawing.Size(640, 520);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // frmNhanVien
            // 
            this.ClientSize = new System.Drawing.Size(1000, 520);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupThongTin);
            this.Name = "frmNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelButton)).EndInit();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupThongTin;
        private DevExpress.XtraEditors.PanelControl panelButton;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private DevExpress.XtraEditors.DateEdit dtNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtChucVu;
        private DevExpress.XtraEditors.TextEdit txtLuong;
        private DevExpress.XtraEditors.LabelControl lblMaNV;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.LabelControl lblGioiTinh;
        private DevExpress.XtraEditors.LabelControl lblNgaySinh;
        private DevExpress.XtraEditors.LabelControl lblSDT;
        private DevExpress.XtraEditors.LabelControl lblChucVu;
        private DevExpress.XtraEditors.LabelControl lblLuong;
    }
}