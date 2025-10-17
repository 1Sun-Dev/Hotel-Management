using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class frmNhanVien : XtraForm
    {
        DataTable dt = new DataTable();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            TaoBangMau();
            LoadFakeData();
        }

        private void TaoBangMau()
        {
            dt.Columns.Add("MaNV");
            dt.Columns.Add("HoTen");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh", typeof(DateTime));
            dt.Columns.Add("SDT");
            dt.Columns.Add("ChucVu");
            dt.Columns.Add("Luong");
        }

        private void LoadFakeData()
        {
            dt.Rows.Add("NV001", "Đinh Võ Hồng My", "Nam", new DateTime(1995, 5, 12), "0905123456", "Lễ tân", "8,000,000");
            dt.Rows.Add("NV002", "Trần Thị B", "Nữ", new DateTime(1998, 7, 20), "0987123456", "Quản lý", "12,000,000");
            dt.Rows.Add("NV003", "Lê Văn C", "Nam", new DateTime(2000, 3, 8), "0912345678", "Bảo vệ", "6,500,000");

            gridControl1.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtMaNV.Text, txtHoTen.Text,
                rbNam.Checked ? "Nam" : "Nữ",
                dtNgaySinh.DateTime,
                txtSDT.Text, txtChucVu.Text, txtLuong.Text);

            XtraMessageBox.Show("✅ Thêm nhân viên thành công!", "Thông báo");
            ClearForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataRow row = dt.Rows.Find(txtMaNV.Text);
            if (row != null)
            {
                row["HoTen"] = txtHoTen.Text;
                row["GioiTinh"] = rbNam.Checked ? "Nam" : "Nữ";
                row["NgaySinh"] = dtNgaySinh.DateTime;
                row["SDT"] = txtSDT.Text;
                row["ChucVu"] = txtChucVu.Text;
                row["Luong"] = txtLuong.Text;
                XtraMessageBox.Show("🔄 Cập nhật thành công!");
            }
            else
            {
                XtraMessageBox.Show("Không tìm thấy nhân viên để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                XtraMessageBox.Show("🗑️ Xóa thành công!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            rbNam.Checked = true;
            dtNgaySinh.DateTime = DateTime.Now;
            txtSDT.Text = "";
            txtChucVu.Text = "";
            txtLuong.Text = "";
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (gridView1.GetFocusedDataRow() != null)
            {
                txtMaNV.Text = gridView1.GetFocusedDataRow()["MaNV"].ToString();
                txtHoTen.Text = gridView1.GetFocusedDataRow()["HoTen"].ToString();
                string gt = gridView1.GetFocusedDataRow()["GioiTinh"].ToString();
                rbNam.Checked = gt == "Nam";
                rbNu.Checked = gt == "Nữ";
                dtNgaySinh.DateTime = Convert.ToDateTime(gridView1.GetFocusedDataRow()["NgaySinh"]);
                txtSDT.Text = gridView1.GetFocusedDataRow()["SDT"].ToString();
                txtChucVu.Text = gridView1.GetFocusedDataRow()["ChucVu"].ToString();
                txtLuong.Text = gridView1.GetFocusedDataRow()["Luong"].ToString();
            }
        }
    }
}
