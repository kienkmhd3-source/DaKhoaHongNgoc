using HospitalManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.BLL
{

   public class BacSiBLL
    {
        BacSiDAL dal = new BacSiDAL();
        public DataTable GetDanhSachBacSi()
        {
            return dal.GetDanhSachBacSi();
        }

        public DataTable GetNhanVien()
        {
            return dal.GetNhanVien();
        }

        public bool Exists(string maBS)
        {
            return dal.Exists(maBS);
        }

        public bool Insert(BacSiDTO bs)
        {
            return dal.Insert(bs);
        }

        public bool Update(BacSiDTO bs)
        {
            return dal.Update(bs);
        }

        public bool Delete(string maBS)
        {
            return dal.Delete(maBS);
        }

        public DataTable Search(string keyword)
        {
            return dal.Search(keyword);
        }
    }
}
