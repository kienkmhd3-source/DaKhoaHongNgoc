using HospitalManagement.DAL;
using HospitalManagement.DTO;
using System.Data;

namespace HospitalManagement.BLL
{
    public class KhoaBLL
    {
        KhoaDAL dal = new KhoaDAL();

        public DataTable GetDanhSachKhoa()
        {
            return dal.GetDanhSachKhoa();
        }

        public bool Insert(KhoaDTO k)
        {
            return dal.Insert(k);
        }

        public bool Update(KhoaDTO k)
        {
            return dal.Update(k);
        }

        public bool Delete(string maKhoa)
        {
            return dal.Delete(maKhoa);
        }

        public DataTable Search(string keyword)
        {
            return dal.Search(keyword);
        }

        public bool Exists(string maKhoa)
        {
            return dal.Exists(maKhoa);
        }
    }
}