using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class frmMaincs : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMaincs()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void skinDropDownButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
                    }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQLKhachHang f = new frmQLKhachHang();
            f.TopLevel = false; //Không phải form con
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None; //Bỏ viền
            f.Dock = DockStyle.Fill; //focus màn hình chính
            f.Show();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void skinPaletteDropDownButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frmMaincs_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.TopLevel = false; //Không phải form con
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None; //Bỏ viền
            f.Dock = DockStyle.Fill; //focus màn hình chính
            f.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {

            frmDanhSachPhong f = new frmDanhSachPhong();
            f.TopLevel = false; //Không phải form con
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None; //Bỏ viền
            f.Dock = DockStyle.Fill; //focus màn hình chính
            f.Show();
        }

        private void G_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmGoiDV f = new frmGoiDV();
            f.TopLevel = false; //Không phải form con
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None; //Bỏ viền
            f.Dock = DockStyle.Fill; //focus màn hình chính
            f.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTimKiemKH t = new frmTimKiemKH();
            t.TopLevel = false; //Không phải form con
            t.MdiParent = this;
            t.FormBorderStyle = FormBorderStyle.None; //Bỏ viền
            t.Dock = DockStyle.Fill;
            t.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThanhToan t = new ThanhToan();
            t.TopLevel = false; //Không phải form con
            t.MdiParent = this;
            t.FormBorderStyle = FormBorderStyle.None; //Bỏ viền
            t.Dock = DockStyle.Fill;
            t.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }
    }
}