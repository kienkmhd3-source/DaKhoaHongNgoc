using HospitalManagement.BLL;
using HospitalManagement.DTO;
using HospitalManagement.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.GUI
{
    public partial class frmNhanVien : Form
    {
        private NhanVienBLL nhanVienBLL = new NhanVienBLL();
        private void LoadData()
        {
            dgvNhanVien.AutoGenerateColumns = false;

            dgvNhanVien.DataSource = nhanVienBLL.GetDanhSachNhanVien();
        }
        private void LoadKhoa()
        {
            cboKhoa.DataSource = nhanVienBLL.GetDanhSachKhoa();

            cboKhoa.DisplayMember = "TenKhoa";

            cboKhoa.ValueMember = "MaKhoa";
        }
        public frmNhanVien()
        {
            InitializeComponent();
            LoadData();
            LoadKhoa();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaNV.Text =
                    dgvNhanVien.Rows[e.RowIndex].Cells["colMaNV"].Value?.ToString();

                txtHoTen.Text =
                    dgvNhanVien.Rows[e.RowIndex].Cells["colHoTen"].Value?.ToString();

                txtCMND.Text =
                    dgvNhanVien.Rows[e.RowIndex].Cells["colCMND"].Value?.ToString();

                cboGioiTinh.Text =
                    dgvNhanVien.Rows[e.RowIndex].Cells["colGioiTinh"].Value?.ToString();

                dtpNgaySinh.Value =
                    Convert.ToDateTime(
                        dgvNhanVien.Rows[e.RowIndex].Cells["colNgaySinh"].Value);

                txtDiaChi.Text =
                    dgvNhanVien.Rows[e.RowIndex].Cells["colDiaChi"].Value?.ToString();

                dtpNgayTuyenDung.Value =
                    Convert.ToDateTime(
                        dgvNhanVien.Rows[e.RowIndex].Cells["colNgayTuyenDung"].Value);

                txtChucDanh.Text =
                    dgvNhanVien.Rows[e.RowIndex].Cells["colChucDanh"].Value?.ToString();

                cboKhoa.SelectedValue =
                    dgvNhanVien.Rows[e.RowIndex].Cells["colMaKhoa"].Value;
            }
        }

        private void ClearText()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtCMND.Clear();
            txtDiaChi.Clear();
            txtChucDanh.Clear();

            cboGioiTinh.SelectedIndex = -1;
            cboKhoa.SelectedIndex = -1;

            dtpNgaySinh.Value = DateTime.Today;
            dtpNgayTuyenDung.Value = DateTime.Today;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mã nhân viên");
                txtMaNV.Focus();
                return;
            }

            if (nhanVienBLL.Exists(txtMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
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
                MessageBox.Show("Vui lòng nhập CMND!");
                txtCMND.Focus();
                return;
            }

            if (cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khoa!");
                cboKhoa.Focus();
                return;
            }

            NhanVienDTO nv = new NhanVienDTO();

            nv.MaNV = txtMaNV.Text.Trim();
            nv.HoTen = txtHoTen.Text.Trim();
            nv.CMND = txtCMND.Text.Trim();
            nv.GioiTinh = cboGioiTinh.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.NgayTuyenDung = dtpNgayTuyenDung.Value;
            nv.ChucDanh = txtChucDanh.Text.Trim();
            nv.MaKhoa = cboKhoa.SelectedValue.ToString();

            if (nhanVienBLL.Insert(nv))
            {
                MessageBox.Show("Thêm thành công");

                LoadData();

                ClearText();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
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

            if (txtCMND.Text.Trim().Length != 12)
            {
                MessageBox.Show("CCCD phải gồm đúng 12 chữ số!");
                txtCMND.Focus();
                txtCMND.SelectAll();
                return;
            }

            NhanVienDTO nv = new NhanVienDTO();

            nv.MaNV = txtMaNV.Text.Trim();
            nv.HoTen = txtHoTen.Text.Trim();
            nv.CMND = txtCMND.Text.Trim();
            nv.GioiTinh = cboGioiTinh.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.NgayTuyenDung = dtpNgayTuyenDung.Value;
            nv.ChucDanh = txtChucDanh.Text.Trim();
            nv.MaKhoa = cboKhoa.SelectedValue.ToString();

            if (nhanVienBLL.Update(nv))
            {
                MessageBox.Show("Sửa thành công");

                LoadData();

                ClearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
                return;

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa nhân viên này?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.No)
                return;

            if (nhanVienBLL.Delete(txtMaNV.Text.Trim()))
            {
                MessageBox.Show("Đã xóa");

                LoadData();

                ClearText();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();

            ClearText();

            LoadData();

            txtMaNV.Focus();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadData();
                return;
            }

            DataTable dt = nhanVienBLL.TimKiemNhanVien(keyword);

            dgvNhanVien.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên!");
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

            txtMaNV.Focus();
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

                txtMaNV.Focus();
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            if (!PermissionHelper.HasPermission("NHANVIEN"))
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo");
                this.Close();
                return;
            }
        }
    }
}

