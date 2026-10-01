using HospitalManagement.DTO;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HospitalManagement.DAL
{
    public class PhongDAL : DBConnection
    {
        public DataTable GetDanhSachPhong()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"SELECT p.MaPhong,
                                      p.SoPhong,
                                      p.TenPhong,
                                      k.TenKhoa,
                                      p.MaKhoa
                               FROM Phong p
                               INNER JOIN Khoa k
                               ON p.MaKhoa = k.MaKhoa";

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

        public bool Exists(string maPhong)
        {
            string sql = "SELECT COUNT(*) FROM Phong WHERE MaPhong=@MaPhong";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);

            conn.Open();

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            return count > 0;
        }

        public bool Insert(PhongDTO p)
        {
            string sql = @"INSERT INTO Phong
                   VALUES(@MaPhong,@SoPhong,@TenPhong,@MaKhoa)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaPhong", p.MaPhong);
            cmd.Parameters.AddWithValue("@SoPhong", p.SoPhong);
            cmd.Parameters.AddWithValue("@TenPhong", p.TenPhong);
            cmd.Parameters.AddWithValue("@MaKhoa", p.MaKhoa);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }

        public bool Update(PhongDTO p)
        {
            string sql = @"UPDATE Phong
                   SET SoPhong=@SoPhong,
                       TenPhong=@TenPhong,
                       MaKhoa=@MaKhoa
                   WHERE MaPhong=@MaPhong";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaPhong", p.MaPhong);
            cmd.Parameters.AddWithValue("@SoPhong", p.SoPhong);
            cmd.Parameters.AddWithValue("@TenPhong", p.TenPhong);
            cmd.Parameters.AddWithValue("@MaKhoa", p.MaKhoa);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }

        public bool Delete(string maPhong)
        {
            string sql = "DELETE FROM Phong WHERE MaPhong=@MaPhong";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaPhong", maPhong);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();

            string sql = @"SELECT p.MaPhong,
                          p.SoPhong,
                          p.TenPhong,
                          k.TenKhoa,
                          p.MaKhoa
                   FROM Phong p
                   INNER JOIN Khoa k
                        ON p.MaKhoa=k.MaKhoa
                   WHERE p.MaPhong LIKE @kw
                      OR p.SoPhong LIKE @kw
                      OR p.TenPhong LIKE @kw";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

            da.Fill(dt);

            return dt;
        }
    }
}