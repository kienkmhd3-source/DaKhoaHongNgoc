using HospitalManagement.DAL;
using HospitalManagement.DTO;
using System.Data;

namespace HospitalManagement.BLL
{
    public class GiuongBLL
    {
        private GiuongDAL dal = new GiuongDAL();
        public DataTable GetDanhSachGiuong()
        {
            return dal.GetDanhSachGiuong();
        }

        public DataTable GetDanhSachPhong()
        {
            return dal.GetDanhSachPhong();
        }

        public bool Exists(string maGiuong)
        {
            return dal.Exists(maGiuong);
        }

        public bool Insert(GiuongDTO g)
        {
            return dal.Insert(g);
        }

        public bool Update(GiuongDTO g)
        {
            return dal.Update(g);
        }

        public bool Delete(string maGiuong)
        {
            return dal.Delete(maGiuong);
        }

        public DataTable TimKiem(string keyword)
        {
            return dal.TimKiemGiuong(keyword);
        }
    }
}