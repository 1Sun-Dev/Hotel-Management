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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            gnPnThanhToan.Visible = true;
            gnPnCusPayment.Visible = false;
        }

        private void gnbtnCheckOut_Click(object sender, EventArgs e)
        {
            // Ẩn panel tìm kiếm
            gnPnThanhToan.Visible = false;

            // Hiện panel thanh toán
            gnPnCusPayment.Visible = true;
            gnPnCusPayment.BringToFront();
        }

        private void gnbtnBack_Click(object sender, EventArgs e)
        {
            // Ẩn panel thanh toán
            gnPnCusPayment.Visible = false;

            // Hiện lại panel tìm kiếm
            gnPnThanhToan.Visible = true;
            gnPnThanhToan.BringToFront();
        }

        private void gnbtnConfirmPayment_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Payment Confirmation?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Payment Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
