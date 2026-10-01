namespace HospitalManagement.GUI
{
    partial class frmNhapVien
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
            dtpNgayTra = new DateTimePicker();
            dtpNgayNhan = new DateTimePicker();
            cboKhamBenh = new ComboBox();
            cboGiuong = new ComboBox();
            cboBacSi = new ComboBox();
            lblNgayTra = new Label();
            lblNgayNhan = new Label();
            lblGiuong = new Label();
            lblMaKham = new Label();
            lblBacSi = new Label();
            cboBenhNhan = new ComboBox();
            txtMaNhapVien = new TextBox();
            lblBenhNhan = new Label();
            lblMaNhapVien = new Label();
            grbChucNang = new GroupBox();
            btnLamMoi = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            grbTimKiem = new GroupBox();
            button1 = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            dgvNhapVien = new DataGridView();
            colMaNhapVien = new DataGridViewTextBoxColumn();
            colMaBN = new DataGridViewTextBoxColumn();
            colHoTenBN = new DataGridViewTextBoxColumn();
            colMaBS = new DataGridViewTextBoxColumn();
            colTenBacSi = new DataGridViewTextBoxColumn();
            colMaKham = new DataGridViewTextBoxColumn();
            colMaGiuong = new DataGridViewTextBoxColumn();
            colSoGiuong = new DataGridViewTextBoxColumn();
            colNgayNhan = new DataGridViewTextBoxColumn();
            colNgayTra = new DataGridViewTextBoxColumn();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhapVien).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(dtpNgayTra);
            grbThongTin.Controls.Add(dtpNgayNhan);
            grbThongTin.Controls.Add(cboKhamBenh);
            grbThongTin.Controls.Add(cboGiuong);
            grbThongTin.Controls.Add(cboBacSi);
            grbThongTin.Controls.Add(lblNgayTra);
            grbThongTin.Controls.Add(lblNgayNhan);
            grbThongTin.Controls.Add(lblGiuong);
            grbThongTin.Controls.Add(lblMaKham);
            grbThongTin.Controls.Add(lblBacSi);
            grbThongTin.Controls.Add(cboBenhNhan);
            grbThongTin.Controls.Add(txtMaNhapVien);
            grbThongTin.Controls.Add(lblBenhNhan);
            grbThongTin.Controls.Add(lblMaNhapVien);
            grbThongTin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbThongTin.ForeColor = Color.FromArgb(0, 122, 204);
            grbThongTin.Location = new Point(20, 20);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(1335, 250);
            grbThongTin.TabIndex = 0;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "THÔNG TIN NHẬP VIÊN";
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayTra.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.Location = new Point(170, 190);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.ShowCheckBox = true;
            dtpNgayTra.Size = new Size(350, 30);
            dtpNgayTra.TabIndex = 6;
            // 
            // dtpNgayNhan
            // 
            dtpNgayNhan.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayNhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayNhan.Format = DateTimePickerFormat.Custom;
            dtpNgayNhan.Location = new Point(780, 140);
            dtpNgayNhan.Name = "dtpNgayNhan";
            dtpNgayNhan.Size = new Size(350, 30);
            dtpNgayNhan.TabIndex = 5;
            // 
            // cboKhamBenh
            // 
            cboKhamBenh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhamBenh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cboKhamBenh.FormattingEnabled = true;
            cboKhamBenh.Location = new Point(780, 90);
            cboKhamBenh.Name = "cboKhamBenh";
            cboKhamBenh.Size = new Size(350, 31);
            cboKhamBenh.TabIndex = 4;
            // 
            // cboGiuong
            // 
            cboGiuong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGiuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cboGiuong.FormattingEnabled = true;
            cboGiuong.Location = new Point(170, 140);
            cboGiuong.Name = "cboGiuong";
            cboGiuong.Size = new Size(350, 31);
            cboGiuong.TabIndex = 4;
            // 
            // cboBacSi
            // 
            cboBacSi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBacSi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cboBacSi.FormattingEnabled = true;
            cboBacSi.Location = new Point(170, 90);
            cboBacSi.Name = "cboBacSi";
            cboBacSi.Size = new Size(350, 31);
            cboBacSi.TabIndex = 4;
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgayTra.ForeColor = Color.Black;
            lblNgayTra.Location = new Point(35, 195);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(76, 23);
            lblNgayTra.TabIndex = 3;
            lblNgayTra.Text = "Ngày trả";
            // 
            // lblNgayNhan
            // 
            lblNgayNhan.AutoSize = true;
            lblNgayNhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgayNhan.ForeColor = Color.Black;
            lblNgayNhan.Location = new Point(610, 145);
            lblNgayNhan.Name = "lblNgayNhan";
            lblNgayNhan.Size = new Size(93, 23);
            lblNgayNhan.TabIndex = 3;
            lblNgayNhan.Text = "Ngày nhận";
            // 
            // lblGiuong
            // 
            lblGiuong.AutoSize = true;
            lblGiuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblGiuong.ForeColor = Color.Black;
            lblGiuong.Location = new Point(35, 145);
            lblGiuong.Name = "lblGiuong";
            lblGiuong.Size = new Size(67, 23);
            lblGiuong.TabIndex = 3;
            lblGiuong.Text = "Giường";
            // 
            // lblMaKham
            // 
            lblMaKham.AutoSize = true;
            lblMaKham.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaKham.ForeColor = Color.Black;
            lblMaKham.Location = new Point(610, 93);
            lblMaKham.Name = "lblMaKham";
            lblMaKham.Size = new Size(99, 23);
            lblMaKham.TabIndex = 3;
            lblMaKham.Text = "Phiếu khám";
            // 
            // lblBacSi
            // 
            lblBacSi.AutoSize = true;
            lblBacSi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBacSi.ForeColor = Color.Black;
            lblBacSi.Location = new Point(35, 93);
            lblBacSi.Name = "lblBacSi";
            lblBacSi.Size = new Size(54, 23);
            lblBacSi.TabIndex = 3;
            lblBacSi.Text = "Bác sĩ";
            // 
            // cboBenhNhan
            // 
            cboBenhNhan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBenhNhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cboBenhNhan.FormattingEnabled = true;
            cboBenhNhan.Location = new Point(780, 40);
            cboBenhNhan.Name = "cboBenhNhan";
            cboBenhNhan.Size = new Size(350, 31);
            cboBenhNhan.TabIndex = 2;
            // 
            // txtMaNhapVien
            // 
            txtMaNhapVien.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNhapVien.Location = new Point(170, 40);
            txtMaNhapVien.Name = "txtMaNhapVien";
            txtMaNhapVien.Size = new Size(350, 30);
            txtMaNhapVien.TabIndex = 1;
            // 
            // lblBenhNhan
            // 
            lblBenhNhan.AutoSize = true;
            lblBenhNhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBenhNhan.ForeColor = Color.Black;
            lblBenhNhan.Location = new Point(610, 43);
            lblBenhNhan.Name = "lblBenhNhan";
            lblBenhNhan.Size = new Size(95, 23);
            lblBenhNhan.TabIndex = 0;
            lblBenhNhan.Text = "Bệnh nhân";
            // 
            // lblMaNhapVien
            // 
            lblMaNhapVien.AutoSize = true;
            lblMaNhapVien.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaNhapVien.ForeColor = Color.Black;
            lblMaNhapVien.Location = new Point(35, 43);
            lblMaNhapVien.Name = "lblMaNhapVien";
            lblMaNhapVien.Size = new Size(115, 23);
            lblMaNhapVien.TabIndex = 0;
            lblMaNhapVien.Text = "Mã nhập viện";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnLamMoi);
            grbChucNang.Controls.Add(btnHuy);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnLuu);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbChucNang.ForeColor = Color.FromArgb(0, 122, 204);
            grbChucNang.Location = new Point(20, 290);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(1335, 85);
            grbChucNang.TabIndex = 1;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "BẢNG CHỨC NĂNG";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(46, 204, 113);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(170, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 122, 204);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(310, 30);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 40);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(231, 76, 60);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(450, 30);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 40);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(41, 128, 185);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(590, 30);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 40);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(149, 165, 166);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(730, 30);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 40);
            btnHuy.TabIndex = 0;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(26, 188, 156);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(870, 30);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 40);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // grbTimKiem
            // 
            grbTimKiem.Controls.Add(button1);
            grbTimKiem.Controls.Add(txtTimKiem);
            grbTimKiem.Controls.Add(lblTimKiem);
            grbTimKiem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbTimKiem.ForeColor = Color.FromArgb(0, 122, 204);
            grbTimKiem.Location = new Point(20, 390);
            grbTimKiem.Name = "grbTimKiem";
            grbTimKiem.Size = new Size(1335, 80);
            grbTimKiem.TabIndex = 2;
            grbTimKiem.TabStop = false;
            grbTimKiem.Text = "TÌM KIẾM";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(125, 33);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(395, 30);
            txtTimKiem.TabIndex = 3;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimKiem.ForeColor = Color.Black;
            lblTimKiem.Location = new Point(35, 36);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(71, 23);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Từ khóa";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(540, 28);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 4;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvNhapVien
            // 
            dgvNhapVien.AllowUserToAddRows = false;
            dgvNhapVien.AllowUserToDeleteRows = false;
            dgvNhapVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            dgvNhapVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhapVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhapVien.BackgroundColor = Color.White;
            dgvNhapVien.BorderStyle = BorderStyle.None;
            dgvNhapVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNhapVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNhapVien.ColumnHeadersHeight = 45;
            dgvNhapVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhapVien.Columns.AddRange(new DataGridViewColumn[] { colMaNhapVien, colMaBN, colHoTenBN, colMaBS, colTenBacSi, colMaKham, colMaGiuong, colSoGiuong, colNgayNhan, colNgayTra });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNhapVien.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNhapVien.EnableHeadersVisualStyles = false;
            dgvNhapVien.GridColor = Color.FromArgb(224, 224, 224);
            dgvNhapVien.Location = new Point(20, 490);
            dgvNhapVien.MultiSelect = false;
            dgvNhapVien.Name = "dgvNhapVien";
            dgvNhapVien.ReadOnly = true;
            dgvNhapVien.RowHeadersVisible = false;
            dgvNhapVien.RowHeadersWidth = 35;
            dgvNhapVien.RowTemplate.Height = 35;
            dgvNhapVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhapVien.Size = new Size(1335, 340);
            dgvNhapVien.TabIndex = 3;
            dgvNhapVien.CellClick += dgvNhapVien_CellClick;
            // 
            // colMaNhapVien
            // 
            colMaNhapVien.DataPropertyName = "MaNhapVien";
            colMaNhapVien.FillWeight = 95F;
            colMaNhapVien.HeaderText = "Mã nhập viện ";
            colMaNhapVien.MinimumWidth = 6;
            colMaNhapVien.Name = "colMaNhapVien";
            colMaNhapVien.ReadOnly = true;
            // 
            // colMaBN
            // 
            colMaBN.DataPropertyName = "MaBN";
            colMaBN.FillWeight = 90F;
            colMaBN.HeaderText = "Mã bệnh nhân";
            colMaBN.MinimumWidth = 6;
            colMaBN.Name = "colMaBN";
            colMaBN.ReadOnly = true;
            // 
            // colHoTenBN
            // 
            colHoTenBN.DataPropertyName = "HoTen";
            colHoTenBN.FillWeight = 165F;
            colHoTenBN.HeaderText = "Họ tên bệnh nhân ";
            colHoTenBN.MinimumWidth = 6;
            colHoTenBN.Name = "colHoTenBN";
            colHoTenBN.ReadOnly = true;
            // 
            // colMaBS
            // 
            colMaBS.DataPropertyName = "MaBS";
            colMaBS.FillWeight = 80F;
            colMaBS.HeaderText = "Mã bác sĩ";
            colMaBS.MinimumWidth = 6;
            colMaBS.Name = "colMaBS";
            colMaBS.ReadOnly = true;
            // 
            // colTenBacSi
            // 
            colTenBacSi.DataPropertyName = "TenBacSi";
            colTenBacSi.FillWeight = 150F;
            colTenBacSi.HeaderText = "Tên bác sĩ";
            colTenBacSi.MinimumWidth = 6;
            colTenBacSi.Name = "colTenBacSi";
            colTenBacSi.ReadOnly = true;
            // 
            // colMaKham
            // 
            colMaKham.DataPropertyName = "MaKham";
            colMaKham.FillWeight = 85F;
            colMaKham.HeaderText = "Mã khám";
            colMaKham.MinimumWidth = 6;
            colMaKham.Name = "colMaKham";
            colMaKham.ReadOnly = true;
            // 
            // colMaGiuong
            // 
            colMaGiuong.DataPropertyName = "MaGiuong";
            colMaGiuong.FillWeight = 80F;
            colMaGiuong.HeaderText = "Mã giường";
            colMaGiuong.MinimumWidth = 6;
            colMaGiuong.Name = "colMaGiuong";
            colMaGiuong.ReadOnly = true;
            // 
            // colSoGiuong
            // 
            colSoGiuong.DataPropertyName = "SoGiuong";
            colSoGiuong.FillWeight = 75F;
            colSoGiuong.HeaderText = "Số giường";
            colSoGiuong.MinimumWidth = 6;
            colSoGiuong.Name = "colSoGiuong";
            colSoGiuong.ReadOnly = true;
            // 
            // colNgayNhan
            // 
            colNgayNhan.DataPropertyName = "NgayNhan";
            colNgayNhan.FillWeight = 120F;
            colNgayNhan.HeaderText = "Ngày nhận";
            colNgayNhan.MinimumWidth = 6;
            colNgayNhan.Name = "colNgayNhan";
            colNgayNhan.ReadOnly = true;
            // 
            // colNgayTra
            // 
            colNgayTra.DataPropertyName = "NgayTra";
            colNgayTra.FillWeight = 120F;
            colNgayTra.HeaderText = "Ngày trả";
            colNgayTra.MinimumWidth = 6;
            colNgayTra.Name = "colNgayTra";
            colNgayTra.ReadOnly = true;
            // 
            // frmNhapVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 853);
            Controls.Add(dgvNhapVien);
            Controls.Add(grbTimKiem);
            Controls.Add(grbChucNang);
            Controls.Add(grbThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmNhapVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhập Viện - Hệ Thống Bệnh Viện";
            Load += frmNhapVien_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            grbTimKiem.ResumeLayout(false);
            grbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhapVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbThongTin;
        private ComboBox cboBenhNhan;
        private TextBox txtMaNhapVien;
        private Label lblBenhNhan;
        private Label lblMaNhapVien;
        private Label lblBacSi;
        private DateTimePicker dtpNgayNhan;
        private ComboBox cboKhamBenh;
        private ComboBox cboGiuong;
        private ComboBox cboBacSi;
        private Label lblNgayTra;
        private Label lblNgayNhan;
        private Label lblGiuong;
        private Label lblMaKham;
        private DateTimePicker dtpNgayTra;
        private GroupBox grbChucNang;
        private Button btnLamMoi;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnThem;
        private GroupBox grbTimKiem;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button button1;
        private DataGridView dgvNhapVien;
        private DataGridViewTextBoxColumn colMaNhapVien;
        private DataGridViewTextBoxColumn colMaBN;
        private DataGridViewTextBoxColumn colHoTenBN;
        private DataGridViewTextBoxColumn colMaBS;
        private DataGridViewTextBoxColumn colTenBacSi;
        private DataGridViewTextBoxColumn colMaKham;
        private DataGridViewTextBoxColumn colMaGiuong;
        private DataGridViewTextBoxColumn colSoGiuong;
        private DataGridViewTextBoxColumn colNgayNhan;
        private DataGridViewTextBoxColumn colNgayTra;
    }
}