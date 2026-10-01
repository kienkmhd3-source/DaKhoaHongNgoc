using System.Windows.Forms;

namespace HospitalManagement.Utilities
{
    public static class ButtonPermission
    {
        public static void DisableButtons(params Button[] buttons)
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = false;
            }
        }

        public static void HideButtons(params Button[] buttons)
        {
            foreach (Button btn in buttons)
            {
                btn.Visible = false;
            }
        }
    }
}