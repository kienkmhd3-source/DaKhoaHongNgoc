using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace HospitalManagement.DAL
{
    public class ThongKeDAL : DBConnection
    {
        private DataTable ExecuteTable(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

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

        private int ExecuteScalar(string sql)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public int TongBenhNhan()
        {
            return ExecuteScalar(
                "SELECT COUNT(*) FROM BenhNhan");
        }

        public int TongKhamBenh()
        {
            return ExecuteScalar(
                "SELECT COUNT(*) FROM KhamBenh");
        }

        public int TongNhapVien()
        {
            return ExecuteScalar(
                "SELECT COUNT(*) FROM NhapVien");
        }

        public int TongBacSi()
        {
            return ExecuteScalar(
                "SELECT COUNT(*) FROM BacSi");
        }

        public int TongGiuongTrong()
        {
            return ExecuteScalar(
                "SELECT COUNT(*) FROM Giuong WHERE TrangThai=N'Trống'");
        }

        public int TongGiuongDangSuDung()
        {
            return ExecuteScalar(
                "SELECT COUNT(*) FROM Giuong WHERE TrangThai=N'Đang sử dụng'");
        }

        public DataTable BenhNhanGanDay()
        {
            string sql = @"
            SELECT TOP 10
                bn.MaBN,
                bn.HoTen,
                bn.GioiTinh,
                kb.ThoiDiemKham
            FROM KhamBenh kb
            INNER JOIN BenhNhan bn
                ON kb.MaBN = bn.MaBN
            ORDER BY kb.ThoiDiemKham DESC";

            return ExecuteTable(sql);
        }

        public DataTable NhapVienGanDay()
        {
            string sql = @"
            SELECT TOP 10
                nv.MaNhapVien,
                bn.HoTen,
                nvien.HoTen AS TenBacSi,
                g.SoGiuong,
                nv.NgayNhan

            FROM NhapVien nv

            INNER JOIN BenhNhan bn
                ON nv.MaBN = bn.MaBN

            INNER JOIN BacSi bs
                ON nv.MaBS = bs.MaBS

            INNER JOIN NhanVien nvien
                ON bs.MaNV = nvien.MaNV

            INNER JOIN Giuong g
                ON nv.MaGiuong = g.MaGiuong

            ORDER BY nv.NgayNhan DESC";

            return ExecuteTable(sql);
        }

        #region CHI TIẾT

        public DataTable LichSuKhamBenh(string maBN)
        {
            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    kb.MaKham,
                    kb.ThoiDiemKham,
                    nv.HoTen AS BacSi,
                    kb.ChanDoan
                FROM KhamBenh kb
                INNER JOIN BacSi bs
                    ON kb.MaBS = bs.MaBS
                INNER JOIN NhanVien nv
                    ON bs.MaNV = nv.MaNV
                WHERE kb.MaBN = @MaBN
                ORDER BY kb.ThoiDiemKham DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue("@MaBN", maBN);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable ChiTietNhapVien(string maNhapVien)
        {
            try
            {
                conn.Open();

                string sql = @"
                SELECT

                    nv.MaNhapVien,

                    bn.HoTen AS BenhNhan,

                    n.HoTen AS BacSi,

                    p.TenPhong,

                    g.SoGiuong,

                    nv.NgayNhan,

                    nv.NgayTra

                FROM NhapVien nv

                INNER JOIN BenhNhan bn
                    ON nv.MaBN = bn.MaBN

                INNER JOIN BacSi bs
                    ON nv.MaBS = bs.MaBS

                INNER JOIN NhanVien n
                    ON bs.MaNV = n.MaNV

                INNER JOIN Giuong g
                    ON nv.MaGiuong = g.MaGiuong

                INNER JOIN Phong p
                    ON g.MaPhong = p.MaPhong

                WHERE nv.MaNhapVien=@MaNhapVien";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue("@MaNhapVien", maNhapVien);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable DanhSachPhongTheoKhoa(string maKhoa)
        {
            try
            {
                conn.Open();

                string sql = @"

        SELECT

            MaPhong,

            TenPhong

        FROM Phong

        WHERE MaKhoa=@MaKhoa

        ORDER BY TenPhong";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue("@MaKhoa", maKhoa);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable DanhSachGiuongTheoPhong(string maPhong)
        {
            try
            {
                conn.Open();

                string sql = @"

        SELECT

            MaGiuong,

            SoGiuong,

            TrangThai

        FROM Giuong

        WHERE MaPhong=@MaPhong

        ORDER BY SoGiuong";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue("@MaPhong", maPhong);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable DanhSachBenhNhanTheoBacSi(string maBS)
        {
            try
            {
                conn.Open();

                string sql = @"

                SELECT DISTINCT

                    bn.MaBN,

                    bn.HoTen,

                    bn.GioiTinh,

                    bn.SoDienThoai

                FROM KhamBenh kb

                INNER JOIN BenhNhan bn

                    ON kb.MaBN=bn.MaBN

                WHERE kb.MaBS=@MaBS

                ORDER BY bn.HoTen";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue("@MaBS", maBS);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        #endregion
        public DataTable ThongKeBenhNhan(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    bn.MaBN,
                    bn.HoTen,
                    bn.GioiTinh,
                    kb.ThoiDiemKham
                FROM KhamBenh kb
                INNER JOIN BenhNhan bn
                    ON kb.MaBN = bn.MaBN
                WHERE kb.ThoiDiemKham BETWEEN @TuNgay AND @DenNgay
                ORDER BY kb.ThoiDiemKham DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue("@TuNgay", tuNgay);
                da.SelectCommand.Parameters.AddWithValue("@DenNgay", denNgay);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable ThongKeKhamBenh(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    kb.MaKham,
                    bn.HoTen,
                    nv.HoTen AS TenBacSi,
                    kb.ChanDoan,
                    kb.ThoiDiemKham
                FROM KhamBenh kb
                INNER JOIN BenhNhan bn
                    ON kb.MaBN = bn.MaBN
                INNER JOIN BacSi bs
                    ON kb.MaBS = bs.MaBS
                INNER JOIN NhanVien nv
                    ON bs.MaNV = nv.MaNV
                WHERE kb.ThoiDiemKham BETWEEN @TuNgay AND @DenNgay
                ORDER BY kb.ThoiDiemKham DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue("@TuNgay", tuNgay);
                da.SelectCommand.Parameters.AddWithValue("@DenNgay", denNgay);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable ThongKeNhapVien(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    nv.MaNhapVien,
                    bn.HoTen AS BenhNhan,
                    n.HoTen AS BacSi,
                    g.SoGiuong,
                    nv.NgayNhan,
                    nv.NgayTra
                FROM NhapVien nv
                INNER JOIN BenhNhan bn
                    ON nv.MaBN = bn.MaBN
                INNER JOIN BacSi bs
                    ON nv.MaBS = bs.MaBS
                INNER JOIN NhanVien n
                    ON bs.MaNV = n.MaNV
                INNER JOIN Giuong g
                    ON nv.MaGiuong = g.MaGiuong
                WHERE nv.NgayNhan BETWEEN @TuNgay AND @DenNgay
                ORDER BY nv.NgayNhan DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue("@TuNgay", tuNgay);
                da.SelectCommand.Parameters.AddWithValue("@DenNgay", denNgay);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable DanhSachBacSi()
        {
            string sql = @"
            SELECT
                bs.MaBS,
                nv.HoTen,
                bs.ChuyenNganh,
                bs.KyNang,
                bs.LichLamViec
            FROM BacSi bs
            INNER JOIN NhanVien nv
                ON bs.MaNV = nv.MaNV
            ORDER BY nv.HoTen";

            return ExecuteTable(sql);
        }

        public DataTable DanhSachGiuong()
        {
            string sql = @"
            SELECT
                g.MaGiuong,
                g.SoGiuong,
                g.TrangThai,
                p.TenPhong
            FROM Giuong g
            INNER JOIN Phong p
                ON g.MaPhong = p.MaPhong
            ORDER BY p.TenPhong,g.SoGiuong";

            return ExecuteTable(sql);
        }

        public DataTable DanhSachPhong()
        {
            string sql = @"
            SELECT
                p.MaPhong,
                p.TenPhong,
                k.TenKhoa
            FROM Phong p
            INNER JOIN Khoa k
                ON p.MaKhoa = k.MaKhoa
            ORDER BY p.TenPhong";

            return ExecuteTable(sql);
        }

        public DataTable DanhSachKhoa()
        {
            string sql = @"
            SELECT
                MaKhoa,
                TenKhoa,
                MoTa
            FROM Khoa
            ORDER BY TenKhoa";

            return ExecuteTable(sql);
        }
    }
}