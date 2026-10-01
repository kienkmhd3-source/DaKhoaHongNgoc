using HospitalManagement.DAL;
using HospitalManagement.DTO;
using System.Data;

namespace HospitalManagement.BLL
{
    public class PhongBLL
    {
        PhongDAL dal = new PhongDAL();

        public DataTable GetDanhSachPhong()
        {
            return dal.GetDanhSachPhong();
        }
        public bool Exists(string maPhong)
        {
            return dal.Exists(maPhong);
        }

        public bool Insert(PhongDTO p)
        {
            return dal.Insert(p);
        }

        public bool Update(PhongDTO p)
        {
            return dal.Update(p);
        }

        public bool Delete(string maPhong)
        {
            return dal.Delete(maPhong);
        }

        public DataTable Search(string keyword)
        {
            return dal.Search(keyword);
        }
    }
}