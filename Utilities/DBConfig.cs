namespace HospitalManagement.Utilities
{
    public static class DBConfig
    {
        public static string ConnectionString =
            @"Server=(localdb)\MSSQLLocalDB;
              Database=HospitalDB;
              Trusted_Connection=True;
              TrustServerCertificate=True;";
    }
}