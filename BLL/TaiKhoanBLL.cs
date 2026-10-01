using HospitalManagement.DAL;
using HospitalManagement.DTO;
using System.Data;

namespace HospitalManagement.BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL dal = new TaiKhoanDAL();

        public TaiKhoanDTO DangNhap(TaiKhoanDTO tk)
        {
            return dal.DangNhap(tk);
        }

        public DataTable GetDanhSachTaiKhoan()
        {
            return dal.GetDanhSachTaiKhoan();
        }

        public bool Exists(string tenDangNhap)
        {
            return dal.Exists(tenDangNhap);
        }

        public bool Insert(TaiKhoanDTO tk)
        {
            return dal.Insert(tk);
        }

        public bool Update(TaiKhoanDTO tk)
        {
            return dal.Update(tk);
        }

        public bool Delete(string tenDangNhap)
        {
            return dal.Delete(tenDangNhap);
        }

        public DataTable TimKiemTaiKhoan(string keyword)
        {
            return dal.TimKiemTaiKhoan(keyword);
        }
    }
}