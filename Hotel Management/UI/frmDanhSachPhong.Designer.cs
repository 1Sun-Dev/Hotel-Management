namespace Hotel_Management
{
    partial class frmDanhSachPhong
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridPhong = new DevExpress.XtraGrid.GridControl();
            this.gridViewPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpLoaiPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSoPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPhong = new DevExpress.XtraEditors.TextEdit();
            this.cmbTinhTrang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupThongTin = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem_MaPhong = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem_LoaiPhong = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem_SoPhong = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem_NhanVien = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem_TinhTrang = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem_Grid = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem_BtnThem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem_BtnSua = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem_BtnXoa = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpLoaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_MaPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_LoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_SoPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_TinhTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_BtnThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_BtnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_BtnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridPhong);
            this.layoutControl1.Controls.Add(this.btnXoa);
            this.layoutControl1.Controls.Add(this.btnSua);
            this.layoutControl1.Controls.Add(this.btnThem);
            this.layoutControl1.Controls.Add(this.lookUpNhanVien);
            this.layoutControl1.Controls.Add(this.lookUpLoaiPhong);
            this.layoutControl1.Controls.Add(this.txtSoPhong);
            this.layoutControl1.Controls.Add(this.txtMaPhong);
            this.layoutControl1.Controls.Add(this.cmbTinhTrang);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1000, 600);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridPhong
            // 
            this.gridPhong.Location = new System.Drawing.Point(12, 169);
            this.gridPhong.MainView = this.gridViewPhong;
            this.gridPhong.Name = "gridPhong";
            this.gridPhong.Size = new System.Drawing.Size(976, 419);
            this.gridPhong.TabIndex = 8;
            this.gridPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhong});
            // 
            // gridViewPhong
            // 
            this.gridViewPhong.GridControl = this.gridPhong;
            this.gridViewPhong.Name = "gridViewPhong";
            this.gridViewPhong.OptionsBehavior.Editable = false;
            this.gridViewPhong.OptionsFind.AlwaysVisible = true;
            this.gridViewPhong.OptionsView.ShowGroupPanel = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(344, 129);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 26);
            this.btnXoa.StyleController = this.layoutControl1;
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(178, 129);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(162, 26);
            this.btnSua.StyleController = this.layoutControl1;
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 129);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(162, 26);
            this.btnThem.StyleController = this.layoutControl1;
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            // 
            // lookUpNhanVien
            // 
            this.lookUpNhanVien.Location = new System.Drawing.Point(592, 69);
            this.lookUpNhanVien.Name = "lookUpNhanVien";
            this.lookUpNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpNhanVien.Properties.NullText = "[Chọn nhân viên]";
            this.lookUpNhanVien.Size = new System.Drawing.Size(384, 20);
            this.lookUpNhanVien.StyleController = this.layoutControl1;
            this.lookUpNhanVien.TabIndex = 3;
            // 
            // lookUpLoaiPhong
            // 
            this.lookUpLoaiPhong.Location = new System.Drawing.Point(592, 45);
            this.lookUpLoaiPhong.Name = "lookUpLoaiPhong";
            this.lookUpLoaiPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpLoaiPhong.Properties.NullText = "[Chọn loại phòng]";
            this.lookUpLoaiPhong.Size = new System.Drawing.Size(384, 20);
            this.lookUpLoaiPhong.StyleController = this.layoutControl1;
            this.lookUpLoaiPhong.TabIndex = 2;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(114, 69);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(384, 20);
            this.txtSoPhong.StyleController = this.layoutControl1;
            this.txtSoPhong.TabIndex = 1;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(114, 45);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(384, 20);
            this.txtMaPhong.StyleController = this.layoutControl1;
            this.txtMaPhong.TabIndex = 0;
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.Location = new System.Drawing.Point(114, 93);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTinhTrang.Properties.Items.AddRange(new object[] {
            "Trống",
            "Đang thuê",
            "Đang dọn"});
            this.cmbTinhTrang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTinhTrang.Size = new System.Drawing.Size(384, 20);
            this.cmbTinhTrang.StyleController = this.layoutControl1;
            this.cmbTinhTrang.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupThongTin,
            this.layoutControlItem_Grid,
            this.splitterItem1,
            this.layoutControlItem_BtnThem,
            this.layoutControlItem_BtnSua,
            this.layoutControlItem_BtnXoa,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1000, 600);
            this.Root.TextVisible = false;
            // 
            // groupThongTin
            // 
            this.groupThongTin.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem_MaPhong,
            this.layoutControlItem_LoaiPhong,
            this.layoutControlItem_SoPhong,
            this.layoutControlItem_NhanVien,
            this.layoutControlItem_TinhTrang,
            this.emptySpaceItem2});
            this.groupThongTin.Location = new System.Drawing.Point(0, 0);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(980, 117);
            this.groupThongTin.Text = "Thông tin phòng";
            // 
            // layoutControlItem_MaPhong
            // 
            this.layoutControlItem_MaPhong.Control = this.txtMaPhong;
            this.layoutControlItem_MaPhong.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem_MaPhong.Name = "layoutControlItem_MaPhong";
            this.layoutControlItem_MaPhong.Size = new System.Drawing.Size(478, 24);
            this.layoutControlItem_MaPhong.Text = "Mã phòng:";
            this.layoutControlItem_MaPhong.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem_LoaiPhong
            // 
            this.layoutControlItem_LoaiPhong.Control = this.lookUpLoaiPhong;
            this.layoutControlItem_LoaiPhong.Location = new System.Drawing.Point(478, 0);
            this.layoutControlItem_LoaiPhong.Name = "layoutControlItem_LoaiPhong";
            this.layoutControlItem_LoaiPhong.Size = new System.Drawing.Size(478, 24);
            this.layoutControlItem_LoaiPhong.Text = "Loại phòng:";
            this.layoutControlItem_LoaiPhong.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem_SoPhong
            // 
            this.layoutControlItem_SoPhong.Control = this.txtSoPhong;
            this.layoutControlItem_SoPhong.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem_SoPhong.Name = "layoutControlItem_SoPhong";
            this.layoutControlItem_SoPhong.Size = new System.Drawing.Size(478, 24);
            this.layoutControlItem_SoPhong.Text = "Số phòng (Tên):";
            this.layoutControlItem_SoPhong.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem_NhanVien
            // 
            this.layoutControlItem_NhanVien.Control = this.lookUpNhanVien;
            this.layoutControlItem_NhanVien.Location = new System.Drawing.Point(478, 24);
            this.layoutControlItem_NhanVien.Name = "layoutControlItem_NhanVien";
            this.layoutControlItem_NhanVien.Size = new System.Drawing.Size(478, 24);
            this.layoutControlItem_NhanVien.Text = "Nhân viên QL:";
            this.layoutControlItem_NhanVien.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem_TinhTrang
            // 
            this.layoutControlItem_TinhTrang.Control = this.cmbTinhTrang;
            this.layoutControlItem_TinhTrang.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem_TinhTrang.Name = "layoutControlItem_TinhTrang";
            this.layoutControlItem_TinhTrang.Size = new System.Drawing.Size(478, 24);
            this.layoutControlItem_TinhTrang.Text = "Tình trạng:";
            this.layoutControlItem_TinhTrang.TextSize = new System.Drawing.Size(78, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(478, 48);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(478, 24);
            // 
            // layoutControlItem_Grid
            // 
            this.layoutControlItem_Grid.Control = this.gridPhong;
            this.layoutControlItem_Grid.Location = new System.Drawing.Point(0, 157);
            this.layoutControlItem_Grid.Name = "layoutControlItem_Grid";
            this.layoutControlItem_Grid.Size = new System.Drawing.Size(980, 423);
            this.layoutControlItem_Grid.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.Location = new System.Drawing.Point(0, 147);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(980, 10);
            // 
            // layoutControlItem_BtnThem
            // 
            this.layoutControlItem_BtnThem.Control = this.btnThem;
            this.layoutControlItem_BtnThem.Location = new System.Drawing.Point(0, 117);
            this.layoutControlItem_BtnThem.MaxSize = new System.Drawing.Size(0, 30);
            this.layoutControlItem_BtnThem.MinSize = new System.Drawing.Size(39, 30);
            this.layoutControlItem_BtnThem.Name = "layoutControlItem_BtnThem";
            this.layoutControlItem_BtnThem.Size = new System.Drawing.Size(166, 30);
            this.layoutControlItem_BtnThem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem_BtnThem.TextVisible = false;
            // 
            // layoutControlItem_BtnSua
            // 
            this.layoutControlItem_BtnSua.Control = this.btnSua;
            this.layoutControlItem_BtnSua.Location = new System.Drawing.Point(166, 117);
            this.layoutControlItem_BtnSua.MaxSize = new System.Drawing.Size(0, 30);
            this.layoutControlItem_BtnSua.MinSize = new System.Drawing.Size(33, 30);
            this.layoutControlItem_BtnSua.Name = "layoutControlItem_BtnSua";
            this.layoutControlItem_BtnSua.Size = new System.Drawing.Size(166, 30);
            this.layoutControlItem_BtnSua.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem_BtnSua.TextVisible = false;
            // 
            // layoutControlItem_BtnXoa
            // 
            this.layoutControlItem_BtnXoa.Control = this.btnXoa;
            this.layoutControlItem_BtnXoa.Location = new System.Drawing.Point(332, 117);
            this.layoutControlItem_BtnXoa.MaxSize = new System.Drawing.Size(0, 30);
            this.layoutControlItem_BtnXoa.MinSize = new System.Drawing.Size(33, 30);
            this.layoutControlItem_BtnXoa.Name = "layoutControlItem_BtnXoa";
            this.layoutControlItem_BtnXoa.Size = new System.Drawing.Size(164, 30);
            this.layoutControlItem_BtnXoa.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem_BtnXoa.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(496, 117);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(484, 30);
            // 
            // frmDanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmDanhSachPhong";
            this.Text = "Quản Lý Danh Sách Phòng";
            this.Load += new System.EventHandler(this.frmDanhSachPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpLoaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_MaPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_LoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_SoPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_TinhTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_BtnThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_BtnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_BtnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.LookUpEdit lookUpNhanVien;
        private DevExpress.XtraEditors.LookUpEdit lookUpLoaiPhong;
        // SỬA: Đổi tên txtTenPhong -> txtSoPhong
        private DevExpress.XtraEditors.TextEdit txtSoPhong;
        // MỚI: Thêm txtMaPhong
        private DevExpress.XtraEditors.TextEdit txtMaPhong;
        // MỚI: Thêm cmbTinhTrang
        private DevExpress.XtraEditors.ComboBoxEdit cmbTinhTrang;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        // MỚI: Nhóm các control nhập liệu
        private DevExpress.XtraLayout.LayoutControlGroup groupThongTin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_MaPhong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_LoaiPhong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_SoPhong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_NhanVien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_TinhTrang;
        // MỚI: Thêm đường kẻ phân cách
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_BtnThem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_BtnSua;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_BtnXoa;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.GridControl gridPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_Grid;
    }
}