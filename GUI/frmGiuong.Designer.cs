namespace HospitalManagement.GUI
{
    partial class frmGiuong
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
            cboPhong = new ComboBox();
            txtSoGiuong = new TextBox();
            txtMaGiuong = new TextBox();
            lblSoGiuong = new Label();
            lblPhong = new Label();
            lblTrangThai = new Label();
            lblMaGiuong = new Label();
            cboTrangThai = new ComboBox();
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
            dgvGiuong = new DataGridView();
            colMaGiuong = new DataGridViewTextBoxColumn();
            colSoGiuong = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colTenPhong = new DataGridViewTextBoxColumn();
            colMaPhong = new DataGridViewTextBoxColumn();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiuong).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(cboTrangThai);
            grbThongTin.Controls.Add(cboPhong);
            grbThongTin.Controls.Add(txtSoGiuong);
            grbThongTin.Controls.Add(txtMaGiuong);
            grbThongTin.Controls.Add(lblSoGiuong);
            grbThongTin.Controls.Add(lblPhong);
            grbThongTin.Controls.Add(lblTrangThai);
            grbThongTin.Controls.Add(lblMaGiuong);
            grbThongTin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbThongTin.ForeColor = Color.FromArgb(0, 122, 204);
            grbThongTin.Location = new Point(15, 15);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(950, 140);
            grbThongTin.TabIndex = 0;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "THÔNG TIN GIƯỜNG";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Trống", "Đang sử dụng", "Bảo trì" });
            cboTrangThai.Location = new Point(560, 36);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(260, 31);
            cboTrangThai.TabIndex = 1;
            // 
            // cboPhong
            // 
            cboPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cboPhong.FormattingEnabled = true;
            cboPhong.Items.AddRange(new object[] { "" });
            cboPhong.Location = new Point(560, 85);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(260, 31);
            cboPhong.TabIndex = 1;
            // 
            // txtSoGiuong
            // 
            txtSoGiuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoGiuong.Location = new Point(135, 85);
            txtSoGiuong.Name = "txtSoGiuong";
            txtSoGiuong.Size = new Size(240, 30);
            txtSoGiuong.TabIndex = 1;
            txtSoGiuong.KeyPress += txtSoGiuong_KeyPress;
            // 
            // txtMaGiuong
            // 
            txtMaGiuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaGiuong.Location = new Point(135, 36);
            txtMaGiuong.Name = "txtMaGiuong";
            txtMaGiuong.Size = new Size(240, 30);
            txtMaGiuong.TabIndex = 1;
            // 
            // lblSoGiuong
            // 
            lblSoGiuong.AutoSize = true;
            lblSoGiuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoGiuong.ForeColor = Color.Black;
            lblSoGiuong.Location = new Point(35, 88);
            lblSoGiuong.Name = "lblSoGiuong";
            lblSoGiuong.Size = new Size(88, 23);
            lblSoGiuong.TabIndex = 0;
            lblSoGiuong.Text = "Số giường";
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhong.ForeColor = Color.Black;
            lblPhong.Location = new Point(460, 88);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(59, 23);
            lblPhong.TabIndex = 0;
            lblPhong.Text = "Phòng";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTrangThai.ForeColor = Color.Black;
            lblTrangThai.Location = new Point(460, 39);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(87, 23);
            lblTrangThai.TabIndex = 0;
            lblTrangThai.Text = "Trạng thái";
            // 
            // lblMaGiuong
            // 
            lblMaGiuong.AutoSize = true;
            lblMaGiuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaGiuong.ForeColor = Color.Black;
            lblMaGiuong.Location = new Point(35, 39);
            lblMaGiuong.Name = "lblMaGiuong";
            lblMaGiuong.Size = new Size(93, 23);
            lblMaGiuong.TabIndex = 0;
            lblMaGiuong.Text = "Mã giường";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnLamMoi);
            grbChucNang.Controls.Add(btnHuy);
            grbChucNang.Controls.Add(btnLuu);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbChucNang.ForeColor = Color.FromArgb(0, 122, 204);
            grbChucNang.Location = new Point(15, 170);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(950, 85);
            grbChucNang.TabIndex = 2;
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
            btnThem.Location = new Point(65, 32);
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
            btnSua.Location = new Point(205, 32);
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
            btnXoa.Location = new Point(345, 32);
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
            btnLuu.Location = new Point(485, 32);
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
            btnHuy.Location = new Point(625, 32);
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
            btnLamMoi.Location = new Point(765, 32);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 40);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimKiem.Location = new Point(25, 278);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(80, 23);
            lblTimKiem.TabIndex = 3;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(115, 275);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(320, 30);
            txtTimKiem.TabIndex = 4;
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
            btnTim.Location = new Point(450, 271);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(100, 36);
            btnTim.TabIndex = 5;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // dgvGiuong
            // 
            dgvGiuong.AllowUserToAddRows = false;
            dgvGiuong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            dgvGiuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGiuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGiuong.BackgroundColor = Color.White;
            dgvGiuong.BorderStyle = BorderStyle.None;
            dgvGiuong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGiuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGiuong.ColumnHeadersHeight = 40;
            dgvGiuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGiuong.Columns.AddRange(new DataGridViewColumn[] { colMaGiuong, colSoGiuong, colTrangThai, colTenPhong, colMaPhong });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGiuong.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGiuong.EnableHeadersVisualStyles = false;
            dgvGiuong.GridColor = Color.FromArgb(224, 224, 224);
            dgvGiuong.Location = new Point(15, 330);
            dgvGiuong.MultiSelect = false;
            dgvGiuong.Name = "dgvGiuong";
            dgvGiuong.ReadOnly = true;
            dgvGiuong.RowHeadersVisible = false;
            dgvGiuong.RowHeadersWidth = 51;
            dgvGiuong.RowTemplate.Height = 35;
            dgvGiuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGiuong.Size = new Size(950, 260);
            dgvGiuong.TabIndex = 6;
            dgvGiuong.CellClick += dgvGiuong_CellClick;
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
            colSoGiuong.FillWeight = 80F;
            colSoGiuong.HeaderText = "Số giường";
            colSoGiuong.MinimumWidth = 6;
            colSoGiuong.Name = "colSoGiuong";
            colSoGiuong.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.FillWeight = 100F;
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // colTenPhong
            // 
            colTenPhong.DataPropertyName = "TenPhong";
            colTenPhong.FillWeight = 120F;
            colTenPhong.HeaderText = "Phòng";
            colTenPhong.MinimumWidth = 6;
            colTenPhong.Name = "colTenPhong";
            colTenPhong.ReadOnly = true;
            // 
            // colMaPhong
            // 
            colMaPhong.DataPropertyName = "MaPhong";
            colMaPhong.HeaderText = "MaPhong";
            colMaPhong.MinimumWidth = 6;
            colMaPhong.Name = "colMaPhong";
            colMaPhong.ReadOnly = true;
            colMaPhong.Visible = false;
            // 
            // frmGiuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 603);
            Controls.Add(dgvGiuong);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(grbChucNang);
            Controls.Add(grbThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmGiuong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Giường Bệnh";
            Load += frmGiuong_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGiuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbThongTin;
        private TextBox txtSoGiuong;
        private TextBox txtMaGiuong;
        private Label lblSoGiuong;
        private Label lblMaGiuong;
        private Label lblTrangThai;
        private ComboBox cboTrangThai;
        private ComboBox cboPhong;
        private Label lblPhong;
        private GroupBox grbChucNang;
        private Button btnLamMoi;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTim;
        private DataGridView dgvGiuong;
        private DataGridViewTextBoxColumn colMaGiuong;
        private DataGridViewTextBoxColumn colSoGiuong;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colTenPhong;
        private DataGridViewTextBoxColumn colMaPhong;
    }
}