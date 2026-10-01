using HospitalManagement.BLL;
using HospitalManagement.DTO;
using HospitalManagement.Utilities;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagement.GUI
{
    public partial class frmTaiKhoan : Form
    {
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgvTaiKhoan.AutoGenerateColumns = false;

            dgvTaiKhoan.DataSource = taiKhoanBLL.GetDanhSachTaiKhoan();
        }
        private void LoadVaiTro()
        {
            cboVaiTro.Items.Clear();

            cboVaiTro.Items.Add("Quản trị");

            cboVaiTro.Items.Add("Bác sĩ");

            cboVaiTro.Items.Add("Nhân viên");

            cboVaiTro.SelectedIndex = -1;
        }
        private void ClearText()
        {
            txtTenDangNhap.Clear();

            txtMatKhau.Clear();

            cboVaiTro.SelectedIndex = -1;

            txtTenDangNhap.Focus();

            txtTenDangNhap.Enabled = true;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenDangNhap.Text =
                    dgvTaiKhoan.Rows[e.RowIndex].Cells["colTenDangNhap"].Value?.ToString();

                txtMatKhau.Text =
                    dgvTaiKhoan.Rows[e.RowIndex].Cells["colMatKhau"].Value?.ToString();

                cboVaiTro.Text =
                    dgvTaiKhoan.Rows[e.RowIndex].Cells["colVaiTro"].Value?.ToString();

                txtTenDangNhap.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên đăng nhập!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenDangNhap.Focus();
                return;
            }

            if (taiKhoanBLL.Exists(txtTenDangNhap.Text.Trim()))
            {
                MessageBox.Show(
                    "Tên đăng nhập đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenDangNhap.Focus();
                txtTenDangNhap.SelectAll();
                return;
            }

            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập mật khẩu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMatKhau.Focus();
                return;
            }

            if (cboVaiTro.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn vai trò!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboVaiTro.Focus();
                return;
            }

            TaiKhoanDTO tk = new TaiKhoanDTO();

            tk.TenDangNhap = txtTenDangNhap.Text.Trim();
            tk.MatKhau = txtMatKhau.Text.Trim();
            tk.VaiTro = cboVaiTro.Text;

            if (taiKhoanBLL.Insert(tk))
            {
                MessageBox.Show(
                    "Thêm tài khoản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();

                ClearText();
            }
            else
            {
                MessageBox.Show(
                    "Không thể thêm tài khoản!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn tài khoản cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Mật khẩu không được để trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMatKhau.Focus();
                return;
            }

            if (cboVaiTro.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn vai trò!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboVaiTro.Focus();
                return;
            }

            TaiKhoanDTO tk = new TaiKhoanDTO();

            tk.TenDangNhap = txtTenDangNhap.Text.Trim();
            tk.MatKhau = txtMatKhau.Text.Trim();
            tk.VaiTro = cboVaiTro.Text;

            if (taiKhoanBLL.Update(tk))
            {
                MessageBox.Show(
                    "Cập nhật tài khoản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();

                ClearText();
            }
            else
            {
                MessageBox.Show(
                    "Không thể cập nhật tài khoản!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn tài khoản cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa tài khoản này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.No)
                return;

            if (taiKhoanBLL.Delete(txtTenDangNhap.Text.Trim()))
            {
                MessageBox.Show(
                    "Xóa tài khoản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();

                ClearText();
            }
            else
            {
                MessageBox.Show(
                    "Không thể xóa tài khoản!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();

            ClearText();

            LoadData();

            txtTenDangNhap.Focus();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadData();
                return;
            }

            DataTable dt = taiKhoanBLL.TimKiemTaiKhoan(keyword);

            dgvTaiKhoan.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Không tìm thấy tài khoản!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LoadData();

            ClearText();

            MessageBox.Show(
                "Dữ liệu đã được cập nhật!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtTenDangNhap.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có muốn hủy thao tác hiện tại không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                ClearText();

                txtTimKiem.Clear();

                LoadData();

                txtTenDangNhap.Focus();
            }
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            if (!PermissionHelper.HasPermission("TAIKHOAN"))
            {
                MessageBox.Show(
                    "Bạn không có quyền truy cập chức năng này!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.Close();
                return;
            }

            LoadData();

            LoadVaiTro();

            ClearText();
        }
    }
}
