using HospitalManagement.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagement.DAL
{
    public class TaiKhoanDAL : DBConnection
    {
        public TaiKhoanDTO DangNhap(TaiKhoanDTO tk)
        {
            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    TenDangNhap,
                    MatKhau,
                    VaiTro,
                    MaRole
                FROM TaiKhoan
                WHERE TenDangNhap=@TenDangNhap
                  AND MatKhau=@MatKhau";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    return new TaiKhoanDTO
                    {
                        TenDangNhap = rd["TenDangNhap"].ToString(),
                        MatKhau = rd["MatKhau"].ToString(),
                        VaiTro = rd["VaiTro"].ToString(),
                        MaRole = rd["MaRole"].ToString()
                    };
                }

                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable GetDanhSachTaiKhoan()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"SELECT *
                               FROM TaiKhoan";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không tải được danh sách tài khoản!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return dt;
        }

        public bool Exists(string tenDangNhap)
        {
            try
            {
                conn.Open();

                string sql = @"SELECT COUNT(*)
                               FROM TaiKhoan
                               WHERE TenDangNhap=@TenDangNhap";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                return (int)cmd.ExecuteScalar() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
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

        public bool Insert(TaiKhoanDTO tk)
        {
            try
            {
                conn.Open();

                string sql = @"INSERT INTO TaiKhoan
                       (
                           TenDangNhap,
                           MatKhau,
                           VaiTro
                       )
                       VALUES
                       (
                           @TenDangNhap,
                           @MatKhau,
                           @VaiTro
                       )";

                

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
                cmd.Parameters.AddWithValue("@VaiTro", tk.VaiTro);

               

                int kq = cmd.ExecuteNonQuery();


                return kq > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                return false;
            }
        }

        public bool Update(TaiKhoanDTO tk)
        {
            try
            {
                conn.Open();

                string sql = @"UPDATE TaiKhoan
                               SET
                                    MatKhau=@MatKhau,
                                    VaiTro=@VaiTro
                               WHERE TenDangNhap=@TenDangNhap";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
                cmd.Parameters.AddWithValue("@VaiTro", tk.VaiTro);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
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

        public bool Delete(string tenDangNhap)
        {
            try
            {
                conn.Open();

                string sql = @"DELETE FROM TaiKhoan
                               WHERE TenDangNhap=@TenDangNhap";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
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

        public DataTable TimKiemTaiKhoan(string keyword)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = @"SELECT *
                               FROM TaiKhoan
                               WHERE TenDangNhap LIKE @keyword
                                  OR VaiTro LIKE @keyword";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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