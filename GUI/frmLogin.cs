using HospitalManagement.BLL;
using HospitalManagement.DTO;
using HospitalManagement.GUI;

namespace HospitalManagement
{
    public partial class frmLogin : Form
    {
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        private PermissionBLL permissionBLL = new PermissionBLL();
        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            this.CancelButton = btnExit;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO
            {
                TenDangNhap = txtUser.Text.Trim(),
                MatKhau = txtPass.Text.Trim()
            };

            TaiKhoanDTO user = taiKhoanBLL.DangNhap(tk);

            if (user != null)
            {
                Session.TenDangNhap = user.TenDangNhap;
                Session.VaiTro = user.VaiTro;
                Session.MaRole = user.MaRole;

                Session.Permissions.Clear();

                var permissions = permissionBLL.GetPermissionsByRole(user.MaRole);

                foreach (PermissionDTO p in permissions)
                {
                    Session.Permissions.Add(p.MaPermission);
                }

                MessageBox.Show(
                    "Đăng nhập thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Hide();

                frmMain f = new frmMain();

                f.LoginForm = this;

                f.Show();
            }
            else
            {
                MessageBox.Show(
                    "Sai tên đăng nhập hoặc mật khẩu!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPass.Clear();
                txtPass.Focus();
            }
        }
        public void ResetLogin()
        {
            txtUser.Clear();
            txtPass.Clear();

            txtUser.Focus();
            txtUser.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
