using HospitalManagement.BLL;
using HospitalManagement.Utilities;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagement.GUI
{
    public partial class frmThongKe : Form
    {
        private readonly ThongKeBLL thongKeBLL = new ThongKeBLL();

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            KhoiTaoBoLoc();

            LoadTongQuan();

            LoadDashboard();

            FormatGrid();
        }

        private void KhoiTaoBoLoc()
        {
            cboLoaiThongKe.Items.Clear();

            cboLoaiThongKe.Items.Add("Tất cả");
            cboLoaiThongKe.Items.Add("Bệnh nhân");
            cboLoaiThongKe.Items.Add("Khám bệnh");
            cboLoaiThongKe.Items.Add("Nhập viện");
            cboLoaiThongKe.Items.Add("Bác sĩ");
            cboLoaiThongKe.Items.Add("Giường");
            cboLoaiThongKe.Items.Add("Phòng");
            cboLoaiThongKe.Items.Add("Khoa");

            cboLoaiThongKe.SelectedIndex = 0;

            cboLoaiThongKe.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpTuNgay.Value = new DateTime(DateTime.Now.Year,
                                           DateTime.Now.Month,
                                           1);

            dtpDenNgay.Value = DateTime.Now;
        }

        private void LoadTongQuan()
        {
            lblTongBenhNhan.Text =
                thongKeBLL.TongBenhNhan().ToString();

            lblTongKham.Text =
                thongKeBLL.TongKhamBenh().ToString();

            lblTongNhapVien.Text =
                thongKeBLL.TongNhapVien().ToString();

            lblTongBacSi.Text =
                thongKeBLL.TongBacSi().ToString();

            lblGiuongTrong.Text =
                thongKeBLL.TongGiuongTrong().ToString();

            lblDangSuDung.Text =
                thongKeBLL.TongGiuongDangSuDung().ToString();
        }

        private void LoadDashboard()
        {
            dgvThongKe1.AutoGenerateColumns = true;
            dgvThongKe2.AutoGenerateColumns = true;

            dgvThongKe1.DataSource =
                thongKeBLL.BenhNhanGanDay();

            dgvThongKe2.DataSource =
                thongKeBLL.NhapVienGanDay();
        }

        private void FormatGrid()
        {
            FormatDataGrid(dgvThongKe1);

            FormatDataGrid(dgvThongKe2);
        }
        #region BUTTON
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            switch (cboLoaiThongKe.Text)
            {
                case "Tất cả":
                    ThongKeTatCa();
                    break;

                case "Bệnh nhân":
                    ThongKeBenhNhan();
                    break;

                case "Khám bệnh":
                    ThongKeKhamBenh();
                    break;

                case "Nhập viện":
                    ThongKeNhapVien();
                    break;

                case "Bác sĩ":
                    ThongKeBacSi();
                    break;

                case "Giường":
                    ThongKeGiuong();
                    break;

                case "Phòng":
                    ThongKePhong();
                    break;

                case "Khoa":
                    ThongKeKhoa();
                    break;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            KhoiTaoBoLoc();

            LoadTongQuan();

            LoadDashboard();

            dgvThongKe1.ClearSelection();
            dgvThongKe2.ClearSelection();
        }
        #endregion

        private void ThongKeTatCa()
        {
            LoadTongQuan();

            dgvThongKe1.DataSource =
                thongKeBLL.BenhNhanGanDay();

            dgvThongKe2.DataSource =
                thongKeBLL.NhapVienGanDay();

            KiemTraDuLieu(dgvThongKe1);
            KiemTraDuLieu(dgvThongKe2);
        }
        private void ThongKeBenhNhan()
        {
            dgvThongKe1.DataSource =
                thongKeBLL.ThongKeBenhNhan(
                    dtpTuNgay.Value.Date,
                    dtpDenNgay.Value.Date);

            dgvThongKe2.DataSource = null;

            DinhDangBangBenhNhan();

            KiemTraDuLieu(dgvThongKe1);
        }
        private void ThongKeKhamBenh()
        {
            dgvThongKe1.DataSource =
                thongKeBLL.ThongKeKhamBenh(
                    dtpTuNgay.Value.Date,
                    dtpDenNgay.Value.Date);

            dgvThongKe2.DataSource = null;

            DinhDangBangKhamBenh();

            KiemTraDuLieu(dgvThongKe1);
        }
        private void ThongKeNhapVien()
        {
            dgvThongKe1.DataSource =
                thongKeBLL.ThongKeNhapVien(
                    dtpTuNgay.Value.Date,
                    dtpDenNgay.Value.Date);

            dgvThongKe2.DataSource = null;

            DinhDangBangNhapVien();

            KiemTraDuLieu(dgvThongKe1);
        }

        private void ThongKeBacSi()
        {
            dgvThongKe1.DataSource =
                thongKeBLL.DanhSachBacSi();

            dgvThongKe2.DataSource = null;

            DinhDangBangBacSi();

            KiemTraDuLieu(dgvThongKe1);
        }

        private void ThongKeGiuong()
        {
            dgvThongKe1.DataSource =
                thongKeBLL.DanhSachGiuong();

            dgvThongKe2.DataSource = null;

            DinhDangBangGiuong();

            KiemTraDuLieu(dgvThongKe1);
        }

        private void ThongKePhong()
        {
            dgvThongKe1.DataSource =
                thongKeBLL.DanhSachPhong();

            dgvThongKe2.DataSource = null;

            DinhDangBangPhong();

            KiemTraDuLieu(dgvThongKe1);
        }

        private void ThongKeKhoa()
        {
            dgvThongKe1.DataSource =
                thongKeBLL.DanhSachKhoa();

            dgvThongKe2.DataSource = null;

            DinhDangBangKhoa();

            KiemTraDuLieu(dgvThongKe1);
        }

        private void DinhDangBangBenhNhan()
        {
            dgvThongKe1.Columns["MaBN"].HeaderText = "Mã BN";
            dgvThongKe1.Columns["HoTen"].HeaderText = "Họ tên";
            dgvThongKe1.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvThongKe1.Columns["ThoiDiemKham"].HeaderText = "Ngày khám";
        }

        private void DinhDangBangKhamBenh()
        {
            dgvThongKe1.Columns["MaKham"].HeaderText = "Mã khám";
            dgvThongKe1.Columns["HoTen"].HeaderText = "Bệnh nhân";
            dgvThongKe1.Columns["TenBacSi"].HeaderText = "Bác sĩ";
            dgvThongKe1.Columns["ChanDoan"].HeaderText = "Chẩn đoán";
            dgvThongKe1.Columns["ThoiDiemKham"].HeaderText = "Ngày khám";
        }

        private void DinhDangBangNhapVien()
        {
            dgvThongKe1.Columns["MaNhapVien"].HeaderText = "Mã nhập viện";
            dgvThongKe1.Columns["BenhNhan"].HeaderText = "Bệnh nhân";
            dgvThongKe1.Columns["BacSi"].HeaderText = "Bác sĩ";
            dgvThongKe1.Columns["SoGiuong"].HeaderText = "Giường";
            dgvThongKe1.Columns["NgayNhan"].HeaderText = "Ngày nhập";
            dgvThongKe1.Columns["NgayTra"].HeaderText = "Ngày xuất";
        }

        private void DinhDangBangBacSi()
        {
            dgvThongKe1.Columns["MaBS"].HeaderText = "Mã BS";
            dgvThongKe1.Columns["HoTen"].HeaderText = "Họ tên";
            dgvThongKe1.Columns["ChuyenNganh"].HeaderText = "Chuyên ngành";
            dgvThongKe1.Columns["KyNang"].HeaderText = "Kỹ năng";
            dgvThongKe1.Columns["LichLamViec"].HeaderText = "Lịch làm việc";
        }

        private void DinhDangBangGiuong()
        {
            dgvThongKe1.Columns["MaGiuong"].HeaderText = "Mã giường";
            dgvThongKe1.Columns["SoGiuong"].HeaderText = "Số giường";
            dgvThongKe1.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvThongKe1.Columns["TenPhong"].HeaderText = "Phòng";
        }

        private void DinhDangBangPhong()
        {
            dgvThongKe1.Columns["MaPhong"].HeaderText = "Mã phòng";
            dgvThongKe1.Columns["TenPhong"].HeaderText = "Tên phòng";
            dgvThongKe1.Columns["TenKhoa"].HeaderText = "Khoa";
        }

        private void DinhDangBangKhoa()
        {
            dgvThongKe1.Columns["MaKhoa"].HeaderText = "Mã khoa";
            dgvThongKe1.Columns["TenKhoa"].HeaderText = "Tên khoa";
            dgvThongKe1.Columns["MoTa"].HeaderText = "Mô tả";
        }

        private void SetHeader(DataGridView dgv, string columnName, string header)
        {
            if (dgv.Columns.Contains(columnName))
            {
                dgv.Columns[columnName].HeaderText = header;
            }
        }

        private void HideColumn(DataGridView dgv, string columnName)
        {
            if (dgv.Columns.Contains(columnName))
            {
                dgv.Columns[columnName].Visible = false;
            }
        }
        private void FormatDataGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.AllowUserToAddRows = false;

            dgv.AllowUserToDeleteRows = false;

            dgv.AllowUserToResizeRows = false;

            dgv.MultiSelect = false;

            dgv.ReadOnly = true;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.RowHeadersVisible = false;

            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgv.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgv.ColumnHeadersHeight = 40;

            dgv.EnableHeadersVisualStyles = false;

            dgv.ClearSelection();
        }

        private void KiemTraDuLieu(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu trong khoảng thời gian đã chọn.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void frmThongKe_Load_1(object sender, EventArgs e)
        {
            if (!PermissionHelper.HasPermission("THONGKE"))
            {
                MessageBox.Show("Bạn không có quyền!", "Thông báo");
                this.Close();
                return;
            }
        }
    }
}