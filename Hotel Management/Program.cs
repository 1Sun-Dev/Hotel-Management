using System;
using System.Windows.Forms;

namespace Hotel_Management
{
    internal static class Program
    {
        /// <summary>
        /// Điểm khởi động chính của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMaincs()); // Mở form Login đầu tiên
        }
    }
}
