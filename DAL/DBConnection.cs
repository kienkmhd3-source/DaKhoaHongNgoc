using Microsoft.Data.SqlClient;
using HospitalManagement.Utilities;

namespace HospitalManagement.DAL
{
    public class DBConnection
    {
        protected SqlConnection conn;

        public DBConnection()
        {
            conn = new SqlConnection(DBConfig.ConnectionString);
        }
    }
}