using HospitalManagement.DAL;
using HospitalManagement.DTO;

namespace HospitalManagement.BLL
{
    public class PermissionBLL
    {
        PermissionDAL dal = new PermissionDAL();

        public List<PermissionDTO> GetPermissionsByRole(string maRole)
        {
            return dal.GetPermissionsByRole(maRole);
        }
    }
}