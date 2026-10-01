using HospitalManagement.DAL;
using HospitalManagement.DTO;
using System.Data;

namespace HospitalManagement.BLL
{
    public class KhamBenhBLL
    {
        KhamBenhDAL dal = new KhamBenhDAL();

        public DataTable GetDanhSachKhamBenh()
        {
            return dal.GetDanhSachKhamBenh();
        }

        public DataTable GetBenhNhan()
        {
            return dal.GetBenhNhan();
        }

        public DataTable GetBacSi()
        {
            return dal.GetBacSi();
        }

        public bool Exists(string maKham)
        {
            return dal.Exists(maKham);
        }

        public bool Insert(KhamBenhDTO kb)
        {
            return dal.Insert(kb);
        }

        public bool Update(KhamBenhDTO kb)
        {
            return dal.Update(kb);
        }

        public bool Delete(string maKham)
        {
            return dal.Delete(maKham);
        }

        public DataTable Search(string keyword)
        {
            return dal.Search(keyword);
        }
    }
}