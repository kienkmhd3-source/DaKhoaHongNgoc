namespace HospitalManagement.GUI
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            grbBoLoc = new GroupBox();
            btnLamMoi = new Button();
            btnThongKe = new Button();
            cboLoaiThongKe = new ComboBox();
            lblLoaiThongKe = new Label();
            lblDenNgay = new Label();
            dtpDenNgay = new DateTimePicker();
            lblTuNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            grbTongQuan = new GroupBox();
            pnlTongNhapVien = new Panel();
            lblTongNhapVienTitle = new Label();
            lblTongNhapVien = new Label();
            pnlDangSuDung = new Panel();
            lblDangSuDungTitle = new Label();
            lblDangSuDung = new Label();
            pnlTongKham = new Panel();
            lblTongKhamTitle = new Label();
            lblTongKham = new Label();
            pnlGiuongTrong = new Panel();
            lblGiuongTrongTitle = new Label();
            lblGiuongTrong = new Label();
            pnlTongBacSi = new Panel();
            lblTongBacSiTitle = new Label();
            lblTongBacSi = new Label();
            pnlTongBenhNhan = new Panel();
            lblTongBenhNhan = new Label();
            lblTongBenhNhanTitle = new Label();
            grpDuLieu = new GroupBox();
            grpChiTiet = new GroupBox();
            dgvThongKe2 = new DataGridView();
            grpDanhSach = new GroupBox();
            dgvThongKe1 = new DataGridView();
            grbBoLoc.SuspendLayout();
            grbTongQuan.SuspendLayout();
            pnlTongNhapVien.SuspendLayout();
            pnlDangSuDung.SuspendLayout();
            pnlTongKham.SuspendLayout();
            pnlGiuongTrong.SuspendLayout();
            pnlTongBacSi.SuspendLayout();
            pnlTongBenhNhan.SuspendLayout();
            grpDuLieu.SuspendLayout();
            grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe2).BeginInit();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe1).BeginInit();
            SuspendLayout();
            // 
            // grbBoLoc
            // 
            grbBoLoc.Controls.Add(btnLamMoi);
            grbBoLoc.Controls.Add(btnThongKe);
            grbBoLoc.Controls.Add(cboLoaiThongKe);
            grbBoLoc.Controls.Add(lblLoaiThongKe);
            grbBoLoc.Controls.Add(lblDenNgay);
            grbBoLoc.Controls.Add(dtpDenNgay);
            grbBoLoc.Controls.Add(lblTuNgay);
            grbBoLoc.Controls.Add(dtpTuNgay);
            grbBoLoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbBoLoc.ForeColor = Color.FromArgb(0, 122, 204);
            grbBoLoc.Location = new Point(20, 15);
            grbBoLoc.Name = "grbBoLoc";
            grbBoLoc.Size = new Size(1340, 95);
            grbBoLoc.TabIndex = 0;
            grbBoLoc.TabStop = false;
            grbBoLoc.Text = "BỘ LỌC THỐNG KÊ";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(26, 188, 156);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1160, 38);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 40);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(0, 122, 204);
            btnThongKe.Cursor = Cursors.Hand;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(1015, 38);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(130, 40);
            btnThongKe.TabIndex = 6;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // cboLoaiThongKe
            // 
            cboLoaiThongKe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiThongKe.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cboLoaiThongKe.FormattingEnabled = true;
            cboLoaiThongKe.Items.AddRange(new object[] { "Tất cả", "Bệnh nhân", "Khám bệnh", "Nhập viện", "Bác sĩ", "Giường bệnh", "Phòng", "Khoa" });
            cboLoaiThongKe.Location = new Point(745, 43);
            cboLoaiThongKe.Name = "cboLoaiThongKe";
            cboLoaiThongKe.Size = new Size(240, 31);
            cboLoaiThongKe.TabIndex = 5;
            // 
            // lblLoaiThongKe
            // 
            lblLoaiThongKe.AutoSize = true;
            lblLoaiThongKe.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoaiThongKe.ForeColor = Color.Black;
            lblLoaiThongKe.Location = new Point(630, 47);
            lblLoaiThongKe.Name = "lblLoaiThongKe";
            lblLoaiThongKe.Size = new Size(111, 23);
            lblLoaiThongKe.TabIndex = 4;
            lblLoaiThongKe.Text = "Loại thống kê";
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDenNgay.ForeColor = Color.Black;
            lblDenNgay.Location = new Point(325, 47);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(82, 23);
            lblDenNgay.TabIndex = 3;
            lblDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(415, 43);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(180, 30);
            dtpDenNgay.TabIndex = 2;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTuNgay.ForeColor = Color.Black;
            lblTuNgay.Location = new Point(25, 47);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(70, 23);
            lblTuNgay.TabIndex = 1;
            lblTuNgay.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(105, 43);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(180, 30);
            dtpTuNgay.TabIndex = 0;
            // 
            // grbTongQuan
            // 
            grbTongQuan.Controls.Add(pnlTongNhapVien);
            grbTongQuan.Controls.Add(pnlDangSuDung);
            grbTongQuan.Controls.Add(pnlTongKham);
            grbTongQuan.Controls.Add(pnlGiuongTrong);
            grbTongQuan.Controls.Add(pnlTongBacSi);
            grbTongQuan.Controls.Add(pnlTongBenhNhan);
            grbTongQuan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbTongQuan.ForeColor = Color.FromArgb(0, 122, 204);
            grbTongQuan.Location = new Point(20, 120);
            grbTongQuan.Name = "grbTongQuan";
            grbTongQuan.Size = new Size(1340, 160);
            grbTongQuan.TabIndex = 1;
            grbTongQuan.TabStop = false;
            grbTongQuan.Text = "CHỈ SỐ TỔNG QUAN";
            // 
            // pnlTongBenhNhan
            // 
            pnlTongBenhNhan.BackColor = Color.FromArgb(41, 128, 185);
            pnlTongBenhNhan.Controls.Add(lblTongBenhNhan);
            pnlTongBenhNhan.Controls.Add(lblTongBenhNhanTitle);
            pnlTongBenhNhan.Location = new Point(25, 35);
            pnlTongBenhNhan.Name = "pnlTongBenhNhan";
            pnlTongBenhNhan.Size = new Size(195, 105);
            pnlTongBenhNhan.TabIndex = 0;
            // 
            // lblTongBenhNhan
            // 
            lblTongBenhNhan.Dock = DockStyle.Top;
            lblTongBenhNhan.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongBenhNhan.ForeColor = Color.White;
            lblTongBenhNhan.Location = new Point(0, 0);
            lblTongBenhNhan.Name = "lblTongBenhNhan";
            lblTongBenhNhan.Size = new Size(195, 65);
            lblTongBenhNhan.TabIndex = 0;
            lblTongBenhNhan.Text = "0";
            lblTongBenhNhan.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblTongBenhNhanTitle
            // 
            lblTongBenhNhanTitle.Dock = DockStyle.Bottom;
            lblTongBenhNhanTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongBenhNhanTitle.ForeColor = Color.WhiteSmoke;
            lblTongBenhNhanTitle.Location = new Point(0, 65);
            lblTongBenhNhanTitle.Name = "lblTongBenhNhanTitle";
            lblTongBenhNhanTitle.Size = new Size(195, 40);
            lblTongBenhNhanTitle.TabIndex = 1;
            lblTongBenhNhanTitle.Text = "TỔNG BỆNH NHÂN";
            lblTongBenhNhanTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlTongKham
            // 
            pnlTongKham.BackColor = Color.FromArgb(39, 174, 96);
            pnlTongKham.Controls.Add(lblTongKham);
            pnlTongKham.Controls.Add(lblTongKhamTitle);
            pnlTongKham.Location = new Point(243, 35);
            pnlTongKham.Name = "pnlTongKham";
            pnlTongKham.Size = new Size(195, 105);
            pnlTongKham.TabIndex = 1;
            // 
            // lblTongKham
            // 
            lblTongKham.Dock = DockStyle.Top;
            lblTongKham.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongKham.ForeColor = Color.White;
            lblTongKham.Location = new Point(0, 0);
            lblTongKham.Name = "lblTongKham";
            lblTongKham.Size = new Size(195, 65);
            lblTongKham.TabIndex = 0;
            lblTongKham.Text = "0";
            lblTongKham.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblTongKhamTitle
            // 
            lblTongKhamTitle.Dock = DockStyle.Bottom;
            lblTongKhamTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongKhamTitle.ForeColor = Color.WhiteSmoke;
            lblTongKhamTitle.Location = new Point(0, 65);
            lblTongKhamTitle.Name = "lblTongKhamTitle";
            lblTongKhamTitle.Size = new Size(195, 40);
            lblTongKhamTitle.TabIndex = 1;
            lblTongKhamTitle.Text = "TỔNG LƯỢT KHÁM";
            lblTongKhamTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlTongNhapVien
            // 
            pnlTongNhapVien.BackColor = Color.FromArgb(230, 126, 34);
            pnlTongNhapVien.Controls.Add(lblTongNhapVien);
            pnlTongNhapVien.Controls.Add(lblTongNhapVienTitle);
            pnlTongNhapVien.Location = new Point(461, 35);
            pnlTongNhapVien.Name = "pnlTongNhapVien";
            pnlTongNhapVien.Size = new Size(195, 105);
            pnlTongNhapVien.TabIndex = 2;
            // 
            // lblTongNhapVien
            // 
            lblTongNhapVien.Dock = DockStyle.Top;
            lblTongNhapVien.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongNhapVien.ForeColor = Color.White;
            lblTongNhapVien.Location = new Point(0, 0);
            lblTongNhapVien.Name = "lblTongNhapVien";
            lblTongNhapVien.Size = new Size(195, 65);
            lblTongNhapVien.TabIndex = 0;
            lblTongNhapVien.Text = "0";
            lblTongNhapVien.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblTongNhapVienTitle
            // 
            lblTongNhapVienTitle.Dock = DockStyle.Bottom;
            lblTongNhapVienTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongNhapVienTitle.ForeColor = Color.WhiteSmoke;
            lblTongNhapVienTitle.Location = new Point(0, 65);
            lblTongNhapVienTitle.Name = "lblTongNhapVienTitle";
            lblTongNhapVienTitle.Size = new Size(195, 40);
            lblTongNhapVienTitle.TabIndex = 1;
            lblTongNhapVienTitle.Text = "LƯỢT NHẬP VIỆN";
            lblTongNhapVienTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlTongBacSi
            // 
            pnlTongBacSi.BackColor = Color.FromArgb(142, 68, 173);
            pnlTongBacSi.Controls.Add(lblTongBacSi);
            pnlTongBacSi.Controls.Add(lblTongBacSiTitle);
            pnlTongBacSi.Location = new Point(679, 35);
            pnlTongBacSi.Name = "pnlTongBacSi";
            pnlTongBacSi.Size = new Size(195, 105);
            pnlTongBacSi.TabIndex = 3;
            // 
            // lblTongBacSi
            // 
            lblTongBacSi.Dock = DockStyle.Top;
            lblTongBacSi.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongBacSi.ForeColor = Color.White;
            lblTongBacSi.Location = new Point(0, 0);
            lblTongBacSi.Name = "lblTongBacSi";
            lblTongBacSi.Size = new Size(195, 65);
            lblTongBacSi.TabIndex = 0;
            lblTongBacSi.Text = "0";
            lblTongBacSi.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblTongBacSiTitle
            // 
            lblTongBacSiTitle.Dock = DockStyle.Bottom;
            lblTongBacSiTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongBacSiTitle.ForeColor = Color.WhiteSmoke;
            lblTongBacSiTitle.Location = new Point(0, 65);
            lblTongBacSiTitle.Name = "lblTongBacSiTitle";
            lblTongBacSiTitle.Size = new Size(195, 40);
            lblTongBacSiTitle.TabIndex = 1;
            lblTongBacSiTitle.Text = "TỔNG BÁC SĨ";
            lblTongBacSiTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlGiuongTrong
            // 
            pnlGiuongTrong.BackColor = Color.FromArgb(22, 160, 133);
            pnlGiuongTrong.Controls.Add(lblGiuongTrong);
            pnlGiuongTrong.Controls.Add(lblGiuongTrongTitle);
            pnlGiuongTrong.Location = new Point(897, 35);
            pnlGiuongTrong.Name = "pnlGiuongTrong";
            pnlGiuongTrong.Size = new Size(195, 105);
            pnlGiuongTrong.TabIndex = 4;
            // 
            // lblGiuongTrong
            // 
            lblGiuongTrong.Dock = DockStyle.Top;
            lblGiuongTrong.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblGiuongTrong.ForeColor = Color.White;
            lblGiuongTrong.Location = new Point(0, 0);
            lblGiuongTrong.Name = "lblGiuongTrong";
            lblGiuongTrong.Size = new Size(195, 65);
            lblGiuongTrong.TabIndex = 0;
            lblGiuongTrong.Text = "0";
            lblGiuongTrong.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblGiuongTrongTitle
            // 
            lblGiuongTrongTitle.Dock = DockStyle.Bottom;
            lblGiuongTrongTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblGiuongTrongTitle.ForeColor = Color.WhiteSmoke;
            lblGiuongTrongTitle.Location = new Point(0, 65);
            lblGiuongTrongTitle.Name = "lblGiuongTrongTitle";
            lblGiuongTrongTitle.Size = new Size(195, 40);
            lblGiuongTrongTitle.TabIndex = 1;
            lblGiuongTrongTitle.Text = "GIƯỜNG TRỐNG";
            lblGiuongTrongTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlDangSuDung
            // 
            pnlDangSuDung.BackColor = Color.FromArgb(231, 76, 60);
            pnlDangSuDung.Controls.Add(lblDangSuDung);
            pnlDangSuDung.Controls.Add(lblDangSuDungTitle);
            pnlDangSuDung.Location = new Point(1115, 35);
            pnlDangSuDung.Name = "pnlDangSuDung";
            pnlDangSuDung.Size = new Size(195, 105);
            pnlDangSuDung.TabIndex = 5;
            // 
            // lblDangSuDung
            // 
            lblDangSuDung.Dock = DockStyle.Top;
            lblDangSuDung.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblDangSuDung.ForeColor = Color.White;
            lblDangSuDung.Location = new Point(0, 0);
            lblDangSuDung.Name = "lblDangSuDung";
            lblDangSuDung.Size = new Size(195, 65);
            lblDangSuDung.TabIndex = 0;
            lblDangSuDung.Text = "0";
            lblDangSuDung.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblDangSuDungTitle
            // 
            lblDangSuDungTitle.Dock = DockStyle.Bottom;
            lblDangSuDungTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDangSuDungTitle.ForeColor = Color.WhiteSmoke;
            lblDangSuDungTitle.Location = new Point(0, 65);
            lblDangSuDungTitle.Name = "lblDangSuDungTitle";
            lblDangSuDungTitle.Size = new Size(195, 40);
            lblDangSuDungTitle.TabIndex = 1;
            lblDangSuDungTitle.Text = "ĐANG SỬ DỤNG";
            lblDangSuDungTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // grpDuLieu
            // 
            grpDuLieu.Controls.Add(grpChiTiet);
            grpDuLieu.Controls.Add(grpDanhSach);
            grpDuLieu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDuLieu.ForeColor = Color.FromArgb(0, 122, 204);
            grpDuLieu.Location = new Point(20, 290);
            grpDuLieu.Name = "grpDuLieu";
            grpDuLieu.Size = new Size(1340, 465);
            grpDuLieu.TabIndex = 2;
            grpDuLieu.TabStop = false;
            grpDuLieu.Text = "DỮ LIỆU THỐNG KÊ & BÁO CÁO";
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dgvThongKe1);
            grpDanhSach.Location = new Point(20, 30);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(640, 420);
            grpDanhSach.TabIndex = 0;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "DANH SÁCH THỐNG KÊ";
            // 
            // dgvThongKe1
            // 
            dgvThongKe1.AllowUserToAddRows = false;
            dgvThongKe1.AllowUserToDeleteRows = false;
            dgvThongKe1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            dgvThongKe1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvThongKe1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvThongKe1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe1.BackgroundColor = Color.White;
            dgvThongKe1.BorderStyle = BorderStyle.None;
            dgvThongKe1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvThongKe1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvThongKe1.ColumnHeadersHeight = 40;
            dgvThongKe1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvThongKe1.DefaultCellStyle = dataGridViewCellStyle3;
            dgvThongKe1.EnableHeadersVisualStyles = false;
            dgvThongKe1.GridColor = Color.FromArgb(224, 224, 224);
            dgvThongKe1.Location = new Point(15, 30);
            dgvThongKe1.MultiSelect = false;
            dgvThongKe1.Name = "dgvThongKe1";
            dgvThongKe1.ReadOnly = true;
            dgvThongKe1.RowHeadersVisible = false;
            dgvThongKe1.RowHeadersWidth = 51;
            dgvThongKe1.RowTemplate.Height = 35;
            dgvThongKe1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongKe1.Size = new Size(610, 375);
            dgvThongKe1.TabIndex = 0;
            // 
            // grpChiTiet
            // 
            grpChiTiet.Controls.Add(dgvThongKe2);
            grpChiTiet.Location = new Point(680, 30);
            grpChiTiet.Name = "grpChiTiet";
            grpChiTiet.Size = new Size(640, 420);
            grpChiTiet.TabIndex = 1;
            grpChiTiet.TabStop = false;
            grpChiTiet.Text = "CHI TIẾT";
            // 
            // dgvThongKe2
            // 
            dgvThongKe2.AllowUserToAddRows = false;
            dgvThongKe2.AllowUserToDeleteRows = false;
            dgvThongKe2.AllowUserToResizeColumns = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(245, 247, 250);
            dgvThongKe2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvThongKe2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvThongKe2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe2.BackgroundColor = Color.White;
            dgvThongKe2.BorderStyle = BorderStyle.None;
            dgvThongKe2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvThongKe2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvThongKe2.ColumnHeadersHeight = 40;
            dgvThongKe2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvThongKe2.DefaultCellStyle = dataGridViewCellStyle6;
            dgvThongKe2.EnableHeadersVisualStyles = false;
            dgvThongKe2.GridColor = Color.FromArgb(224, 224, 224);
            dgvThongKe2.Location = new Point(15, 30);
            dgvThongKe2.MultiSelect = false;
            dgvThongKe2.Name = "dgvThongKe2";
            dgvThongKe2.ReadOnly = true;
            dgvThongKe2.RowHeadersVisible = false;
            dgvThongKe2.RowHeadersWidth = 51;
            dgvThongKe2.RowTemplate.Height = 35;
            dgvThongKe2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongKe2.Size = new Size(610, 375);
            dgvThongKe2.TabIndex = 0;
            // 
            // frmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 773);
            Controls.Add(grpDuLieu);
            Controls.Add(grbTongQuan);
            Controls.Add(grbBoLoc);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Thống kê & Báo cáo";
            Load += frmThongKe_Load_1;
            grbBoLoc.ResumeLayout(false);
            grbBoLoc.PerformLayout();
            grbTongQuan.ResumeLayout(false);
            pnlTongNhapVien.ResumeLayout(false);
            pnlDangSuDung.ResumeLayout(false);
            pnlTongKham.ResumeLayout(false);
            pnlGiuongTrong.ResumeLayout(false);
            pnlTongBacSi.ResumeLayout(false);
            pnlTongBenhNhan.ResumeLayout(false);
            grpDuLieu.ResumeLayout(false);
            grpChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKe2).EndInit();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKe1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbBoLoc;
        private DateTimePicker dtpDenNgay;
        private Label lblTuNgay;
        private DateTimePicker dtpTuNgay;
        private Label lblDenNgay;
        private ComboBox cboLoaiThongKe;
        private Label lblLoaiThongKe;
        private Button btnLamMoi;
        private Button btnThongKe;
        private GroupBox grbTongQuan;
        private Panel pnlTongBenhNhan;
        private Panel pnlTongNhapVien;
        private Panel pnlTongKham;
        private Panel pnlTongBacSi;
        private Panel pnlGiuongTrong;
        private Panel pnlDangSuDung;
        private Label lblTongBenhNhan;
        private Label lblTongBenhNhanTitle;
        private Label lblTongKham;
        private Label lblTongKhamTitle;
        private Label lblTongNhapVienTitle;
        private Label lblTongNhapVien;
        private Label lblTongBacSiTitle;
        private Label lblTongBacSi;
        private Label lblGiuongTrongTitle;
        private Label lblGiuongTrong;
        private Label lblDangSuDungTitle;
        private Label lblDangSuDung;
        private GroupBox grpDuLieu;
        private GroupBox grpDanhSach;
        private DataGridView dgvThongKe1;
        private GroupBox grpChiTiet;
        private DataGridView dgvThongKe2;
    }
}