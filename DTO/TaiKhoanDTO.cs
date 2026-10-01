namespace HospitalManagement.DTO
{
    public class TaiKhoanDTO
    {
        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;
        public string VaiTro { get; set; } = string.Empty;
        public string MaRole { get; set; } = "";

        public TaiKhoanDTO()
        {
        }

        public TaiKhoanDTO(string tenDangNhap, string matKhau, string vaiTro)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            VaiTro = vaiTro;
        }
    }
}