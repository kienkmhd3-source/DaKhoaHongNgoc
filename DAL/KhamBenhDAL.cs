using HospitalManagement.DTO;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HospitalManagement.DAL
{
    public class KhamBenhDAL : DBConnection
    {
        //==========================
        // Lấy danh sách khám bệnh
        //==========================
        public DataTable GetDanhSachKhamBenh()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    kb.MaKham,
                    kb.MaBN,
                    bn.HoTen,
                    kb.MaBS,
                    nv.HoTen AS TenBacSi,
                    kb.ThoiDiemKham,
                    kb.TrieuChung,
                    kb.ChanDoan,
                    kb.DonThuoc,
                    kb.KetLuan
                FROM KhamBenh kb
                INNER JOIN BenhNhan bn
                    ON kb.MaBN = bn.MaBN
                INNER JOIN BacSi bs
                    ON kb.MaBS = bs.MaBS
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

        //==========================
        // Lấy danh sách bệnh nhân
        //==========================
        public DataTable GetBenhNhan()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    MaBN,
                    HoTen
                FROM BenhNhan";

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

        //==========================
        // Lấy danh sách bác sĩ
        //==========================
        public DataTable GetBacSi()
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

        //==========================
        // Kiểm tra tồn tại
        //==========================
        public bool Exists(string maKham)
        {
            string sql = "SELECT COUNT(*) FROM KhamBenh WHERE MaKham=@MaKham";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaKham", maKham);

            conn.Open();

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            return count > 0;
        }

        //==========================
        // Thêm
        //==========================
        public bool Insert(KhamBenhDTO kb)
        {
            string sql = @"
            INSERT INTO KhamBenh
            (
                MaKham,
                MaBN,
                MaBS,
                ThoiDiemKham,
                TrieuChung,
                ChanDoan,
                DonThuoc,
                KetLuan
            )
            VALUES
            (
                @MaKham,
                @MaBN,
                @MaBS,
                @ThoiDiemKham,
                @TrieuChung,
                @ChanDoan,
                @DonThuoc,
                @KetLuan
            )";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaKham", kb.MaKham);
            cmd.Parameters.AddWithValue("@MaBN", kb.MaBN);
            cmd.Parameters.AddWithValue("@MaBS", kb.MaBS);
            cmd.Parameters.AddWithValue("@ThoiDiemKham", kb.ThoiDiemKham);
            cmd.Parameters.AddWithValue("@TrieuChung", kb.TrieuChung);
            cmd.Parameters.AddWithValue("@ChanDoan", kb.ChanDoan);
            cmd.Parameters.AddWithValue("@DonThuoc", kb.DonThuoc);
            cmd.Parameters.AddWithValue("@KetLuan", kb.KetLuan);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }

        //==========================
        // Sửa
        //==========================
        public bool Update(KhamBenhDTO kb)
        {
            string sql = @"
            UPDATE KhamBenh
            SET
                MaBN=@MaBN,
                MaBS=@MaBS,
                ThoiDiemKham=@ThoiDiemKham,
                TrieuChung=@TrieuChung,
                ChanDoan=@ChanDoan,
                DonThuoc=@DonThuoc,
                KetLuan=@KetLuan
            WHERE MaKham=@MaKham";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaKham", kb.MaKham);
            cmd.Parameters.AddWithValue("@MaBN", kb.MaBN);
            cmd.Parameters.AddWithValue("@MaBS", kb.MaBS);
            cmd.Parameters.AddWithValue("@ThoiDiemKham", kb.ThoiDiemKham);
            cmd.Parameters.AddWithValue("@TrieuChung", kb.TrieuChung);
            cmd.Parameters.AddWithValue("@ChanDoan", kb.ChanDoan);
            cmd.Parameters.AddWithValue("@DonThuoc", kb.DonThuoc);
            cmd.Parameters.AddWithValue("@KetLuan", kb.KetLuan);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }

        //==========================
        // Xóa
        //==========================
        public bool Delete(string maKham)
        {
            string sql = "DELETE FROM KhamBenh WHERE MaKham=@MaKham";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaKham", maKham);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }

        //==========================
        // Tìm kiếm
        //==========================
        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();

            string sql = @"
            SELECT
                kb.MaKham,
                kb.MaBN,
                bn.HoTen,
                kb.MaBS,
                nv.HoTen AS TenBacSi,
                kb.ThoiDiemKham,
                kb.TrieuChung,
                kb.ChanDoan,
                kb.DonThuoc,
                kb.KetLuan
            FROM KhamBenh kb
            INNER JOIN BenhNhan bn
                ON kb.MaBN = bn.MaBN
            INNER JOIN BacSi bs
                ON kb.MaBS = bs.MaBS
            INNER JOIN NhanVien nv
                ON bs.MaNV = nv.MaNV
            WHERE
                kb.MaKham LIKE @kw
                OR bn.HoTen LIKE @kw
                OR nv.HoTen LIKE @kw
                OR kb.ChanDoan LIKE @kw";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

            da.Fill(dt);

            return dt;
        }
    }
}