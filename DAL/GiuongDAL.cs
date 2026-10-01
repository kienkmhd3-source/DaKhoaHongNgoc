using HospitalManagement.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagement.DAL
{
    public class GiuongDAL : DBConnection
    {
        
        public DataTable GetDanhSachGiuong()
        {
            try
            {
                conn.Open();

                string sql = @"
                    SELECT
                        g.MaGiuong,
                        g.SoGiuong,
                        g.TrangThai,
                        p.TenPhong,
                        g.MaPhong
                    FROM Giuong g
                    INNER JOIN Phong p
                        ON g.MaPhong = p.MaPhong
                    ORDER BY g.MaGiuong";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi lấy danh sách giường:\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        
        public DataTable GetDanhSachPhong()
        {
            try
            {
                conn.Open();

                string sql = @"
                    SELECT
                        MaPhong,
                        TenPhong
                    FROM Phong
                    ORDER BY TenPhong";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi lấy danh sách phòng:\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool Exists(string maGiuong)
        {
            try
            {
                conn.Open();

                string sql =
                    @"SELECT COUNT(*)
                      FROM Giuong
                      WHERE MaGiuong=@MaGiuong";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaGiuong", maGiuong);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi kiểm tra mã giường:\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool Insert(GiuongDTO g)
        {
            try
            {
                conn.Open();

                string sql = @"
                    INSERT INTO Giuong
                    (
                        MaGiuong,
                        SoGiuong,
                        TrangThai,
                        MaPhong
                    )
                    VALUES
                    (
                        @MaGiuong,
                        @SoGiuong,
                        @TrangThai,
                        @MaPhong
                    )";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaGiuong", g.MaGiuong);
                cmd.Parameters.AddWithValue("@SoGiuong", g.SoGiuong);
                cmd.Parameters.AddWithValue("@TrangThai", g.TrangThai);
                cmd.Parameters.AddWithValue("@MaPhong", g.MaPhong);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thêm giường thất bại!\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool Update(GiuongDTO g)
        {
            try
            {
                conn.Open();

                string sql = @"
                    UPDATE Giuong
                    SET
                        SoGiuong=@SoGiuong,
                        TrangThai=@TrangThai,
                        MaPhong=@MaPhong
                    WHERE
                        MaGiuong=@MaGiuong";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaGiuong", g.MaGiuong);
                cmd.Parameters.AddWithValue("@SoGiuong", g.SoGiuong);
                cmd.Parameters.AddWithValue("@TrangThai", g.TrangThai);
                cmd.Parameters.AddWithValue("@MaPhong", g.MaPhong);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Sửa giường thất bại!\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool Delete(string maGiuong)
        {
            try
            {
                conn.Open();

                string sql =
                    @"DELETE FROM Giuong
                      WHERE MaGiuong=@MaGiuong";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaGiuong", maGiuong);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Xóa giường thất bại!\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable TimKiemGiuong(string keyword)
        {
            try
            {
                conn.Open();

                string sql = @"
                    SELECT
                        g.MaGiuong,
                        g.SoGiuong,
                        g.TrangThai,
                        p.TenPhong,
                        g.MaPhong
                    FROM Giuong g
                    INNER JOIN Phong p
                        ON g.MaPhong=p.MaPhong
                    WHERE
                        g.MaGiuong LIKE @kw
                        OR g.SoGiuong LIKE @kw
                        OR g.TrangThai LIKE @kw
                        OR p.TenPhong LIKE @kw
                    ORDER BY g.MaGiuong";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tìm kiếm:\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}