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
    public partial class frmBacSi : Form
    {
        private BacSiBLL bacSiBLL = new BacSiBLL();

        private void LoadData()
        {
            dgvBacSi.AutoGenerateColumns = false;

            dgvBacSi.DataSource = bacSiBLL.GetDanhSachBacSi();
        }

        private void LoadNhanVien()
        {
            cboNhanVien.DataSource = bacSiBLL.GetNhanVien();

            cboNhanVien.DisplayMember = "HoTen";

            cboNhanVien.ValueMember = "MaNV";
        }

        private void ClearText()
        {
            txtMaBS.Clear();
            txtChuyenNganh.Clear();
            txtKyNang.Clear();
            txtLichLamViec.Clear();

            if (cboNhanVien.Items.Count > 0)
                cboNhanVien.SelectedIndex = 0;

            txtMaBS.Enabled = true;
            txtMaBS.Focus();
        }

        public frmBacSi()
        {
            InitializeComponent();
            LoadNhanVien();
            LoadData();
        }

        private void dgvBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaBS.Text = dgvBacSi.Rows[e.RowIndex].Cells["colMaBS"].Value?.ToString();
                txtChuyenNganh.Text = dgvBacSi.Rows[e.RowIndex].Cells["colChuyenNganh"].Value?.ToString();
                txtKyNang.Text = dgvBacSi.Rows[e.RowIndex].Cells["colKyNang"].Value?.ToString();
                txtLichLamViec.Text = dgvBacSi.Rows[e.RowIndex].Cells["colLichLamViec"].Value?.ToString();
                cboNhanVien.SelectedValue =
                    dgvBacSi.Rows[e.RowIndex].Cells["colMaNV"].Value;
                txtMaBS.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaBS.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã bác sĩ!");
                txtMaBS.Focus();
                return;
            }

            if (txtChuyenNganh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Chuyên ngành!");
                txtChuyenNganh.Focus();
                return;
            }

            if (bacSiBLL.Exists(txtMaBS.Text.Trim()))
            {
                MessageBox.Show("Mã bác sĩ đã tồn tại!");
                txtMaBS.Focus();
                return;
            }

            BacSiDTO bs = new BacSiDTO();

            bs.MaBS = txtMaBS.Text.Trim();
            bs.MaNV = cboNhanVien.SelectedValue.ToString();
            bs.ChuyenNganh = txtChuyenNganh.Text.Trim();
            bs.KyNang = txtKyNang.Text.Trim();
            bs.LichLamViec = txtLichLamViec.Text.Trim();

            if (bacSiBLL.Insert(bs))
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
            if (txtMaBS.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn bác sĩ cần sửa!");
                return;
            }

            BacSiDTO bs = new BacSiDTO();

            bs.MaBS = txtMaBS.Text.Trim();
            bs.MaNV = cboNhanVien.SelectedValue.ToString();
            bs.ChuyenNganh = txtChuyenNganh.Text.Trim();
            bs.KyNang = txtKyNang.Text.Trim();
            bs.LichLamViec = txtLichLamViec.Text.Trim();

            if (bacSiBLL.Update(bs))
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBS.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn bác sĩ cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa bác sĩ này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            if (bacSiBLL.Delete(txtMaBS.Text.Trim()))
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearText();
            LoadData();
            txtMaBS.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvBacSi.DataSource =
            bacSiBLL.Search(txtTimKiem.Text.Trim());
        }

        private void frmBacSi_Load(object sender, EventArgs e)
        {
            if (!PermissionHelper.HasPermission("BACSI"))
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo");
                this.Close();
                return;
            }
        }
    }
}
