using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Database
{
    public static class DatabaseHelper
    {
        // 1. Lấy chuỗi kết nối từ App.config (An toàn hơn)
        private static string GetConnectionString()
        {
            // BẠN CẦN THÊM FILE App.config VÀO DỰ ÁN
            // VÀ THÊM CHUỖI KẾT NỐI VÀO ĐÓ
            // <connectionStrings>
            //   <add name="default" connectionString="Data Source=Admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=True;Trust Server Certificate=True" />
            // </connectionStrings>
            //
            // CŨNG CẦN THÊM REFERENCE: System.Configuration

            string connStr = ConfigurationManager.ConnectionStrings["default"]?.ConnectionString;
            if (string.IsNullOrEmpty(connStr))
            {
                // Chuỗi kết nối dự phòng nếu không tìm thấy App.config
                connStr = @"Data Source=Admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            }
            return connStr;
        }

        // 2. Hàm chung để chạy CUD (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            // Dùng 'using' để tự động mở và đóng kết nối, tránh lỗi
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // 3. Hàm chung để lấy dữ liệu (SELECT)
        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    if (parameters != null)
                    {
                        da.SelectCommand.Parameters.AddRange(parameters);
                    }
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
