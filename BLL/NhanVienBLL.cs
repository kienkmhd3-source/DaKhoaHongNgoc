using HospitalManagement.DAL;
using HospitalManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();
        public DataTable GetDanhSachNhanVien()
        {
            return nhanVienDAL.GetDanhSachNhanVien();
        }

        public DataTable GetDanhSachKhoa()
        {
            return nhanVienDAL.GetDanhSachKhoa();
        }

        public bool Exists(string maNV)
        {
            return nhanVienDAL.Exists(maNV);
        }

        public bool Insert(NhanVienDTO nv)
        {
            return nhanVienDAL.Insert(nv);
        }

        public bool Update(NhanVienDTO nv)
        {
            return nhanVienDAL.Update(nv);
        }

        public bool Delete(string maNV)
        {
            return nhanVienDAL.Delete(maNV);
        }

        public DataTable TimKiemNhanVien(string keyword)
        {
            return nhanVienDAL.TimKiemNhanVien(keyword);
        }
    }
}
