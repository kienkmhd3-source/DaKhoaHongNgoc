using HospitalManagement.BLL;
using HospitalManagement.DTO;
using HospitalManagement.Utilities;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagement.GUI
{
    public partial class frmNhapVien : Form
    {
        private NhapVienBLL nhapVienBLL = new NhapVienBLL();
        public frmNhapVien()
        {
            InitializeComponent();
        }
        private void frmNhapVien_Load(object sender, EventArgs e)
        {

            if (!PermissionHelper.HasPermission("NHAPVIEN"))
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo");
                this.Close();
                return;
            }

            LoadBenhNhan();
            LoadBacSi();
            LoadKhamBenh();
            LoadGiuong();

            LoadData();

            ClearText();

            dgvNhapVien.ClearSelection();

            txtMaNhapVien.Focus();
        }

        private void LoadData()
        {
            dgvNhapVien.AutoGenerateColumns = false;

            dgvNhapVien.DataSource =
                nhapVienBLL.GetDanhSachNhapVien();

            dgvNhapVien.ClearSelection();
        }

        private void LoadBenhNhan()
        {
            cboBenhNhan.DataSource =
                nhapVienBLL.GetDanhSachBenhNhan();

            cboBenhNhan.DisplayMember = "HoTen";

            cboBenhNhan.ValueMember = "MaBN";

            cboBenhNhan.SelectedIndex = -1;
        }

        private void LoadBacSi()
        {
            cboBacSi.DataSource =
                nhapVienBLL.GetDanhSachBacSi();

            cboBacSi.DisplayMember = "HoTen";

            cboBacSi.ValueMember = "MaBS";

            cboBacSi.SelectedIndex = -1;
        }

        private void LoadKhamBenh()
        {
            cboKhamBenh.DataSource =
                nhapVienBLL.GetDanhSachKhamBenh();

            cboKhamBenh.DisplayMember = "MaKham";

            cboKhamBenh.ValueMember = "MaKham";

            cboKhamBenh.SelectedIndex = -1;
        }

        private void LoadGiuong(string maGiuongHienTai = null)
        {
            cboGiuong.DataSource = nhapVienBLL.GetDanhSachGiuong(maGiuongHienTai);

            cboGiuong.DisplayMember = "HienThi";

            cboGiuong.ValueMember = "MaGiuong";

            cboGiuong.SelectedIndex = -1;
        }

        private void ClearText()
        {
            txtMaNhapVien.Clear();

            cboBenhNhan.SelectedIndex = -1;

            cboBacSi.SelectedIndex = -1;

            cboKhamBenh.SelectedIndex = -1;

            LoadGiuong();          // reset lại danh sách chỉ gồm giường Trống
            cboGiuong.SelectedIndex = -1;

            dtpNgayNhan.Value = DateTime.Now;

            dtpNgayTra.Value = DateTime.Now;

            dtpNgayTra.Checked = false;

            txtTimKiem.Clear();

            dgvNhapVien.ClearSelection();

            txtMaNhapVien.Focus();
        }

        private void dgvNhapVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhapVien.Rows[e.RowIndex];

            txtMaNhapVien.Text = row.Cells["colMaNhapVien"].Value?.ToString();

            cboBenhNhan.SelectedValue = row.Cells["colMaBN"].Value?.ToString();

            cboBacSi.SelectedValue = row.Cells["colMaBS"].Value?.ToString();

            cboKhamBenh.SelectedValue = row.Cells["colMaKham"].Value?.ToString();

            // Load lại danh sách giường, bao gồm giường hiện tại của dòng này
            string maGiuongHienTai = row.Cells["colMaGiuong"].Value?.ToString();
            LoadGiuong(maGiuongHienTai);
            cboGiuong.SelectedValue = maGiuongHienTai;

            if (row.Cells["colNgayNhan"].Value != DBNull.Value)
                dtpNgayNhan.Value = Convert.ToDateTime(row.Cells["colNgayNhan"].Value);

            if (row.Cells["colNgayTra"].Value != DBNull.Value)
            {
                dtpNgayTra.Checked = true;
                dtpNgayTra.Value = Convert.ToDateTime(row.Cells["colNgayTra"].Value);
            }
            else
            {
                dtpNgayTra.Checked = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhapVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã nhập viện!");
                txtMaNhapVien.Focus();
                return;
            }

            if (cboBenhNhan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Bệnh nhân!");
                cboBenhNhan.Focus();
                return;
            }

            if (cboBacSi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Bác sĩ!");
                cboBacSi.Focus();
                return;
            }

            if (cboKhamBenh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Phiếu khám!");
                cboKhamBenh.Focus();
                return;
            }

            if (cboGiuong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Giường!");
                cboGiuong.Focus();
                return;
            }

            if (dtpNgayTra.Checked && dtpNgayTra.Value < dtpNgayNhan.Value)
            {
                MessageBox.Show("Ngày trả không được nhỏ hơn Ngày nhận!");
                dtpNgayTra.Focus();
                return;
            }

            if (nhapVienBLL.Exists(txtMaNhapVien.Text.Trim()))
            {
                MessageBox.Show("Mã nhập viện đã tồn tại!");
                txtMaNhapVien.Focus();
                return;
            }

            NhapVienDTO nv = new NhapVienDTO();

            nv.MaNhapVien = txtMaNhapVien.Text.Trim();
            nv.MaBN = cboBenhNhan.SelectedValue.ToString()!;
            nv.MaBS = cboBacSi.SelectedValue.ToString()!;
            nv.MaKham = cboKhamBenh.SelectedValue.ToString()!;
            nv.MaGiuong = cboGiuong.SelectedValue.ToString()!;
            nv.NgayNhan = dtpNgayNhan.Value;
            nv.NgayTra = dtpNgayTra.Checked ? dtpNgayTra.Value : (DateTime?)null;

            if (nhapVienBLL.Insert(nv))
            {
                MessageBox.Show("Thêm thành công!");

                LoadData();

                ClearText();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhapVien.Text.Trim() == "")
            {
                MessageBox.Show("Chọn phiếu nhập viện cần xóa!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa phiếu nhập viện này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                if (nhapVienBLL.Delete(txtMaNhapVien.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công!");

                    LoadData();

                    ClearText();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
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

                txtMaNhapVien.Focus();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();

            ClearText();

            MessageBox.Show(
                "Đã làm mới dữ liệu.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvNhapVien.DataSource =
            nhapVienBLL.TimKiem(txtTimKiem.Text.Trim());

            if (dgvNhapVien.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Không tìm thấy dữ liệu.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
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

            txtMaNhapVien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhapVien.Text.Trim() == "")
            {
                MessageBox.Show("Chọn phiếu nhập viện cần sửa.");
                return;
            }

            if (cboBenhNhan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Bệnh nhân!");
                return;
            }

            if (cboBacSi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Bác sĩ!");
                return;
            }

            if (cboKhamBenh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Phiếu khám!");
                return;
            }

            if (cboGiuong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Giường!");
                return;
            }

            if (dtpNgayTra.Checked && dtpNgayTra.Value < dtpNgayNhan.Value)
            {
                MessageBox.Show("Ngày trả không được nhỏ hơn Ngày nhận!");
                return;
            }

            NhapVienDTO nv = new NhapVienDTO();

            nv.MaNhapVien = txtMaNhapVien.Text.Trim();
            nv.MaBN = cboBenhNhan.SelectedValue.ToString()!;
            nv.MaBS = cboBacSi.SelectedValue.ToString()!;
            nv.MaKham = cboKhamBenh.SelectedValue.ToString()!;
            nv.MaGiuong = cboGiuong.SelectedValue.ToString()!;
            nv.NgayNhan = dtpNgayNhan.Value;
            nv.NgayTra = dtpNgayTra.Checked ? dtpNgayTra.Value : (DateTime?)null;

            if (nhapVienBLL.Update(nv))
            {
                MessageBox.Show("Sửa thành công.");

                LoadData();

                ClearText();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }
    }
}
