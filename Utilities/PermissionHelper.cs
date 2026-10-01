namespace HospitalManagement.Utilities
{
    public static class PermissionHelper
    {
        public static bool HasPermission(string permission)
        {
            return Session.Permissions.Contains(permission);
        }
    }
}