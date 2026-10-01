using HospitalManagement.BLL;
using HospitalManagement.DTO;
using HospitalManagement.Utilities;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagement.GUI
{
    public partial class frmGiuong : Form
    {
        private GiuongBLL giuongBLL = new GiuongBLL();

        public frmGiuong()
        {
            InitializeComponent();
        }

        private void frmGiuong_Load(object sender, EventArgs e)
        {

            if (!PermissionHelper.HasPermission("GIUONG"))
            {
                MessageBox.Show(
                    "Bạn không có quyền truy cập chức năng này!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.Close();
                return;
            }
            LoadPhong();
            LoadTrangThai();
            LoadData();
            ClearText();
            dgvGiuong.ClearSelection();

            txtMaGiuong.Focus();
        }


        private void LoadData()
        {
            dgvGiuong.AutoGenerateColumns = false;
            dgvGiuong.DataSource = giuongBLL.GetDanhSachGiuong();
            dgvGiuong.ClearSelection();
        }


        private void LoadPhong()
        {
            cboPhong.DataSource = giuongBLL.GetDanhSachPhong();
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
            cboPhong.SelectedIndex = -1;
        }


        private void LoadTrangThai()
        {
            cboTrangThai.SelectedIndex = -1;
        }


        private void ClearText()
        {
            txtMaGiuong.Clear();
            txtSoGiuong.Clear();

            cboTrangThai.SelectedIndex = -1;
            cboPhong.SelectedIndex = -1;

            txtTimKiem.Clear();
            dgvGiuong.ClearSelection();
            txtMaGiuong.Focus();
        }


        private void dgvGiuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaGiuong.Text =
                    dgvGiuong.Rows[e.RowIndex].Cells["colMaGiuong"].Value.ToString();

                txtSoGiuong.Text =
                    dgvGiuong.Rows[e.RowIndex].Cells["colSoGiuong"].Value.ToString();

                cboTrangThai.Text =
                    dgvGiuong.Rows[e.RowIndex].Cells["colTrangThai"].Value.ToString();

                cboPhong.SelectedValue =
                    dgvGiuong.Rows[e.RowIndex].Cells["colMaPhong"].Value.ToString();
            }
        }


        private void txtSoGiuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaGiuong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã giường!");
                txtMaGiuong.Focus();
                return;
            }

            if (txtSoGiuong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Số giường!");
                txtSoGiuong.Focus();
                return;
            }

            if (cboTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Trạng thái!");
                cboTrangThai.Focus();
                return;
            }

            if (giuongBLL.Exists(txtMaGiuong.Text.Trim()))
            {
                MessageBox.Show("Mã giường đã tồn tại!");
                txtMaGiuong.Focus();
                return;
            }

            GiuongDTO g = new GiuongDTO();

            g.MaGiuong = txtMaGiuong.Text.Trim();
            g.SoGiuong = txtSoGiuong.Text.Trim();
            g.TrangThai = cboTrangThai.Text;

            if (cboPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng!");
                cboPhong.Focus();
                return;
            }

            g.MaPhong = cboPhong.SelectedValue.ToString()!;

            if (giuongBLL.Insert(g))
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaGiuong.Text.Trim() == "")
            {
                MessageBox.Show("Chọn dữ liệu cần sửa.");
                return;
            }

            GiuongDTO g = new GiuongDTO();

            g.MaGiuong = txtMaGiuong.Text.Trim();
            g.SoGiuong = txtSoGiuong.Text.Trim();
            g.TrangThai = cboTrangThai.Text;
            g.MaPhong = cboPhong.SelectedValue.ToString();

            if (giuongBLL.Update(g))
            {
                MessageBox.Show("Sửa thành công.");

                LoadData();

                ClearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaGiuong.Text.Trim() == "")
            {
                MessageBox.Show("Chọn giường cần xóa!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa giường này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                if (giuongBLL.Delete(txtMaGiuong.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công!");

                    LoadData();

                    ClearText();
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

                txtMaGiuong.Focus();
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvGiuong.DataSource =
            giuongBLL.TimKiem(txtTimKiem.Text.Trim());

            if (dgvGiuong.Rows.Count == 0)
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

            txtMaGiuong.Focus();
        }
    }
}