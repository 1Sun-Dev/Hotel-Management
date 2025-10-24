using Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Database;
namespace Repository
{
    public class NhanVienRepository
    {
        // Lấy tất cả nhân viên (để hiển thị lên Grid)
        public DataTable GetAllNhanVien()
        {
            // Lấy tất cả các cột
            string query = "SELECT MaNV, HoTen, GioTinh, NgaySinh, SDT, ChucVu, Luong FROM NhanVien";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // Lấy dữ liệu rút gọn cho LookUpEdit (dropdown)
        public DataTable GetNhanVienLookup()
        {
            string query = "SELECT MaNV, HoTen FROM NhanVien";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // Thêm nhân viên
        public int InsertNhanVien(NhanVien nv)
        {
            string query = @"
                INSERT INTO NhanVien (MaNV, HoTen, GioTinh, NgaySinh, SDT, ChucVu, Luong) 
                VALUES (@MaNV, @HoTen, @GioTinh, @NgaySinh, @SDT, @ChucVu, @Luong)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@HoTen", nv.HoTen ?? (object)DBNull.Value),
                new SqlParameter("@GioTinh", nv.GioTinh ?? (object)DBNull.Value),
                new SqlParameter("@NgaySinh", nv.NgaySinh ?? (object)DBNull.Value),
                new SqlParameter("@SDT", nv.SDT ?? (object)DBNull.Value),
                new SqlParameter("@ChucVu", nv.ChucVu ?? (object)DBNull.Value),
                new SqlParameter("@Luong", nv.Luong ?? (object)DBNull.Value)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // Cập nhật nhân viên
        public int UpdateNhanVien(NhanVien nv)
        {
            string query = @"
                UPDATE NhanVien 
                SET HoTen = @HoTen, 
                    GioTinh = @GioTinh, 
                    NgaySinh = @NgaySinh, 
                    SDT = @SDT, 
                    ChucVu = @ChucVu, 
                    Luong = @Luong
                WHERE MaNV = @MaNV";

            SqlParameter[] parameters =
           {
                new SqlParameter("@HoTen", nv.HoTen ?? (object)DBNull.Value),
                new SqlParameter("@GioTinh", nv.GioTinh ?? (object)DBNull.Value),
                new SqlParameter("@NgaySinh", nv.NgaySinh ?? (object)DBNull.Value),
                new SqlParameter("@SDT", nv.SDT ?? (object)DBNull.Value),
                new SqlParameter("@ChucVu", nv.ChucVu ?? (object)DBNull.Value),
                new SqlParameter("@Luong", nv.Luong ?? (object)DBNull.Value),
                new SqlParameter("@MaNV", nv.MaNV) // Tham số WHERE
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // Xóa nhân viên
        public int DeleteNhanVien(string maNV)
        {
            string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters = { new SqlParameter("@MaNV", maNV) };
            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
