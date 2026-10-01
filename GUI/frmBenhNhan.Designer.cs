namespace HospitalManagement.GUI
{
    partial class frmBenhNhan
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
            dtpNgayDangKy = new DateTimePicker();
            lblBenh = new Label();
            btnLuu = new Button();
            btnTim = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnHuy = new Button();
            btnThem = new Button();
            dtpNgaySinh = new DateTimePicker();
            cboBacSi = new ComboBox();
            cboGioiTinh = new ComboBox();
            txtCMND = new TextBox();
            txtBenhDaPhatHien = new TextBox();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            txtTimKiem = new TextBox();
            txtMaBN = new TextBox();
            lblDiaChi = new Label();
            lblNgayDangKy = new Label();
            lblNgaySinh = new Label();
            lblGioiTinh = new Label();
            lblCCCD = new Label();
            lblBacSi = new Label();
            lblHoTen = new Label();
            lblMaBN = new Label();
            grbDanhSach = new GroupBox();
            dgvBenhNhan = new DataGridView();
            colMaBN = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colCMND = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colNgayDangKy = new DataGridViewTextBoxColumn();
            colBenh = new DataGridViewTextBoxColumn();
            colBacSi = new DataGridViewTextBoxColumn();
            grbThongTin.SuspendLayout();
            grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBenhNhan).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(dtpNgayDangKy);
            grbThongTin.Controls.Add(lblBenh);
            grbThongTin.Controls.Add(btnLuu);
            grbThongTin.Controls.Add(btnTim);
            grbThongTin.Controls.Add(btnXoa);
            grbThongTin.Controls.Add(btnLamMoi);
            grbThongTin.Controls.Add(btnSua);
            grbThongTin.Controls.Add(btnHuy);
            grbThongTin.Controls.Add(btnThem);
            grbThongTin.Controls.Add(dtpNgaySinh);
            grbThongTin.Controls.Add(cboBacSi);
            grbThongTin.Controls.Add(cboGioiTinh);
            grbThongTin.Controls.Add(txtCMND);
            grbThongTin.Controls.Add(txtBenhDaPhatHien);
            grbThongTin.Controls.Add(txtDiaChi);
            grbThongTin.Controls.Add(txtHoTen);
            grbThongTin.Controls.Add(txtTimKiem);
            grbThongTin.Controls.Add(txtMaBN);
            grbThongTin.Controls.Add(lblDiaChi);
            grbThongTin.Controls.Add(lblNgayDangKy);
            grbThongTin.Controls.Add(lblNgaySinh);
            grbThongTin.Controls.Add(lblGioiTinh);
            grbThongTin.Controls.Add(lblCCCD);
            grbThongTin.Controls.Add(lblBacSi);
            grbThongTin.Controls.Add(lblHoTen);
            grbThongTin.Controls.Add(lblMaBN);
            grbThongTin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            grbThongTin.ForeColor = Color.FromArgb(0, 122, 204);
            grbThongTin.Location = new Point(15, 15);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(1135, 290);
            grbThongTin.TabIndex = 1;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "THÔNG TIN BỆNH NHÂN";
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.CustomFormat = "dd/MM/yyyy";
            dtpNgayDangKy.Font = new Font("Segoe UI", 10.2F);
            dtpNgayDangKy.Format = DateTimePickerFormat.Custom;
            dtpNgayDangKy.Location = new Point(745, 120);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(260, 30);
            dtpNgayDangKy.TabIndex = 6;
            // 
            // lblBenh
            // 
            lblBenh.AutoSize = true;
            lblBenh.Font = new Font("Segoe UI", 10.2F);
            lblBenh.ForeColor = Color.Black;
            lblBenh.Location = new Point(25, 168);
            lblBenh.Name = "lblBenh";
            lblBenh.Size = new Size(127, 23);
            lblBenh.TabIndex = 5;
            lblBenh.Text = "Bệnh phát hiện";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(41, 128, 185);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(365, 242);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 38);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(0, 122, 204);
            btnTim.Cursor = Cursors.Hand;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(1010, 242);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(95, 38);
            btnTim.TabIndex = 4;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(231, 76, 60);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(255, 242);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 38);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(26, 188, 156);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(585, 242);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 38);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 122, 204);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(145, 242);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 38);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(149, 165, 166);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(475, 242);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 38);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(46, 204, 113);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(35, 242);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 38);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Segoe UI", 10.2F);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(165, 120);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(260, 30);
            dtpNgaySinh.TabIndex = 3;
            // 
            // cboBacSi
            // 
            cboBacSi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBacSi.Font = new Font("Segoe UI", 10.2F);
            cboBacSi.FormattingEnabled = true;
            cboBacSi.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboBacSi.Location = new Point(745, 165);
            cboBacSi.Name = "cboBacSi";
            cboBacSi.Size = new Size(260, 31);
            cboBacSi.TabIndex = 2;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Font = new Font("Segoe UI", 10.2F);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(745, 75);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(260, 31);
            cboGioiTinh.TabIndex = 2;
            // 
            // txtCMND
            // 
            txtCMND.Font = new Font("Segoe UI", 10.2F);
            txtCMND.Location = new Point(165, 75);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(260, 30);
            txtCMND.TabIndex = 1;
            // 
            // txtBenhDaPhatHien
            // 
            txtBenhDaPhatHien.Font = new Font("Segoe UI", 10.2F);
            txtBenhDaPhatHien.Location = new Point(165, 165);
            txtBenhDaPhatHien.Name = "txtBenhDaPhatHien";
            txtBenhDaPhatHien.Size = new Size(260, 30);
            txtBenhDaPhatHien.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 10.2F);
            txtDiaChi.Location = new Point(165, 207);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(840, 30);
            txtDiaChi.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10.2F);
            txtHoTen.Location = new Point(745, 30);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(260, 30);
            txtHoTen.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F);
            txtTimKiem.Location = new Point(745, 247);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(260, 30);
            txtTimKiem.TabIndex = 1;
            // 
            // txtMaBN
            // 
            txtMaBN.Font = new Font("Segoe UI", 10.2F);
            txtMaBN.Location = new Point(165, 30);
            txtMaBN.Name = "txtMaBN";
            txtMaBN.Size = new Size(260, 30);
            txtMaBN.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 10.2F);
            lblDiaChi.ForeColor = Color.Black;
            lblDiaChi.Location = new Point(25, 210);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(62, 23);
            lblDiaChi.TabIndex = 0;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblNgayDangKy
            // 
            lblNgayDangKy.AutoSize = true;
            lblNgayDangKy.Font = new Font("Segoe UI", 10.2F);
            lblNgayDangKy.ForeColor = Color.Black;
            lblNgayDangKy.Location = new Point(600, 125);
            lblNgayDangKy.Name = "lblNgayDangKy";
            lblNgayDangKy.Size = new Size(115, 23);
            lblNgayDangKy.TabIndex = 0;
            lblNgayDangKy.Text = "Ngày đăng ký";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 10.2F);
            lblNgaySinh.ForeColor = Color.Black;
            lblNgaySinh.Location = new Point(25, 125);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(86, 23);
            lblNgaySinh.TabIndex = 0;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 10.2F);
            lblGioiTinh.ForeColor = Color.Black;
            lblGioiTinh.Location = new Point(600, 78);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(75, 23);
            lblGioiTinh.TabIndex = 0;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Font = new Font("Segoe UI", 10.2F);
            lblCCCD.ForeColor = Color.Black;
            lblCCCD.Location = new Point(25, 78);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(113, 23);
            lblCCCD.TabIndex = 0;
            lblCCCD.Text = "CCCD/CMND";
            // 
            // lblBacSi
            // 
            lblBacSi.AutoSize = true;
            lblBacSi.Font = new Font("Segoe UI", 10.2F);
            lblBacSi.ForeColor = Color.Black;
            lblBacSi.Location = new Point(600, 168);
            lblBacSi.Name = "lblBacSi";
            lblBacSi.Size = new Size(132, 23);
            lblBacSi.TabIndex = 0;
            lblBacSi.Text = "Bác sĩ phụ trách";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10.2F);
            lblHoTen.ForeColor = Color.Black;
            lblHoTen.Location = new Point(600, 33);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(62, 23);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // lblMaBN
            // 
            lblMaBN.AutoSize = true;
            lblMaBN.Font = new Font("Segoe UI", 10.2F);
            lblMaBN.ForeColor = Color.Black;
            lblMaBN.Location = new Point(25, 33);
            lblMaBN.Name = "lblMaBN";
            lblMaBN.Size = new Size(122, 23);
            lblMaBN.TabIndex = 0;
            lblMaBN.Text = "Mã bệnh nhân";
            // 
            // grbDanhSach
            // 
            grbDanhSach.Controls.Add(dgvBenhNhan);
            grbDanhSach.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            grbDanhSach.ForeColor = Color.FromArgb(0, 122, 204);
            grbDanhSach.Location = new Point(15, 315);
            grbDanhSach.Name = "grbDanhSach";
            grbDanhSach.Size = new Size(1135, 350);
            grbDanhSach.TabIndex = 2;
            grbDanhSach.TabStop = false;
            grbDanhSach.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // dgvBenhNhan
            // 
            dgvBenhNhan.AllowUserToAddRows = false;
            dgvBenhNhan.AllowUserToDeleteRows = false;
            dgvBenhNhan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            dgvBenhNhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBenhNhan.BackgroundColor = Color.White;
            dgvBenhNhan.BorderStyle = BorderStyle.None;
            dgvBenhNhan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBenhNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBenhNhan.ColumnHeadersHeight = 40;
            dgvBenhNhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBenhNhan.Columns.AddRange(new DataGridViewColumn[] { colMaBN, colHoTen, colCMND, colGioiTinh, colNgaySinh, colDiaChi, colNgayDangKy, colBenh, colBacSi });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBenhNhan.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBenhNhan.EnableHeadersVisualStyles = false;
            dgvBenhNhan.GridColor = Color.FromArgb(224, 224, 224);
            dgvBenhNhan.Location = new Point(20, 35);
            dgvBenhNhan.Name = "dgvBenhNhan";
            dgvBenhNhan.ReadOnly = true;
            dgvBenhNhan.RowHeadersVisible = false;
            dgvBenhNhan.RowHeadersWidth = 51;
            dgvBenhNhan.RowTemplate.Height = 35;
            dgvBenhNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBenhNhan.Size = new Size(1095, 300);
            dgvBenhNhan.TabIndex = 0;
            dgvBenhNhan.CellClick += dgvBenhNhan_CellClick;
            // 
            // colMaBN
            // 
            colMaBN.DataPropertyName = "MaBN";
            colMaBN.FillWeight = 60F;
            colMaBN.HeaderText = "Mã BN";
            colMaBN.MinimumWidth = 6;
            colMaBN.Name = "colMaBN";
            colMaBN.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.FillWeight = 125F;
            colHoTen.HeaderText = "Họ tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            // 
            // colCMND
            // 
            colCMND.DataPropertyName = "CMND";
            colCMND.FillWeight = 105F;
            colCMND.HeaderText = "CMND";
            colCMND.MinimumWidth = 6;
            colCMND.Name = "colCMND";
            colCMND.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.FillWeight = 65F;
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.FillWeight = 90F;
            colNgaySinh.HeaderText = "Ngày sinh ";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.FillWeight = 110F;
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            // 
            // colNgayDangKy
            // 
            colNgayDangKy.DataPropertyName = "NgayDangKy";
            colNgayDangKy.FillWeight = 125F;
            colNgayDangKy.HeaderText = "Ngày đăng ký";
            colNgayDangKy.MinimumWidth = 6;
            colNgayDangKy.Name = "colNgayDangKy";
            colNgayDangKy.ReadOnly = true;
            // 
            // colBenh
            // 
            colBenh.DataPropertyName = "BenhDaPhatHien";
            colBenh.FillWeight = 165F;
            colBenh.HeaderText = "Bệnh phát hiện";
            colBenh.MinimumWidth = 6;
            colBenh.Name = "colBenh";
            colBenh.ReadOnly = true;
            // 
            // colBacSi
            // 
            colBacSi.DataPropertyName = "MaBS";
            colBacSi.FillWeight = 130F;
            colBacSi.HeaderText = "Bác sĩ phụ trách";
            colBacSi.MinimumWidth = 6;
            colBacSi.Name = "colBacSi";
            colBacSi.ReadOnly = true;
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1162, 680);
            Controls.Add(grbDanhSach);
            Controls.Add(grbThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmBenhNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Dữ Liệu Bệnh Nhân";
            Load += frmBenhNhan_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBenhNhan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbThongTin;
        private GroupBox grbDanhSach;
        private Label lblDiaChi;
        private Label lblNgayDangKy;
        private Label lblNgaySinh;
        private Label lblGioiTinh;
        private Label lblCCCD;
        private Label lblHoTen;
        private Label lblMaBN;
        private TextBox txtCMND;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private TextBox txtTimKiem;
        private TextBox txtMaBN;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGioiTinh;
        private Button btnLuu;
        private Button btnTim;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnHuy;
        private Button btnThem;
        private DataGridView dgvBenhNhan;
        private Label lblBenh;
        private TextBox txtBenhDaPhatHien;
        private DateTimePicker dtpNgayDangKy;
        private ComboBox cboBacSi;
        private Label lblBacSi;
        private DataGridViewTextBoxColumn colMaBN;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colCMND;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colNgayDangKy;
        private DataGridViewTextBoxColumn colBenh;
        private DataGridViewTextBoxColumn colBacSi;
    }
}