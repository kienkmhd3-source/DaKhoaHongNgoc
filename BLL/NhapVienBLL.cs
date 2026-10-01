using HospitalManagement.DAL;
using HospitalManagement.DTO;
using System.Data;

namespace HospitalManagement.BLL
{
    public class NhapVienBLL
    {
        private NhapVienDAL dal = new NhapVienDAL();

        // ================= DANH SÁCH =================

        public DataTable GetDanhSachNhapVien()
        {
            return dal.GetDanhSachNhapVien();
        }

        public DataTable GetDanhSachBenhNhan()
        {
            return dal.GetDanhSachBenhNhan();
        }

        public DataTable GetDanhSachBacSi()
        {
            return dal.GetDanhSachBacSi();
        }

        public DataTable GetDanhSachKhamBenh()
        {
            return dal.GetDanhSachKhamBenh();
        }

        public DataTable GetDanhSachGiuong(string maGiuongHienTai = null)
        {
            return dal.GetDanhSachGiuong(maGiuongHienTai);
        }


        // ================= KIỂM TRA =================

        public bool Exists(string maNhapVien)
        {
            return dal.Exists(maNhapVien);
        }

        // ================= THÊM =================

        public bool Insert(NhapVienDTO nv)
        {
            return dal.Insert(nv);
        }

        // ================= SỬA =================

        public bool Update(NhapVienDTO nv)
        {
            return dal.Update(nv);
        }

        // ================= XÓA =================

        public bool Delete(string maNhapVien)
        {
            return dal.Delete(maNhapVien);
        }

        // ================= TÌM KIẾM =================

        public DataTable TimKiem(string keyword)
        {
            return dal.Search(keyword);
        }
    }
}