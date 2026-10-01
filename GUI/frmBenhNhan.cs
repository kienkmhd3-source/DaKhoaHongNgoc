using HospitalManagement.BLL;
using HospitalManagement.DTO;
using HospitalManagement.Utilities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HospitalManagement.GUI
{
    public partial class frmBenhNhan : Form
    {
        private BenhNhanBLL benhNhanBLL = new BenhNhanBLL();

        public frmBenhNhan()
        {
            InitializeComponent();

            LoadData();

            LoadBacSi();

            LoadGioiTinh();

            ClearText();
        }


        private void LoadData()
        {
            dgvBenhNhan.AutoGenerateColumns = false;

            dgvBenhNhan.DataSource = benhNhanBLL.GetDanhSachBenhNhan();
        }


        private void LoadBacSi()
        {
            cboBacSi.DataSource = benhNhanBLL.GetDanhSachBacSi();

            cboBacSi.DisplayMember = "HoTen";

            cboBacSi.ValueMember = "MaBS";

            cboBacSi.SelectedIndex = -1;
        }

        private void LoadGioiTinh()
        {
            cboGioiTinh.Items.Clear();

            cboGioiTinh.Items.Add("Nam");

            cboGioiTinh.Items.Add("Nữ");

            cboGioiTinh.SelectedIndex = -1;
        }


        private void ClearText()
        {
            txtMaBN.Clear();

            txtHoTen.Clear();

            txtCMND.Clear();

            txtDiaChi.Clear();

            txtBenhDaPhatHien.Clear();

            txtTimKiem.Clear();

            cboGioiTinh.SelectedIndex = -1;

            cboBacSi.SelectedIndex = -1;

            dtpNgaySinh.Value = DateTime.Today;

            dtpNgayDangKy.Value = DateTime.Today;

            txtMaBN.Focus();
        }


        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaBN.Text =
                    dgvBenhNhan.Rows[e.RowIndex].Cells["colMaBN"].Value?.ToString();

                txtHoTen.Text =
                    dgvBenhNhan.Rows[e.RowIndex].Cells["colHoTen"].Value?.ToString();

                txtCMND.Text =
                    dgvBenhNhan.Rows[e.RowIndex].Cells["colCMND"].Value?.ToString();

                cboGioiTinh.Text =
                    dgvBenhNhan.Rows[e.RowIndex].Cells["colGioiTinh"].Value?.ToString();

                dtpNgaySinh.Value =
                    Convert.ToDateTime(
                        dgvBenhNhan.Rows[e.RowIndex].Cells["colNgaySinh"].Value);

                txtDiaChi.Text =
                    dgvBenhNhan.Rows[e.RowIndex].Cells["colDiaChi"].Value?.ToString();

                dtpNgayDangKy.Value =
                    Convert.ToDateTime(
                        dgvBenhNhan.Rows[e.RowIndex].Cells["colNgayDangKy"].Value);

                txtBenhDaPhatHien.Text =
                    dgvBenhNhan.Rows[e.RowIndex].Cells["colBenh"].Value?.ToString();

                cboBacSi.SelectedValue =
                    dgvBenhNhan.Rows[e.RowIndex].Cells["colBacSi"].Value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaBN.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mã bệnh nhân!");
                txtMaBN.Focus();
                return;
            }

            if (benhNhanBLL.Exists(txtMaBN.Text.Trim()))
            {
                MessageBox.Show("Mã bệnh nhân đã tồn tại!");
                txtMaBN.Focus();
                return;
            }

            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return;
            }

            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập CCCD!");
                txtCMND.Focus();
                return;
            }

            if (!txtCMND.Text.All(char.IsDigit))
            {
                MessageBox.Show("CCCD chỉ được nhập số!");
                txtCMND.Focus();
                txtCMND.SelectAll();
                return;
            }

            if (txtCMND.Text.Length != 12)
            {
                MessageBox.Show("CCCD phải gồm đúng 12 chữ số!");
                txtCMND.Focus();
                txtCMND.SelectAll();
                return;
            }

            if (cboBacSi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ!");
                cboBacSi.Focus();
                return;
            }

            BenhNhanDTO bn = new BenhNhanDTO();

            bn.MaBN = txtMaBN.Text.Trim();
            bn.HoTen = txtHoTen.Text.Trim();
            bn.CMND = txtCMND.Text.Trim();
            bn.GioiTinh = cboGioiTinh.Text;
            bn.NgaySinh = dtpNgaySinh.Value;
            bn.DiaChi = txtDiaChi.Text.Trim();
            bn.NgayDangKy = dtpNgayDangKy.Value;
            bn.BenhDaPhatHien = txtBenhDaPhatHien.Text.Trim();
            bn.MaBS = cboBacSi.SelectedValue.ToString();

            if (benhNhanBLL.Insert(bn))
            {
                MessageBox.Show("Thêm thành công.");

                LoadData();

                ClearText();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaBN.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân!");
                return;
            }

            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập CCCD!");
                txtCMND.Focus();
                return;
            }

            if (!txtCMND.Text.All(char.IsDigit))
            {
                MessageBox.Show("CCCD chỉ được nhập số!");
                txtCMND.Focus();
                txtCMND.SelectAll();
                return;
            }

            if (txtCMND.Text.Length != 12)
            {
                MessageBox.Show("CCCD phải gồm đúng 12 chữ số!");
                txtCMND.Focus();
                txtCMND.SelectAll();
                return;
            }

            BenhNhanDTO bn = new BenhNhanDTO();

            bn.MaBN = txtMaBN.Text.Trim();
            bn.HoTen = txtHoTen.Text.Trim();
            bn.CMND = txtCMND.Text.Trim();
            bn.GioiTinh = cboGioiTinh.Text;
            bn.NgaySinh = dtpNgaySinh.Value;
            bn.DiaChi = txtDiaChi.Text.Trim();
            bn.NgayDangKy = dtpNgayDangKy.Value;
            bn.BenhDaPhatHien = txtBenhDaPhatHien.Text.Trim();
            bn.MaBS = cboBacSi.SelectedValue.ToString();

            if (benhNhanBLL.Update(bn))
            {
                MessageBox.Show("Sửa thành công.");

                LoadData();

                ClearText();
            }
            else
            {
                MessageBox.Show("Sửa thất bại.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBN.Text.Trim() == "")
                return;

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa bệnh nhân này?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.No)
                return;

            if (benhNhanBLL.Delete(txtMaBN.Text.Trim()))
            {
                MessageBox.Show("Đã xóa.");

                LoadData();

                ClearText();
            }
            else
            {
                MessageBox.Show("Xóa thất bại.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();

            ClearText();

            LoadData();

            txtMaBN.Focus();
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadData();
                return;
            }

            DataTable dt = benhNhanBLL.TimKiemBenhNhan(keyword);

            dgvBenhNhan.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Không tìm thấy bệnh nhân!",
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

            txtMaBN.Focus();
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

                txtMaBN.Focus();
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_Leave(object sender, EventArgs e)
        {
            if (txtCMND.Text.Trim() == "")
                return;

            if (!txtCMND.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "CCCD chỉ được nhập số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCMND.Focus();
                txtCMND.SelectAll();
                return;
            }

            if (txtCMND.Text.Length != 12)
            {
                MessageBox.Show(
                    "CCCD phải gồm đúng 12 chữ số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCMND.Focus();
                txtCMND.SelectAll();
            }
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgaySinh.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "Ngày sinh không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpNgaySinh.Value = DateTime.Today;
            }
        }

        private void dtpNgayDangKy_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayDangKy.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "Ngày đăng ký không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpNgayDangKy.Value = DateTime.Today;
            }
        }

        private void frmBenhNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có muốn đóng cửa sổ này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            if (!PermissionHelper.HasPermission("BENHNHAN"))
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo");
                this.Close();
                return;
            }
        }
    }
}