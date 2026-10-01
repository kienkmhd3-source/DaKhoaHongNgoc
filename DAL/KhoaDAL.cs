using HospitalManagement.DTO;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HospitalManagement.DAL
{
    public class KhoaDAL : DBConnection
    {
        public DataTable GetDanhSachKhoa()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Khoa";

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

        public bool Insert(KhoaDTO k)
        {
            try
            {
                conn.Open();

                string sql = @"INSERT INTO Khoa(MaKhoa, TenKhoa, MoTa)
                       VALUES(@MaKhoa, @TenKhoa, @MoTa)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaKhoa", k.MaKhoa);
                cmd.Parameters.AddWithValue("@TenKhoa", k.TenKhoa);
                cmd.Parameters.AddWithValue("@MoTa", k.MoTa);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool Update(KhoaDTO k)
        {
            try
            {
                conn.Open();

                string sql = @"UPDATE Khoa
                       SET TenKhoa = @TenKhoa,
                           MoTa = @MoTa
                       WHERE MaKhoa = @MaKhoa";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaKhoa", k.MaKhoa);
                cmd.Parameters.AddWithValue("@TenKhoa", k.TenKhoa);
                cmd.Parameters.AddWithValue("@MoTa", k.MoTa);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool Delete(string maKhoa)
        {
            try
            {
                conn.Open();

                string sql = "DELETE FROM Khoa WHERE MaKhoa = @MaKhoa";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"SELECT *
                       FROM Khoa
                       WHERE MaKhoa LIKE @keyword
                          OR TenKhoa LIKE @keyword";

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

        public bool Exists(string maKhoa)
        {
            try
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM Khoa WHERE MaKhoa=@MaKhoa";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);

                return (int)cmd.ExecuteScalar() > 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}