using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class frmTimKiemKH : DevExpress.XtraEditors.XtraForm
    {
        private List<KhachHang> dsKhachHang = new List<KhachHang>();

        public class KhachHang
        {
            public string MaKH { get; set; }
            public string HoTen { get; set; }
            public string SDT { get; set; }
            public string CCCD { get; set; }
            public string Email { get; set; }
            public int DiemTichLuy { get; set; }
            public string TrangThai { get; set; }   // "InHotel" hoặc "CheckOut"
        }

        public frmTimKiemKH()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0; // Mặc định chọn "All Customer Details"
            this.Load += FrmTimKiemKH_Load;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FrmTimKiemKH_Load(object sender, EventArgs e)
        {
            LoadData(); // Gọi hàm load dữ liệu khi form mở
        }

        private void LoadData()
        {
            // Xóa dữ liệu cũ để tránh add trùng
            dsKhachHang.Clear();

            // Thêm dữ liệu mẫu có trạng thái
            dsKhachHang.Add(new KhachHang { MaKH = "KH01", HoTen = "Nguyen Van A", SDT = "0123456789", CCCD = "123456789", Email = "a@gmail.com", TrangThai = "InHotel" });
            dsKhachHang.Add(new KhachHang { MaKH = "KH02", HoTen = "Tran Thi B", SDT = "0987654321", CCCD = "987654321", Email = "b@gmail.com", TrangThai = "CheckOut" });
            dsKhachHang.Add(new KhachHang { MaKH = "KH03", HoTen = "Le Van C", SDT = "035798465", CCCD = "456789123", Email = "c@gmail.com", TrangThai = "InHotel" });

            // Hiển thị toàn bộ dữ liệu lên DataGridView
            dataGridView1.DataSource = dsKhachHang.ToList();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            string luaChon = comboBox1.SelectedItem?.ToString();
            string keyword = txtMaKH.Text.Trim().ToLower();

            var ketQua = dsKhachHang.AsQueryable();

            if (luaChon == "All Customer Details")
            {
                // Không lọc gì
                ketQua = dsKhachHang.AsQueryable();
            }
            else if (luaChon == "In Hotel Customer")
            {
                ketQua = ketQua.Where(x => x.TrangThai == "InHotel");
            }
            else if (luaChon == "CheckOut Customer")
            {
                ketQua = ketQua.Where(x => x.TrangThai == "CheckOut");
            }

            // Nếu người dùng nhập Mã KH
            if (!string.IsNullOrEmpty(keyword))
            {
                ketQua = ketQua.Where(x => x.MaKH.ToLower().Contains(keyword));
            }

            dataGridView1.DataSource = ketQua.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất file đang được phát triển!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
