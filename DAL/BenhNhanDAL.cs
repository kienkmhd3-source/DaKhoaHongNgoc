using HospitalManagement.DTO;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HospitalManagement.DAL
{
    public class BenhNhanDAL : DBConnection
    {
        public DataTable GetDanhSachBenhNhan()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    bn.MaBN,
                    bn.HoTen,
                    bn.CMND,
                    bn.GioiTinh,
                    bn.NgaySinh,
                    bn.DiaChi,
                    bn.NgayDangKy,
                    bn.BenhDaPhatHien,
                    bn.MaBS,
                    nv.HoTen AS TenBacSi
                FROM BenhNhan bn
                INNER JOIN BacSi bs
                    ON bn.MaBS = bs.MaBS
                INNER JOIN NhanVien nv
                    ON bs.MaNV = nv.MaNV";

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


        public DataTable GetDanhSachBacSi()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    bs.MaBS,
                    nv.HoTen
                FROM BacSi bs
                INNER JOIN NhanVien nv
                    ON bs.MaNV = nv.MaNV
                ORDER BY nv.HoTen";

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


        public bool Exists(string maBN)
        {
            try
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM BenhNhan WHERE MaBN=@MaBN";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaBN", maBN);

                return (int)cmd.ExecuteScalar() > 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        
        public bool KiemTraTrungCCCD(string cmnd)
        {
            try
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM BenhNhan WHERE CMND=@CMND";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CMND", cmnd);

                return (int)cmd.ExecuteScalar() > 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool Insert(BenhNhanDTO bn)
        {
            try
            {
                conn.Open();

                string sql = @"
                INSERT INTO BenhNhan
                VALUES
                (
                    @MaBN,
                    @HoTen,
                    @CMND,
                    @GioiTinh,
                    @NgaySinh,
                    @DiaChi,
                    @NgayDangKy,
                    @BenhDaPhatHien,
                    @MaBS
                )";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaBN", bn.MaBN);
                cmd.Parameters.AddWithValue("@HoTen", bn.HoTen);
                cmd.Parameters.AddWithValue("@CMND", bn.CMND);
                cmd.Parameters.AddWithValue("@GioiTinh", bn.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", bn.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", bn.DiaChi);
                cmd.Parameters.AddWithValue("@NgayDangKy", bn.NgayDangKy);
                cmd.Parameters.AddWithValue("@BenhDaPhatHien", bn.BenhDaPhatHien);
                cmd.Parameters.AddWithValue("@MaBS", bn.MaBS);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        
        public bool Update(BenhNhanDTO bn)
        {
            try
            {
                conn.Open();

                string sql = @"
                UPDATE BenhNhan
                SET
                    HoTen=@HoTen,
                    CMND=@CMND,
                    GioiTinh=@GioiTinh,
                    NgaySinh=@NgaySinh,
                    DiaChi=@DiaChi,
                    NgayDangKy=@NgayDangKy,
                    BenhDaPhatHien=@BenhDaPhatHien,
                    MaBS=@MaBS
                WHERE MaBN=@MaBN";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaBN", bn.MaBN);
                cmd.Parameters.AddWithValue("@HoTen", bn.HoTen);
                cmd.Parameters.AddWithValue("@CMND", bn.CMND);
                cmd.Parameters.AddWithValue("@GioiTinh", bn.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", bn.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", bn.DiaChi);
                cmd.Parameters.AddWithValue("@NgayDangKy", bn.NgayDangKy);
                cmd.Parameters.AddWithValue("@BenhDaPhatHien", bn.BenhDaPhatHien);
                cmd.Parameters.AddWithValue("@MaBS", bn.MaBS);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        
        public bool Delete(string maBN)
        {
            try
            {
                conn.Open();

                string sql = "DELETE FROM BenhNhan WHERE MaBN=@MaBN";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaBN", maBN);

                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

       
        public DataTable TimKiemBenhNhan(string keyword)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    bn.MaBN,
                    bn.HoTen,
                    bn.CMND,
                    bn.GioiTinh,
                    bn.NgaySinh,
                    bn.DiaChi,
                    bn.NgayDangKy,
                    bn.BenhDaPhatHien,
                    bn.MaBS,
                    nv.HoTen AS TenBacSi
                FROM BenhNhan bn
                INNER JOIN BacSi bs
                    ON bn.MaBS = bs.MaBS
                INNER JOIN NhanVien nv
                    ON bs.MaNV = nv.MaNV
                WHERE
                    bn.MaBN LIKE @keyword
                    OR bn.HoTen LIKE @keyword
                    OR bn.CMND LIKE @keyword
                    OR bn.BenhDaPhatHien LIKE @keyword
                    OR nv.HoTen LIKE @keyword";

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