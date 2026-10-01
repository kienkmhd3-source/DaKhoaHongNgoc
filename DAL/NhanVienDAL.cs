using HospitalManagement.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DAL
{
    public class NhanVienDAL : DBConnection
    {
        public DataTable GetDanhSachNhanVien()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    nv.MaNV,
                    nv.HoTen,
                    nv.CMND,
                    nv.GioiTinh,
                    nv.NgaySinh,
                    nv.DiaChi,
                    nv.NgayTuyenDung,
                    nv.ChucDanh,
                    nv.MaKhoa,
                    k.TenKhoa
                FROM NhanVien nv
                INNER JOIN Khoa k
                    ON nv.MaKhoa = k.MaKhoa";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return dt;
        }

        public DataTable GetDanhSachKhoa()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = "SELECT MaKhoa, TenKhoa FROM Khoa";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.Fill(dt);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return dt;
        }

        public bool Exists(string maNV)
        {
            try
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV=@MaNV";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaNV", maNV);

                return (int)cmd.ExecuteScalar() > 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool Insert(NhanVienDTO nv)
        {
            try
            {
                conn.Open();

                string sql = @"
                INSERT INTO NhanVien
                VALUES
                (
                @MaNV,
                @HoTen,
                @CMND,
                @GioiTinh,
                @NgaySinh,
                @DiaChi,
                @NgayTuyenDung,
                @ChucDanh,
                @MaKhoa
                )";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@CMND", nv.CMND);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@NgayTuyenDung", nv.NgayTuyenDung);
                cmd.Parameters.AddWithValue("@ChucDanh", nv.ChucDanh);
                cmd.Parameters.AddWithValue("@MaKhoa", nv.MaKhoa);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        public bool Update(NhanVienDTO nv)
        {
            try
            {
                conn.Open();

                string sql = @"
                UPDATE NhanVien
                SET
                HoTen=@HoTen,
                CMND=@CMND,
                GioiTinh=@GioiTinh,
                NgaySinh=@NgaySinh,
                DiaChi=@DiaChi,
                NgayTuyenDung=@NgayTuyenDung,
                ChucDanh=@ChucDanh,
                MaKhoa=@MaKhoa
                WHERE MaNV=@MaNV";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@CMND", nv.CMND);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@NgayTuyenDung", nv.NgayTuyenDung);
                cmd.Parameters.AddWithValue("@ChucDanh", nv.ChucDanh);
                cmd.Parameters.AddWithValue("@MaKhoa", nv.MaKhoa);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool Delete(string maNV)
        {
            try
            {
                conn.Open();

                string sql = "DELETE FROM NhanVien WHERE MaNV=@MaNV";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaNV", maNV);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable TimKiemNhanVien(string keyword)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    nv.MaNV,
                    nv.HoTen,
                    nv.CMND,
                    nv.GioiTinh,
                    nv.NgaySinh,
                    nv.DiaChi,
                    nv.NgayTuyenDung,
                    nv.ChucDanh,
                    nv.MaKhoa,
                    k.TenKhoa
                FROM NhanVien nv
                INNER JOIN Khoa k
                    ON nv.MaKhoa = k.MaKhoa
                WHERE
                    nv.MaNV LIKE @keyword
                    OR nv.HoTen LIKE @keyword
                    OR nv.CMND LIKE @keyword
                    OR nv.ChucDanh LIKE @keyword
                    OR k.TenKhoa LIKE @keyword";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return dt;
        }
    }
}
