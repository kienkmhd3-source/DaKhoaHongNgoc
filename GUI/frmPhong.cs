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
    public partial class frmPhong : Form
    {

        private PhongBLL phongBLL = new PhongBLL();
        private KhoaBLL khoaBLL = new KhoaBLL();

        private void LoadData()
        {
            dgvPhong.AutoGenerateColumns = false;

            dgvPhong.DataSource = phongBLL.GetDanhSachPhong();
        }

        private void ClearText()
        {
            txtMaPhong.Clear();
            txtSoPhong.Clear();
            txtTenPhong.Clear();

            if (cboKhoa.Items.Count > 0)
                cboKhoa.SelectedIndex = 0;

            txtMaPhong.Focus();
        }

        private void LoadKhoa()
        {
            cboKhoa.DataSource = khoaBLL.GetDanhSachKhoa();

            cboKhoa.DisplayMember = "TenKhoa";

            cboKhoa.ValueMember = "MaKhoa";
        }

        public frmPhong()
        {
            InitializeComponent();

            LoadData();
            LoadKhoa();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaPhong.Text =
                    dgvPhong.Rows[e.RowIndex].Cells["colMaPhong"].Value.ToString();

                txtSoPhong.Text =
                    dgvPhong.Rows[e.RowIndex].Cells["colSoPhong"].Value.ToString();

                txtTenPhong.Text =
                    dgvPhong.Rows[e.RowIndex].Cells["colTenPhong"].Value.ToString();

                cboKhoa.Text =
                    dgvPhong.Rows[e.RowIndex].Cells["colTenKhoa"].Value.ToString();

                txtMaPhong.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã phòng!");
                txtMaPhong.Focus();
                return;
            }

            if (txtSoPhong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Số phòng!");
                txtSoPhong.Focus();
                return;
            }

            if (txtTenPhong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Tên phòng!");
                txtTenPhong.Focus();
                return;
            }

            if (phongBLL.Exists(txtMaPhong.Text.Trim()))
            {
                MessageBox.Show("Mã phòng đã tồn tại!");
                txtMaPhong.Focus();
                return;
            }

            PhongDTO p = new PhongDTO();

            p.MaPhong = txtMaPhong.Text.Trim();
            p.SoPhong = int.Parse(txtSoPhong.Text.Trim());
            p.TenPhong = txtTenPhong.Text.Trim();

            if (cboKhoa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khoa!");
                return;
            }

            p.MaKhoa = cboKhoa.SelectedValue.ToString()!;

            if (phongBLL.Insert(p))
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
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
                return;
            }

            if (txtSoPhong.Text.Trim() == "" ||
                txtTenPhong.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống thông tin!");
                return;
            }

            if (!int.TryParse(txtSoPhong.Text.Trim(), out int soPhong))
            {
                MessageBox.Show("Số phòng phải là số!");
                txtSoPhong.Focus();
                return;
            }

            PhongDTO p = new PhongDTO();

            p.MaPhong = txtMaPhong.Text.Trim();
            p.SoPhong = soPhong;
            p.TenPhong = txtTenPhong.Text.Trim();
            p.MaKhoa = cboKhoa.SelectedValue.ToString();

            if (phongBLL.Update(p))
            {
                MessageBox.Show("Cập nhật thành công!");

                LoadData();
                ClearText();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearText();

            txtMaPhong.Enabled = true;

            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvPhong.DataSource = phongBLL.Search(txtTimKiem.Text.Trim());
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim.PerformClick();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phòng này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            if (phongBLL.Delete(txtMaPhong.Text.Trim()))
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

        private void frmPhong_Load(object sender, EventArgs e)
        {
            if (!PermissionHelper.HasPermission("PHONG"))
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo");
                this.Close();
                return;
            }
        }
    }
}
