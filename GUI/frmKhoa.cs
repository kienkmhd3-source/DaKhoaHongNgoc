using HospitalManagement.BLL;
using HospitalManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.Utilities;

namespace HospitalManagement.GUI
{
    public partial class frmKhoa : Form
    {
        private KhoaBLL khoaBLL = new KhoaBLL();
        private void LoadData()
        {
            dgvKhoa.AutoGenerateColumns = false;

            dgvKhoa.DataSource = khoaBLL.GetDanhSachKhoa();
        }

        private void ClearText()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtMoTa.Clear();

            txtMaKhoa.Focus();

            dgvKhoa.ClearSelection();
        }

        public frmKhoa()
        {

            InitializeComponent();

            LoadData();
        }


        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaKhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells["colMaKhoa"].Value?.ToString();
                txtTenKhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells["colTenKhoa"].Value?.ToString();
                txtMoTa.Text = dgvKhoa.Rows[e.RowIndex].Cells["colMoTa"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã khoa !");
                txtMaKhoa.Focus();
                return;
            }

            if (khoaBLL.Exists(txtMaKhoa.Text.Trim()))
            {
                MessageBox.Show("Mã khoa đã tồn tại!");

                txtMaKhoa.Focus();
                txtMaKhoa.SelectAll();

                return;
            }

            if (txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Tên khoa !");
                txtTenKhoa.Focus();
                return;
            }

            KhoaDTO k = new KhoaDTO();

            k.MaKhoa = txtMaKhoa.Text.Trim();
            k.TenKhoa = txtTenKhoa.Text.Trim();
            k.MoTa = txtMoTa.Text.Trim();

            if (khoaBLL.Insert(k))
            {
                MessageBox.Show("Thêm thành công");

                LoadData();
                ClearText();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "" || txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn khoa cần sửa!");
                return;
            }

            KhoaDTO k = new KhoaDTO
            {
                MaKhoa = txtMaKhoa.Text.Trim(),
                TenKhoa = txtTenKhoa.Text.Trim(),
                MoTa = txtMoTa.Text.Trim()
            };

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn cập nhật khoa này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (khoaBLL.Update(k))
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn khoa cần xóa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa khoa này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (khoaBLL.Delete(txtMaKhoa.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    LoadData();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = khoaBLL.Search(txtTimKiem.Text.Trim());
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearText();

            txtTimKiem.Clear();

            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dữ liệu đã được lưu.");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearText();
            dgvKhoa.ClearSelection();
            txtMaKhoa.Enabled = true;
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            if (!PermissionHelper.HasPermission("KHOA"))
            {
                MessageBox.Show(
                    "Bạn không có quyền truy cập chức năng này!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.Close();
                return;
            }
        }
    }
}
