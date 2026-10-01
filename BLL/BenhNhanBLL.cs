using HospitalManagement.DAL;
using HospitalManagement.DTO;
using System.Data;

namespace HospitalManagement.BLL
{
    public class BenhNhanBLL
    {
        private BenhNhanDAL benhNhanDAL = new BenhNhanDAL();

        public DataTable GetDanhSachBenhNhan()
        {
            return benhNhanDAL.GetDanhSachBenhNhan();
        }


        public DataTable GetDanhSachBacSi()
        {
            return benhNhanDAL.GetDanhSachBacSi();
        }

        public bool Exists(string maBN)
        {
            return benhNhanDAL.Exists(maBN);
        }

     
        public bool KiemTraTrungCCCD(string cmnd)
        {
            return benhNhanDAL.KiemTraTrungCCCD(cmnd);
        }

        public bool Insert(BenhNhanDTO bn)
        {
            return benhNhanDAL.Insert(bn);
        }

        public bool Update(BenhNhanDTO bn)
        {
            return benhNhanDAL.Update(bn);
        }

        public bool Delete(string maBN)
        {
            return benhNhanDAL.Delete(maBN);
        }

        public DataTable TimKiemBenhNhan(string keyword)
        {
            return benhNhanDAL.TimKiemBenhNhan(keyword);
        }
    }
}