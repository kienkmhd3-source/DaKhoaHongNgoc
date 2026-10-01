using System.Collections.Generic;

namespace HospitalManagement
{
    public static class Session
    {
        public static string TenDangNhap { get; set; } = "";

        public static string VaiTro { get; set; } = "";

        public static string MaRole { get; set; } = "";

        public static List<string> Permissions { get; set; } = new List<string>();
    }
}