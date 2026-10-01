using HospitalManagement.DTO;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HospitalManagement.DAL
{
    public class NhapVienDAL : DBConnection
    {
        public DataTable GetDanhSachNhapVien()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    nv.MaNhapVien,
                    nv.MaBN,
                    bn.HoTen,

                    nv.MaBS,
                    bs.MaNV,
                    nvien.HoTen AS TenBacSi,

                    nv.MaKham,

                    nv.MaGiuong,
                    g.SoGiuong,

                    nv.NgayNhan,
                    nv.NgayTra

                FROM NhapVien nv

                INNER JOIN BenhNhan bn
                    ON nv.MaBN = bn.MaBN

                INNER JOIN BacSi bs
                    ON nv.MaBS = bs.MaBS

                INNER JOIN NhanVien nvien
                    ON bs.MaNV = nvien.MaNV

                INNER JOIN Giuong g
                    ON nv.MaGiuong = g.MaGiuong";

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

        public DataTable GetDanhSachBenhNhan()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    MaBN,
                    HoTen
                FROM BenhNhan
                ORDER BY HoTen";

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

        public DataTable GetDanhSachKhamBenh()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    MaKham
                FROM KhamBenh
                ORDER BY MaKham";

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
        public DataTable GetDanhSachGiuong(string maGiuongHienTai)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"
        SELECT
            MaGiuong,
            SoGiuong,
            MaGiuong + N' - Giường ' + SoGiuong AS HienThi
        FROM Giuong
        WHERE TrangThai = N'Trống'
           OR MaGiuong = @MaGiuongHienTai
        ORDER BY SoGiuong";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaGiuongHienTai",
                    (object)maGiuongHienTai ?? DBNull.Value);

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

        public bool Exists(string maNhapVien)
        {
            string sql = "SELECT COUNT(*) FROM NhapVien WHERE MaNhapVien = @MaNhapVien";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaNhapVien", maNhapVien);

            conn.Open();

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            return count > 0;
        }

        public bool Insert(NhapVienDTO nv)
        {
            string sql = @"
            INSERT INTO NhapVien
            (
                MaNhapVien,
                MaBN,
                MaBS,
                MaKham,
                MaGiuong,
                NgayNhan,
                NgayTra
            )
            VALUES
            (
                @MaNhapVien,
                @MaBN,
                @MaBS,
                @MaKham,
                @MaGiuong,
                @NgayNhan,
                @NgayTra
            )";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaNhapVien", nv.MaNhapVien);
            cmd.Parameters.AddWithValue("@MaBN", nv.MaBN);
            cmd.Parameters.AddWithValue("@MaBS", nv.MaBS);
            cmd.Parameters.AddWithValue("@MaKham", nv.MaKham);
            cmd.Parameters.AddWithValue("@MaGiuong", nv.MaGiuong);
            cmd.Parameters.AddWithValue("@NgayNhan", nv.NgayNhan);

            if (nv.NgayTra.HasValue)
                cmd.Parameters.AddWithValue("@NgayTra", nv.NgayTra.Value);
            else
                cmd.Parameters.AddWithValue("@NgayTra", DBNull.Value);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }

        public bool Update(NhapVienDTO nv)
        {
            string sql = @"
            UPDATE NhapVien
            SET
                MaBN=@MaBN,
                MaBS=@MaBS,
                MaKham=@MaKham,
                MaGiuong=@MaGiuong,
                NgayNhan=@NgayNhan,
                NgayTra=@NgayTra
            WHERE MaNhapVien=@MaNhapVien";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaNhapVien", nv.MaNhapVien);
            cmd.Parameters.AddWithValue("@MaBN", nv.MaBN);
            cmd.Parameters.AddWithValue("@MaBS", nv.MaBS);
            cmd.Parameters.AddWithValue("@MaKham", nv.MaKham);
            cmd.Parameters.AddWithValue("@MaGiuong", nv.MaGiuong);
            cmd.Parameters.AddWithValue("@NgayNhan", nv.NgayNhan);

            if (nv.NgayTra.HasValue)
                cmd.Parameters.AddWithValue("@NgayTra", nv.NgayTra.Value);
            else
                cmd.Parameters.AddWithValue("@NgayTra", DBNull.Value);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }

        public bool Delete(string maNhapVien)
        {
            string sql = "DELETE FROM NhapVien WHERE MaNhapVien=@MaNhapVien";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaNhapVien", maNhapVien);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();

            string sql = @"
            SELECT
                nv.MaNhapVien,
                nv.MaBN,
                bn.HoTen,

                nv.MaBS,
                nvien.HoTen AS TenBacSi,

                nv.MaKham,
                nv.MaGiuong,
                g.SoGiuong,

                nv.NgayNhan,
                nv.NgayTra

            FROM NhapVien nv

            INNER JOIN BenhNhan bn
                ON nv.MaBN = bn.MaBN

            INNER JOIN BacSi bs
                ON nv.MaBS = bs.MaBS

            INNER JOIN NhanVien nvien
                ON bs.MaNV = nvien.MaNV

            INNER JOIN Giuong g
                ON nv.MaGiuong = g.MaGiuong

            WHERE nv.MaNhapVien LIKE @kw
               OR nv.MaBN LIKE @kw
               OR bn.HoTen LIKE @kw
               OR nvien.HoTen LIKE @kw
               OR nv.MaKham LIKE @kw";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

            da.Fill(dt);

            return dt;
        }
    }
}