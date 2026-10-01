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
    public partial class frmKhamBenh : Form
    {
        private KhamBenhBLL bll = new KhamBenhBLL();
        public frmKhamBenh()
        {
            InitializeComponent();
        }

        private void frmKhamBenh_Load(object sender, EventArgs e)
        {

            if (!PermissionHelper.HasPermission("KHAMBENH"))
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo");
                this.Close();
                return;
            }
            LoadBenhNhan();
            LoadBacSi();
            LoadData();
            ClearText();

            dgvKhamBenh.ClearSelection();

            txtMaKham.Focus();
        }

        private void LoadBenhNhan()
        {
            cboBenhNhan.DataSource = bll.GetBenhNhan();

            cboBenhNhan.DisplayMember = "HoTen";

            cboBenhNhan.ValueMember = "MaBN";

            cboBenhNhan.SelectedIndex = -1;
        }

        private void LoadBacSi()
        {
            cboBacSi.DataSource = bll.GetBacSi();

            cboBacSi.DisplayMember = "HoTen";

            cboBacSi.ValueMember = "MaBS";

            cboBacSi.SelectedIndex = -1;
        }

        private void LoadData()
        {
            dgvKhamBenh.AutoGenerateColumns = false;
            dgvKhamBenh.DataSource = bll.GetDanhSachKhamBenh();
            dgvKhamBenh.ClearSelection();
        }

        private void ClearText()
        {
            txtMaKham.Clear();

            cboBenhNhan.SelectedIndex = -1;
            cboBacSi.SelectedIndex = -1;

            dtpThoiDiem.Value = DateTime.Now;

            rtbTrieuChung.Clear();
            rtbChanDoan.Clear();
            rtbDonThuoc.Clear();
            rtbKetLuan.Clear();

            txtTimKiem.Clear();

            dgvKhamBenh.ClearSelection();

            txtMaKham.Focus();
        }

        private void dgvKhamBenh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKhamBenh.Rows[e.RowIndex];

            txtMaKham.Text = Convert.ToString(row.Cells["colMaKham"].Value);

            cboBenhNhan.SelectedValue =
                Convert.ToString(row.Cells["colMaBN"].Value);

            cboBacSi.SelectedValue =
                Convert.ToString(row.Cells["colMaBS"].Value);

            if (row.Cells["colThoiDiemKham"].Value != DBNull.Value)
            {
                dtpThoiDiem.Value =
                    Convert.ToDateTime(row.Cells["colThoiDiemKham"].Value);
            }

            rtbTrieuChung.Text =
                Convert.ToString(row.Cells["colTrieuChung"].Value);

            rtbChanDoan.Text =
                Convert.ToString(row.Cells["colChanDoan"].Value);

            rtbDonThuoc.Text =
                Convert.ToString(row.Cells["colDonThuoc"].Value);

            rtbKetLuan.Text =
                Convert.ToString(row.Cells["colKetLuan"].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKham.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã khám!");
                txtMaKham.Focus();
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

            if (rtbChanDoan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Chẩn đoán!");
                rtbChanDoan.Focus();
                return;
            }

            if (bll.Exists(txtMaKham.Text.Trim()))
            {
                MessageBox.Show("Mã khám đã tồn tại!");
                txtMaKham.Focus();
                return;
            }

            KhamBenhDTO kb = new KhamBenhDTO();

            kb.MaKham = txtMaKham.Text.Trim();
            kb.MaBN = cboBenhNhan.SelectedValue.ToString()!;
            kb.MaBS = cboBacSi.SelectedValue.ToString()!;
            kb.ThoiDiemKham = dtpThoiDiem.Value;
            kb.TrieuChung = rtbTrieuChung.Text.Trim();
            kb.ChanDoan = rtbChanDoan.Text.Trim();
            kb.DonThuoc = rtbDonThuoc.Text.Trim();
            kb.KetLuan = rtbKetLuan.Text.Trim();

            if (bll.Insert(kb))
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
            if (txtMaKham.Text.Trim() == "")
            {
                MessageBox.Show("Chọn hồ sơ khám cần sửa.");
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

            KhamBenhDTO kb = new KhamBenhDTO();

            kb.MaKham = txtMaKham.Text.Trim();
            kb.MaBN = cboBenhNhan.SelectedValue.ToString()!;
            kb.MaBS = cboBacSi.SelectedValue.ToString()!;
            kb.ThoiDiemKham = dtpThoiDiem.Value;
            kb.TrieuChung = rtbTrieuChung.Text.Trim();
            kb.ChanDoan = rtbChanDoan.Text.Trim();
            kb.DonThuoc = rtbDonThuoc.Text.Trim();
            kb.KetLuan = rtbKetLuan.Text.Trim();

            if (bll.Update(kb))
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKham.Text.Trim() == "")
            {
                MessageBox.Show("Chọn hồ sơ khám cần xóa!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa hồ sơ khám này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                if (bll.Delete(txtMaKham.Text.Trim()))
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

                txtMaKham.Focus();
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
            dgvKhamBenh.DataSource =
        bll.Search(txtTimKiem.Text.Trim());

            if (dgvKhamBenh.Rows.Count == 0)
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

            txtMaKham.Focus();
        }
    }
}
