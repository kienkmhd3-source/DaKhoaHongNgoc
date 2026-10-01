using System;

namespace HospitalManagement.DTO
{
    public class BenhNhanDTO
    {
        public string MaBN { get; set; } = string.Empty;

        public string HoTen { get; set; } = string.Empty;

        public string CMND { get; set; } = string.Empty;

        public string GioiTinh { get; set; } = string.Empty;

        public DateTime NgaySinh { get; set; }

        public string DiaChi { get; set; } = string.Empty;

        public DateTime NgayDangKy { get; set; }

        public string BenhDaPhatHien { get; set; } = string.Empty;

        public string MaBS { get; set; } = string.Empty;
    }
}