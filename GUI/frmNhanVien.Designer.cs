namespace HospitalManagement.GUI
{
    partial class frmNhanVien
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
            grbThongTin = new GroupBox();
            cboKhoa = new ComboBox();
            dtpNgayTuyenDung = new DateTimePicker();
            dtpNgaySinh = new DateTimePicker();
            cboGioiTinh = new ComboBox();
            txtChucDanh = new TextBox();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            txtCMND = new TextBox();
            label10 = new Label();
            txtMaNV = new TextBox();
            lblKhoa = new Label();
            lblChucDanh = new Label();
            lblNgaySinh = new Label();
            lblNgayTuyenDung = new Label();
            lblCMND = new Label();
            lblGioiTinh = new Label();
            lblHoTen = new Label();
            lblDiaChi = new Label();
            lblMaNV = new Label();
            grbChucNang = new GroupBox();
            btnLamMoi = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            dgvNhanVien = new DataGridView();
            colMaNV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colCMND = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colNgayTuyenDung = new DataGridViewTextBoxColumn();
            colChucDanh = new DataGridViewTextBoxColumn();
            colTenKhoa = new DataGridViewTextBoxColumn();
            colMaKhoa = new DataGridViewTextBoxColumn();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(cboKhoa);
            grbThongTin.Controls.Add(dtpNgayTuyenDung);
            grbThongTin.Controls.Add(dtpNgaySinh);
            grbThongTin.Controls.Add(cboGioiTinh);
            grbThongTin.Controls.Add(txtChucDanh);
            grbThongTin.Controls.Add(txtDiaChi);
            grbThongTin.Controls.Add(txtHoTen);
            grbThongTin.Controls.Add(txtCMND);
            grbThongTin.Controls.Add(label10);
            grbThongTin.Controls.Add(txtMaNV);
            grbThongTin.Controls.Add(lblKhoa);
            grbThongTin.Controls.Add(lblChucDanh);
            grbThongTin.Controls.Add(lblNgaySinh);
            grbThongTin.Controls.Add(lblNgayTuyenDung);
            grbThongTin.Controls.Add(lblCMND);
            grbThongTin.Controls.Add(lblGioiTinh);
            grbThongTin.Controls.Add(lblHoTen);
            grbThongTin.Controls.Add(lblDiaChi);
            grbThongTin.Controls.Add(lblMaNV);
            grbThongTin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            grbThongTin.ForeColor = Color.FromArgb(0, 122, 204);
            grbThongTin.Location = new Point(20, 20);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(1020, 250);
            grbThongTin.TabIndex = 0;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // cboKhoa
            // 
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.Font = new Font("Segoe UI", 10.2F);
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(650, 200);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(340, 31);
            cboKhoa.TabIndex = 8;
            // 
            // dtpNgayTuyenDung
            // 
            dtpNgayTuyenDung.CustomFormat = "dd/MM/yyyy";
            dtpNgayTuyenDung.Font = new Font("Segoe UI", 10.2F);
            dtpNgayTuyenDung.Format = DateTimePickerFormat.Custom;
            dtpNgayTuyenDung.Location = new Point(650, 120);
            dtpNgayTuyenDung.Name = "dtpNgayTuyenDung";
            dtpNgayTuyenDung.Size = new Size(340, 30);
            dtpNgayTuyenDung.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Segoe UI", 10.2F);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(150, 120);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(320, 30);
            dtpNgaySinh.TabIndex = 4;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Font = new Font("Segoe UI", 10.2F);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(650, 80);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(340, 31);
            cboGioiTinh.TabIndex = 3;
            // 
            // txtChucDanh
            // 
            txtChucDanh.Font = new Font("Segoe UI", 10.2F);
            txtChucDanh.Location = new Point(650, 160);
            txtChucDanh.Name = "txtChucDanh";
            txtChucDanh.Size = new Size(340, 30);
            txtChucDanh.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 10.2F);
            txtDiaChi.Location = new Point(150, 160);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(320, 30);
            txtDiaChi.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10.2F);
            txtHoTen.Location = new Point(650, 40);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(340, 30);
            txtHoTen.TabIndex = 1;
            // 
            // txtCMND
            // 
            txtCMND.Font = new Font("Segoe UI", 10.2F);
            txtCMND.Location = new Point(150, 80);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(320, 30);
            txtCMND.TabIndex = 2;
            txtCMND.KeyPress += txtCMND_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(53, 23);
            label10.TabIndex = 0;
            label10.Text = "label1";
            label10.Visible = false;
            // 
            // txtMaNV
            // 
            txtMaNV.CharacterCasing = CharacterCasing.Upper;
            txtMaNV.Font = new Font("Segoe UI", 10.2F);
            txtMaNV.Location = new Point(150, 40);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(320, 30);
            txtMaNV.TabIndex = 0;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Font = new Font("Segoe UI", 10.2F);
            lblKhoa.ForeColor = Color.Black;
            lblKhoa.Location = new Point(520, 203);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(49, 23);
            lblKhoa.TabIndex = 0;
            lblKhoa.Text = "Khoa";
            // 
            // lblChucDanh
            // 
            lblChucDanh.AutoSize = true;
            lblChucDanh.Font = new Font("Segoe UI", 10.2F);
            lblChucDanh.ForeColor = Color.Black;
            lblChucDanh.Location = new Point(520, 163);
            lblChucDanh.Name = "lblChucDanh";
            lblChucDanh.Size = new Size(98, 23);
            lblChucDanh.TabIndex = 0;
            lblChucDanh.Text = "Chức danh ";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 10.2F);
            lblNgaySinh.ForeColor = Color.Black;
            lblNgaySinh.Location = new Point(30, 125);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(86, 23);
            lblNgaySinh.TabIndex = 0;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblNgayTuyenDung
            // 
            lblNgayTuyenDung.AutoSize = true;
            lblNgayTuyenDung.Font = new Font("Segoe UI", 10.2F);
            lblNgayTuyenDung.ForeColor = Color.Black;
            lblNgayTuyenDung.Location = new Point(520, 125);
            lblNgayTuyenDung.Name = "lblNgayTuyenDung";
            lblNgayTuyenDung.Size = new Size(98, 23);
            lblNgayTuyenDung.TabIndex = 0;
            lblNgayTuyenDung.Text = "Ngày tuyển";
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.Font = new Font("Segoe UI", 10.2F);
            lblCMND.ForeColor = Color.Black;
            lblCMND.Location = new Point(30, 83);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(113, 23);
            lblCMND.TabIndex = 0;
            lblCMND.Text = "CMND/CCCD";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 10.2F);
            lblGioiTinh.ForeColor = Color.Black;
            lblGioiTinh.Location = new Point(520, 83);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(75, 23);
            lblGioiTinh.TabIndex = 0;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10.2F);
            lblHoTen.ForeColor = Color.Black;
            lblHoTen.Location = new Point(520, 43);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(62, 23);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 10.2F);
            lblDiaChi.ForeColor = Color.Black;
            lblDiaChi.Location = new Point(30, 163);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(62, 23);
            lblDiaChi.TabIndex = 0;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 10.2F);
            lblMaNV.ForeColor = Color.Black;
            lblMaNV.Location = new Point(30, 43);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(114, 23);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã nhân viên";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnLamMoi);
            grbChucNang.Controls.Add(btnHuy);
            grbChucNang.Controls.Add(btnLuu);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            grbChucNang.ForeColor = Color.FromArgb(0, 122, 204);
            grbChucNang.Location = new Point(20, 280);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(1020, 85);
            grbChucNang.TabIndex = 1;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "BẢNG CHỨC NĂNG";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(26, 188, 156);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(780, 30);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 40);
            btnLamMoi.TabIndex = 14;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(149, 165, 166);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(650, 30);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 40);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(41, 128, 185);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(520, 30);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 40);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(231, 76, 60);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(390, 30);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 40);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 122, 204);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(260, 30);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 40);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(46, 204, 113);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(130, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 40);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblTimKiem.Location = new Point(30, 390);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(80, 23);
            lblTimKiem.TabIndex = 2;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F);
            txtTimKiem.Location = new Point(120, 387);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(350, 30);
            txtTimKiem.TabIndex = 15;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(0, 122, 204);
            btnTim.Cursor = Cursors.Hand;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(490, 383);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(100, 36);
            btnTim.TabIndex = 16;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanVien.ColumnHeadersHeight = 45;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colMaNV, colHoTen, colCMND, colGioiTinh, colNgaySinh, colDiaChi, colNgayTuyenDung, colChucDanh, colTenKhoa, colMaKhoa });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.GridColor = Color.FromArgb(224, 224, 224);
            dgvNhanVien.Location = new Point(20, 440);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 35;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1020, 250);
            dgvNhanVien.TabIndex = 5;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // colMaNV
            // 
            colMaNV.DataPropertyName = "MaNV";
            colMaNV.FillWeight = 70F;
            colMaNV.HeaderText = "Mã NV";
            colMaNV.MinimumWidth = 6;
            colMaNV.Name = "colMaNV";
            colMaNV.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.FillWeight = 150F;
            colHoTen.HeaderText = "Họ tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            // 
            // colCMND
            // 
            colCMND.DataPropertyName = "CMND";
            colCMND.FillWeight = 120F;
            colCMND.HeaderText = "CMND";
            colCMND.MinimumWidth = 6;
            colCMND.Name = "colCMND";
            colCMND.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.FillWeight = 80F;
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày sinh ";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.FillWeight = 120F;
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            // 
            // colNgayTuyenDung
            // 
            colNgayTuyenDung.DataPropertyName = "NgayTuyenDung";
            colNgayTuyenDung.FillWeight = 120F;
            colNgayTuyenDung.HeaderText = "Ngày tuyển";
            colNgayTuyenDung.MinimumWidth = 6;
            colNgayTuyenDung.Name = "colNgayTuyenDung";
            colNgayTuyenDung.ReadOnly = true;
            // 
            // colChucDanh
            // 
            colChucDanh.DataPropertyName = "ChucDanh";
            colChucDanh.HeaderText = "Chức danh ";
            colChucDanh.MinimumWidth = 6;
            colChucDanh.Name = "colChucDanh";
            colChucDanh.ReadOnly = true;
            // 
            // colTenKhoa
            // 
            colTenKhoa.DataPropertyName = "TenKhoa";
            colTenKhoa.FillWeight = 140F;
            colTenKhoa.HeaderText = "Khoa";
            colTenKhoa.MinimumWidth = 6;
            colTenKhoa.Name = "colTenKhoa";
            colTenKhoa.ReadOnly = true;
            // 
            // colMaKhoa
            // 
            colMaKhoa.DataPropertyName = "MaKhoa";
            colMaKhoa.HeaderText = "Mã khoa";
            colMaKhoa.MinimumWidth = 6;
            colMaKhoa.Name = "colMaKhoa";
            colMaKhoa.ReadOnly = true;
            colMaKhoa.Visible = false;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1060, 720);
            Controls.Add(dgvNhanVien);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(grbChucNang);
            Controls.Add(grbThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Viên";
            Load += frmNhanVien_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbThongTin;
        private TextBox txtMaNV;
        private Label lblHoTen;
        private Label lblMaNV;
        private TextBox txtCMND;
        private GroupBox grbChucNang;
        private Label lblCMND;
        private TextBox txtDiaChi;
        private Label label10;
        private Label lblKhoa;
        private Label lblChucDanh;
        private Label lblNgaySinh;
        private Label lblNgayTuyenDung;
        private Label lblGioiTinh;
        private Label lblDiaChi;
        private TextBox txtHoTen;
        private ComboBox cboGioiTinh;
        private DateTimePicker dtpNgaySinh;
        private DateTimePicker dtpNgayTuyenDung;
        private TextBox txtChucDanh;
        private ComboBox cboKhoa;
        private Button btnThem;
        private Button btnLamMoi;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTim;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn colMaNV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colCMND;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colNgayTuyenDung;
        private DataGridViewTextBoxColumn colChucDanh;
        private DataGridViewTextBoxColumn colTenKhoa;
        private DataGridViewTextBoxColumn colMaKhoa;
    }
}