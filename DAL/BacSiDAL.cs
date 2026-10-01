using HospitalManagement.DAL;
using HospitalManagement.DTO;
using Microsoft.Data.SqlClient;
using System.Data;

public class BacSiDAL : DBConnection
{
    public DataTable GetDanhSachBacSi()
    {
        DataTable dt = new DataTable();

        try
        {
            conn.Open();

            string sql = @"
        SELECT
            bs.MaBS,
            bs.MaNV,
            nv.HoTen,
            bs.ChuyenNganh,
            bs.KyNang,
            bs.LichLamViec
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

    public DataTable GetNhanVien()
    {
        DataTable dt = new DataTable();

        try
        {
            conn.Open();

            string sql = @"
        SELECT
            MaNV,
            HoTen
        FROM NhanVien";

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

    public bool Exists(string maBS)
    {
        string sql = "SELECT COUNT(*) FROM BacSi WHERE MaBS = @MaBS";

        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@MaBS", maBS);

        conn.Open();

        int count = (int)cmd.ExecuteScalar();

        conn.Close();

        return count > 0;
    }

    public bool Insert(BacSiDTO bs)
    {
        string sql = @"INSERT INTO BacSi
                  (MaBS, MaNV, ChuyenNganh, KyNang, LichLamViec)
                  VALUES
                  (@MaBS,@MaNV,@ChuyenNganh,@KyNang,@LichLamViec)";

        SqlCommand cmd = new SqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@MaBS", bs.MaBS);
        cmd.Parameters.AddWithValue("@MaNV", bs.MaNV);
        cmd.Parameters.AddWithValue("@ChuyenNganh", bs.ChuyenNganh);
        cmd.Parameters.AddWithValue("@KyNang", bs.KyNang);
        cmd.Parameters.AddWithValue("@LichLamViec", bs.LichLamViec);

        conn.Open();

        int rows = cmd.ExecuteNonQuery();

        conn.Close();

        return rows > 0;
    }

    public bool Update(BacSiDTO bs)
    {
        string sql = @"UPDATE BacSi
                   SET MaNV=@MaNV,
                       ChuyenNganh=@ChuyenNganh,
                       KyNang=@KyNang,
                       LichLamViec=@LichLamViec
                   WHERE MaBS=@MaBS";

        SqlCommand cmd = new SqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@MaBS", bs.MaBS);
        cmd.Parameters.AddWithValue("@MaNV", bs.MaNV);
        cmd.Parameters.AddWithValue("@ChuyenNganh", bs.ChuyenNganh);
        cmd.Parameters.AddWithValue("@KyNang", bs.KyNang);
        cmd.Parameters.AddWithValue("@LichLamViec", bs.LichLamViec);

        conn.Open();

        int rows = cmd.ExecuteNonQuery();

        conn.Close();

        return rows > 0;
    }

    public bool Delete(string maBS)
    {
        string sql = "DELETE FROM BacSi WHERE MaBS=@MaBS";

        SqlCommand cmd = new SqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@MaBS", maBS);

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
        bs.MaBS,
        bs.MaNV,
        nv.HoTen,
        bs.ChuyenNganh,
        bs.KyNang,
        bs.LichLamViec
    FROM BacSi bs
    INNER JOIN NhanVien nv
        ON bs.MaNV = nv.MaNV
    WHERE bs.MaBS LIKE @kw
       OR nv.HoTen LIKE @kw
       OR bs.ChuyenNganh LIKE @kw";

        SqlDataAdapter da = new SqlDataAdapter(sql, conn);

        da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

        da.Fill(dt);

        return dt;
    }
}


