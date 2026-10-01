namespace HospitalManagement.GUI
{
    partial class frmTaiKhoan
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
            cboVaiTro = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            lblVaiTro = new Label();
            lblTenDangNhap = new Label();
            grbChucNang = new GroupBox();
            btnHuy = new Button();
            btnLamMoi = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            grbDanhSach = new GroupBox();
            dgvTaiKhoan = new DataGridView();
            colTenDangNhap = new DataGridViewTextBoxColumn();
            colMatKhau = new DataGridViewTextBoxColumn();
            colVaiTro = new DataGridViewTextBoxColumn();
            btnTim = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(cboVaiTro);
            grbThongTin.Controls.Add(txtMatKhau);
            grbThongTin.Controls.Add(txtTenDangNhap);
            grbThongTin.Controls.Add(lblMatKhau);
            grbThongTin.Controls.Add(lblVaiTro);
            grbThongTin.Controls.Add(lblTenDangNhap);
            grbThongTin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            grbThongTin.ForeColor = Color.FromArgb(0, 122, 204);
            grbThongTin.Location = new Point(20, 20);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(380, 220);
            grbThongTin.TabIndex = 0;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // cboVaiTro
            // 
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVaiTro.Font = new Font("Segoe UI", 10.2F);
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(160, 150);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(190, 31);
            cboVaiTro.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10.2F);
            txtMatKhau.Location = new Point(160, 100);
            txtMatKhau.MaxLength = 30;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(190, 30);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 10.2F);
            txtTenDangNhap.Location = new Point(160, 50);
            txtTenDangNhap.MaxLength = 30;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(190, 30);
            txtTenDangNhap.TabIndex = 2;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10.2F);
            lblMatKhau.ForeColor = Color.Black;
            lblMatKhau.Location = new Point(20, 103);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(82, 23);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Font = new Font("Segoe UI", 10.2F);
            lblVaiTro.ForeColor = Color.Black;
            lblVaiTro.Location = new Point(20, 153);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(60, 23);
            lblVaiTro.TabIndex = 0;
            lblVaiTro.Text = "Vai trò";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 10.2F);
            lblTenDangNhap.ForeColor = Color.Black;
            lblTenDangNhap.Location = new Point(20, 53);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(124, 23);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnHuy);
            grbChucNang.Controls.Add(btnLamMoi);
            grbChucNang.Controls.Add(btnLuu);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            grbChucNang.ForeColor = Color.FromArgb(0, 122, 204);
            grbChucNang.Location = new Point(20, 260);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(380, 260);
            grbChucNang.TabIndex = 1;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "CHỨC NĂNG";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(149, 165, 166);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(35, 185);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(140, 45);
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
            btnLamMoi.Location = new Point(205, 185);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(140, 45);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(41, 128, 185);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(205, 115);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(140, 45);
            btnLuu.TabIndex = 0;
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
            btnXoa.Location = new Point(35, 115);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(140, 45);
            btnXoa.TabIndex = 0;
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
            btnSua.Location = new Point(205, 45);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(140, 45);
            btnSua.TabIndex = 0;
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
            btnThem.Location = new Point(35, 45);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(140, 45);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // grbDanhSach
            // 
            grbDanhSach.Controls.Add(dgvTaiKhoan);
            grbDanhSach.Controls.Add(btnTim);
            grbDanhSach.Controls.Add(txtTimKiem);
            grbDanhSach.Controls.Add(lblTimKiem);
            grbDanhSach.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            grbDanhSach.ForeColor = Color.FromArgb(0, 122, 204);
            grbDanhSach.Location = new Point(420, 20);
            grbDanhSach.Name = "grbDanhSach";
            grbDanhSach.Size = new Size(640, 500);
            grbDanhSach.TabIndex = 2;
            grbDanhSach.TabStop = false;
            grbDanhSach.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.BackgroundColor = Color.White;
            dgvTaiKhoan.BorderStyle = BorderStyle.None;
            dgvTaiKhoan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTaiKhoan.ColumnHeadersHeight = 40;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { colTenDangNhap, colMatKhau, colVaiTro });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTaiKhoan.EnableHeadersVisualStyles = false;
            dgvTaiKhoan.GridColor = Color.FromArgb(224, 224, 224);
            dgvTaiKhoan.Location = new Point(20, 95);
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.RowTemplate.Height = 35;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(600, 385);
            dgvTaiKhoan.TabIndex = 3;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.DataPropertyName = "TenDangNhap";
            colTenDangNhap.FillWeight = 40F;
            colTenDangNhap.HeaderText = "Tên đăng nhập";
            colTenDangNhap.MinimumWidth = 6;
            colTenDangNhap.Name = "colTenDangNhap";
            colTenDangNhap.ReadOnly = true;
            // 
            // colMatKhau
            // 
            colMatKhau.DataPropertyName = "MatKhau";
            colMatKhau.FillWeight = 30F;
            colMatKhau.HeaderText = "Mật khẩu";
            colMatKhau.MinimumWidth = 6;
            colMatKhau.Name = "colMatKhau";
            colMatKhau.ReadOnly = true;
            // 
            // colVaiTro
            // 
            colVaiTro.DataPropertyName = "VaiTro";
            colVaiTro.FillWeight = 30F;
            colVaiTro.HeaderText = "Vai trò";
            colVaiTro.MinimumWidth = 6;
            colVaiTro.Name = "colVaiTro";
            colVaiTro.ReadOnly = true;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(0, 122, 204);
            btnTim.Cursor = Cursors.Hand;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(510, 36);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(110, 38);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F);
            txtTimKiem.Location = new Point(105, 40);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(380, 30);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 10.2F);
            lblTimKiem.ForeColor = Color.Black;
            lblTimKiem.Location = new Point(20, 43);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(79, 23);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // frmTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1082, 553);
            Controls.Add(grbDanhSach);
            Controls.Add(grbChucNang);
            Controls.Add(grbThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tài Khoản - Hệ Thống";
            Load += frmTaiKhoan_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            grbDanhSach.ResumeLayout(false);
            grbDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbThongTin;
        private Label lblMatKhau;
        private Label lblVaiTro;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private ComboBox cboVaiTro;
        private GroupBox grbChucNang;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnHuy;
        private Button btnLamMoi;
        private Button btnLuu;
        private GroupBox grbDanhSach;
        private Button btnTim;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private DataGridView dgvTaiKhoan;
        private DataGridViewTextBoxColumn colTenDangNhap;
        private DataGridViewTextBoxColumn colMatKhau;
        private DataGridViewTextBoxColumn colVaiTro;
    }
}