using Microsoft.Data.SqlClient;
using HospitalManagement.DTO;

namespace HospitalManagement.DAL
{
    public class PermissionDAL : DBConnection
    {
        public List<PermissionDTO> GetPermissionsByRole(string maRole)
        {
            List<PermissionDTO> list = new List<PermissionDTO>();

            conn.Open();

            string sql = @"
            SELECT p.MaPermission,
                   p.TenPermission,
                   p.MoTa
            FROM Permission p
            INNER JOIN RolePermission rp
                ON p.MaPermission = rp.MaPermission
            WHERE rp.MaRole = @MaRole";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaRole", maRole);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                PermissionDTO p = new PermissionDTO();

                p.MaPermission = reader["MaPermission"].ToString();
                p.TenPermission = reader["TenPermission"].ToString();
                p.MoTa = reader["MoTa"].ToString();

                list.Add(p);
            }

            reader.Close();
            conn.Close();

            return list;
        }
    }
}