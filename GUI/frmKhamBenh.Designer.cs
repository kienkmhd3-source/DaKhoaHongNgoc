namespace HospitalManagement.GUI
{
    partial class frmKhamBenh
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
            rtbKetLuan = new RichTextBox();
            lblKetLuan = new Label();
            rtbDonThuoc = new RichTextBox();
            rtbChanDoan = new RichTextBox();
            rtbTrieuChung = new RichTextBox();
            dtpThoiDiem = new DateTimePicker();
            cboBacSi = new ComboBox();
            cboBenhNhan = new ComboBox();
            lblChanDoan = new Label();
            lblThoiDiem = new Label();
            lblDonThuoc = new Label();
            lblBacSi = new Label();
            lblTrieuChung = new Label();
            lblBenhNhan = new Label();
            txtMaKham = new TextBox();
            lblMaKham = new Label();
            grbChucNang = new GroupBox();
            btnLamMoi = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            dgvKhamBenh = new DataGridView();
            colMaKham = new DataGridViewTextBoxColumn();
            colMaBN = new DataGridViewTextBoxColumn();
            colMaBS = new DataGridViewTextBoxColumn();
            colThoiDiemKham = new DataGridViewTextBoxColumn();
            colTrieuChung = new DataGridViewTextBoxColumn();
            colChanDoan = new DataGridViewTextBoxColumn();
            colDonThuoc = new DataGridViewTextBoxColumn();
            colKetLuan = new DataGridViewTextBoxColumn();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhamBenh).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(rtbKetLuan);
            grbThongTin.Controls.Add(lblKetLuan);
            grbThongTin.Controls.Add(rtbDonThuoc);
            grbThongTin.Controls.Add(rtbChanDoan);
            grbThongTin.Controls.Add(rtbTrieuChung);
            grbThongTin.Controls.Add(dtpThoiDiem);
            grbThongTin.Controls.Add(cboBacSi);
            grbThongTin.Controls.Add(cboBenhNhan);
            grbThongTin.Controls.Add(lblChanDoan);
            grbThongTin.Controls.Add(lblThoiDiem);
            grbThongTin.Controls.Add(lblDonThuoc);
            grbThongTin.Controls.Add(lblBacSi);
            grbThongTin.Controls.Add(lblTrieuChung);
            grbThongTin.Controls.Add(lblBenhNhan);
            grbThongTin.Controls.Add(txtMaKham);
            grbThongTin.Controls.Add(lblMaKham);
            grbThongTin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbThongTin.ForeColor = Color.FromArgb(0, 122, 204);
            grbThongTin.Location = new Point(15, 15);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(1060, 340);
            grbThongTin.TabIndex = 0;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "THÔNG TIN KHÁM BỆNH";
            // 
            // rtbKetLuan
            // 
            rtbKetLuan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rtbKetLuan.Location = new Point(680, 235);
            rtbKetLuan.Name = "rtbKetLuan";
            rtbKetLuan.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbKetLuan.Size = new Size(350, 80);
            rtbKetLuan.TabIndex = 7;
            rtbKetLuan.Text = "";
            // 
            // lblKetLuan
            // 
            lblKetLuan.AutoSize = true;
            lblKetLuan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblKetLuan.ForeColor = Color.Black;
            lblKetLuan.Location = new Point(540, 238);
            lblKetLuan.Name = "lblKetLuan";
            lblKetLuan.Size = new Size(74, 23);
            lblKetLuan.TabIndex = 9;
            lblKetLuan.Text = "Kết luận";
            // 
            // rtbDonThuoc
            // 
            rtbDonThuoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rtbDonThuoc.Location = new Point(140, 235);
            rtbDonThuoc.Name = "rtbDonThuoc";
            rtbDonThuoc.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbDonThuoc.Size = new Size(350, 80);
            rtbDonThuoc.TabIndex = 6;
            rtbDonThuoc.Text = "";
            // 
            // rtbChanDoan
            // 
            rtbChanDoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rtbChanDoan.Location = new Point(680, 135);
            rtbChanDoan.Name = "rtbChanDoan";
            rtbChanDoan.Size = new Size(350, 80);
            rtbChanDoan.TabIndex = 5;
            rtbChanDoan.Text = "";
            // 
            // rtbTrieuChung
            // 
            rtbTrieuChung.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rtbTrieuChung.Location = new Point(140, 135);
            rtbTrieuChung.Name = "rtbTrieuChung";
            rtbTrieuChung.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbTrieuChung.Size = new Size(350, 80);
            rtbTrieuChung.TabIndex = 4;
            rtbTrieuChung.Text = "";
            // 
            // dtpThoiDiem
            // 
            dtpThoiDiem.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpThoiDiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpThoiDiem.Format = DateTimePickerFormat.Custom;
            dtpThoiDiem.Location = new Point(680, 85);
            dtpThoiDiem.Name = "dtpThoiDiem";
            dtpThoiDiem.Size = new Size(350, 30);
            dtpThoiDiem.TabIndex = 3;
            // 
            // cboBacSi
            // 
            cboBacSi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBacSi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cboBacSi.FormattingEnabled = true;
            cboBacSi.Location = new Point(140, 85);
            cboBacSi.Name = "cboBacSi";
            cboBacSi.Size = new Size(350, 31);
            cboBacSi.TabIndex = 2;
            // 
            // cboBenhNhan
            // 
            cboBenhNhan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBenhNhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cboBenhNhan.FormattingEnabled = true;
            cboBenhNhan.Location = new Point(680, 40);
            cboBenhNhan.Name = "cboBenhNhan";
            cboBenhNhan.Size = new Size(350, 31);
            cboBenhNhan.TabIndex = 1;
            // 
            // lblChanDoan
            // 
            lblChanDoan.AutoSize = true;
            lblChanDoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblChanDoan.ForeColor = Color.Black;
            lblChanDoan.Location = new Point(540, 138);
            lblChanDoan.Name = "lblChanDoan";
            lblChanDoan.Size = new Size(93, 23);
            lblChanDoan.TabIndex = 2;
            lblChanDoan.Text = "Chẩn đoán";
            // 
            // lblThoiDiem
            // 
            lblThoiDiem.AutoSize = true;
            lblThoiDiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblThoiDiem.ForeColor = Color.Black;
            lblThoiDiem.Location = new Point(540, 88);
            lblThoiDiem.Name = "lblThoiDiem";
            lblThoiDiem.Size = new Size(135, 23);
            lblThoiDiem.TabIndex = 2;
            lblThoiDiem.Text = "Thời điểm khám";
            // 
            // lblDonThuoc
            // 
            lblDonThuoc.AutoSize = true;
            lblDonThuoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDonThuoc.ForeColor = Color.Black;
            lblDonThuoc.Location = new Point(25, 238);
            lblDonThuoc.Name = "lblDonThuoc";
            lblDonThuoc.Size = new Size(89, 23);
            lblDonThuoc.TabIndex = 2;
            lblDonThuoc.Text = "Đơn thuốc";
            // 
            // lblBacSi
            // 
            lblBacSi.AutoSize = true;
            lblBacSi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBacSi.ForeColor = Color.Black;
            lblBacSi.Location = new Point(25, 88);
            lblBacSi.Name = "lblBacSi";
            lblBacSi.Size = new Size(54, 23);
            lblBacSi.TabIndex = 2;
            lblBacSi.Text = "Bác sĩ";
            // 
            // lblTrieuChung
            // 
            lblTrieuChung.AutoSize = true;
            lblTrieuChung.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTrieuChung.ForeColor = Color.Black;
            lblTrieuChung.Location = new Point(25, 138);
            lblTrieuChung.Name = "lblTrieuChung";
            lblTrieuChung.Size = new Size(100, 23);
            lblTrieuChung.TabIndex = 2;
            lblTrieuChung.Text = "Triệu chứng";
            // 
            // lblBenhNhan
            // 
            lblBenhNhan.AutoSize = true;
            lblBenhNhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBenhNhan.ForeColor = Color.Black;
            lblBenhNhan.Location = new Point(540, 43);
            lblBenhNhan.Name = "lblBenhNhan";
            lblBenhNhan.Size = new Size(95, 23);
            lblBenhNhan.TabIndex = 2;
            lblBenhNhan.Text = "Bệnh nhân";
            // 
            // txtMaKham
            // 
            txtMaKham.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKham.Location = new Point(140, 40);
            txtMaKham.Name = "txtMaKham";
            txtMaKham.Size = new Size(350, 30);
            txtMaKham.TabIndex = 0;
            // 
            // lblMaKham
            // 
            lblMaKham.AutoSize = true;
            lblMaKham.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaKham.ForeColor = Color.Black;
            lblMaKham.Location = new Point(25, 43);
            lblMaKham.Name = "lblMaKham";
            lblMaKham.Size = new Size(82, 23);
            lblMaKham.TabIndex = 0;
            lblMaKham.Text = "Mã khám";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnLamMoi);
            grbChucNang.Controls.Add(btnHuy);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnLuu);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbChucNang.ForeColor = Color.FromArgb(0, 122, 204);
            grbChucNang.Location = new Point(15, 365);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(1060, 85);
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
            btnThem.Location = new Point(120, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 40);
            btnThem.TabIndex = 8;
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
            btnSua.Location = new Point(260, 30);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 40);
            btnSua.TabIndex = 9;
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
            btnXoa.Location = new Point(400, 30);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 40);
            btnXoa.TabIndex = 10;
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
            btnLuu.Location = new Point(540, 30);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 40);
            btnLuu.TabIndex = 11;
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
            btnHuy.Location = new Point(680, 30);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 40);
            btnHuy.TabIndex = 12;
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
            btnLamMoi.Location = new Point(820, 30);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 40);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimKiem.Location = new Point(25, 473);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(80, 23);
            lblTimKiem.TabIndex = 2;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(125, 470);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(350, 30);
            txtTimKiem.TabIndex = 14;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(0, 122, 204);
            btnTim.Cursor = Cursors.Hand;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(495, 466);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(100, 38);
            btnTim.TabIndex = 15;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // dgvKhamBenh
            // 
            dgvKhamBenh.AllowUserToAddRows = false;
            dgvKhamBenh.AllowUserToDeleteRows = false;
            dgvKhamBenh.AllowUserToResizeColumns = false;
            dgvKhamBenh.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            dgvKhamBenh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhamBenh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhamBenh.BackgroundColor = Color.White;
            dgvKhamBenh.BorderStyle = BorderStyle.None;
            dgvKhamBenh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKhamBenh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKhamBenh.ColumnHeadersHeight = 45;
            dgvKhamBenh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKhamBenh.Columns.AddRange(new DataGridViewColumn[] { colMaKham, colMaBN, colMaBS, colThoiDiemKham, colTrieuChung, colChanDoan, colDonThuoc, colKetLuan });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvKhamBenh.DefaultCellStyle = dataGridViewCellStyle3;
            dgvKhamBenh.EnableHeadersVisualStyles = false;
            dgvKhamBenh.GridColor = Color.FromArgb(224, 224, 224);
            dgvKhamBenh.Location = new Point(15, 520);
            dgvKhamBenh.MultiSelect = false;
            dgvKhamBenh.Name = "dgvKhamBenh";
            dgvKhamBenh.ReadOnly = true;
            dgvKhamBenh.RowHeadersVisible = false;
            dgvKhamBenh.RowHeadersWidth = 50;
            dgvKhamBenh.RowTemplate.Height = 35;
            dgvKhamBenh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhamBenh.Size = new Size(1060, 245);
            dgvKhamBenh.TabIndex = 16;
            dgvKhamBenh.CellClick += dgvKhamBenh_CellClick;
            // 
            // colMaKham
            // 
            colMaKham.DataPropertyName = "MaKham";
            colMaKham.FillWeight = 80F;
            colMaKham.HeaderText = "Mã khám";
            colMaKham.MinimumWidth = 6;
            colMaKham.Name = "colMaKham";
            colMaKham.ReadOnly = true;
            // 
            // colMaBN
            // 
            colMaBN.DataPropertyName = "MaBN";
            colMaBN.FillWeight = 110F;
            colMaBN.HeaderText = "Mã bệnh nhân";
            colMaBN.MinimumWidth = 6;
            colMaBN.Name = "colMaBN";
            colMaBN.ReadOnly = true;
            // 
            // colMaBS
            // 
            colMaBS.DataPropertyName = "MaBS";
            colMaBS.FillWeight = 95F;
            colMaBS.HeaderText = "Mã bác sĩ";
            colMaBS.MinimumWidth = 6;
            colMaBS.Name = "colMaBS";
            colMaBS.ReadOnly = true;
            // 
            // colThoiDiemKham
            // 
            colThoiDiemKham.DataPropertyName = "ThoiDiemKham";
            colThoiDiemKham.FillWeight = 125F;
            colThoiDiemKham.HeaderText = "Thời điểm khám";
            colThoiDiemKham.MinimumWidth = 6;
            colThoiDiemKham.Name = "colThoiDiemKham";
            colThoiDiemKham.ReadOnly = true;
            // 
            // colTrieuChung
            // 
            colTrieuChung.DataPropertyName = "TrieuChung";
            colTrieuChung.FillWeight = 150F;
            colTrieuChung.HeaderText = "Triệu chứng";
            colTrieuChung.MinimumWidth = 6;
            colTrieuChung.Name = "colTrieuChung";
            colTrieuChung.ReadOnly = true;
            // 
            // colChanDoan
            // 
            colChanDoan.DataPropertyName = "ChanDoan";
            colChanDoan.FillWeight = 150F;
            colChanDoan.HeaderText = "Chẩn đoán";
            colChanDoan.MinimumWidth = 6;
            colChanDoan.Name = "colChanDoan";
            colChanDoan.ReadOnly = true;
            // 
            // colDonThuoc
            // 
            colDonThuoc.DataPropertyName = "DonThuoc";
            colDonThuoc.FillWeight = 150F;
            colDonThuoc.HeaderText = "Đơn thuốc";
            colDonThuoc.MinimumWidth = 100;
            colDonThuoc.Name = "colDonThuoc";
            colDonThuoc.ReadOnly = true;
            // 
            // colKetLuan
            // 
            colKetLuan.DataPropertyName = "KetLuan";
            colKetLuan.FillWeight = 150F;
            colKetLuan.HeaderText = "Kết luận";
            colKetLuan.MinimumWidth = 100;
            colKetLuan.Name = "colKetLuan";
            colKetLuan.ReadOnly = true;
            // 
            // frmKhamBenh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1090, 785);
            Controls.Add(dgvKhamBenh);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(grbChucNang);
            Controls.Add(grbThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmKhamBenh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Khám Bệnh - Hệ Thống";
            Load += frmKhamBenh_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhamBenh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbThongTin;
        private TextBox txtMaKham;
        private Label lblMaKham;
        private Label lblChanDoan;
        private Label lblThoiDiem;
        private Label lblDonThuoc;
        private Label lblBacSi;
        private Label lblTrieuChung;
        private Label lblBenhNhan;
        private ComboBox cboBenhNhan;
        private RichTextBox rtbDonThuoc;
        private RichTextBox rtbChanDoan;
        private RichTextBox rtbTrieuChung;
        private DateTimePicker dtpThoiDiem;
        private ComboBox cboBacSi;
        private GroupBox grbChucNang;
        private Button btnThem;
        private Button btnLamMoi;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTim;
        private DataGridView dgvKhamBenh;
        private Label lblKetLuan;
        private RichTextBox rtbKetLuan;
        private DataGridViewTextBoxColumn colMaKham;
        private DataGridViewTextBoxColumn colMaBN;
        private DataGridViewTextBoxColumn colMaBS;
        private DataGridViewTextBoxColumn colThoiDiemKham;
        private DataGridViewTextBoxColumn colTrieuChung;
        private DataGridViewTextBoxColumn colChanDoan;
        private DataGridViewTextBoxColumn colDonThuoc;
        private DataGridViewTextBoxColumn colKetLuan;
    }
}