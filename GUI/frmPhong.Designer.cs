namespace HospitalManagement.GUI
{
    partial class frmPhong
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            grbThongTin = new GroupBox();
            cboKhoa = new ComboBox();
            txtTenPhong = new TextBox();
            txtSoPhong = new TextBox();
            txtMaPhong = new TextBox();
            lblKhoa = new Label();
            lblTenPhong = new Label();
            lblMaPhong = new Label();
            lblSoPhong = new Label();
            grbChucNang = new GroupBox();
            btnLamMoi = new Button();
            btnThem = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnTim = new Button();
            lblTim = new Label();
            txtTimKiem = new TextBox();
            dgvPhong = new DataGridView();
            colMaPhong = new DataGridViewTextBoxColumn();
            colSoPhong = new DataGridViewTextBoxColumn();
            colTenPhong = new DataGridViewTextBoxColumn();
            colTenKhoa = new DataGridViewTextBoxColumn();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(cboKhoa);
            grbThongTin.Controls.Add(txtTenPhong);
            grbThongTin.Controls.Add(txtSoPhong);
            grbThongTin.Controls.Add(txtMaPhong);
            grbThongTin.Controls.Add(lblKhoa);
            grbThongTin.Controls.Add(lblTenPhong);
            grbThongTin.Controls.Add(lblMaPhong);
            grbThongTin.Controls.Add(lblSoPhong);
            grbThongTin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            grbThongTin.ForeColor = Color.FromArgb(0, 122, 204);
            grbThongTin.Location = new Point(15, 15);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(950, 150);
            grbThongTin.TabIndex = 0;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "THÔNG TIN PHÒNG";
            // 
            // cboKhoa
            // 
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.Font = new Font("Segoe UI", 10.2F);
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(600, 85);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(300, 31);
            cboKhoa.TabIndex = 3;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Font = new Font("Segoe UI", 10.2F);
            txtTenPhong.Location = new Point(600, 35);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(300, 30);
            txtTenPhong.TabIndex = 2;
            // 
            // txtSoPhong
            // 
            txtSoPhong.Font = new Font("Segoe UI", 10.2F);
            txtSoPhong.Location = new Point(135, 85);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.Size = new Size(300, 30);
            txtSoPhong.TabIndex = 1;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Font = new Font("Segoe UI", 10.2F);
            txtMaPhong.Location = new Point(135, 35);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(300, 30);
            txtMaPhong.TabIndex = 0;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Font = new Font("Segoe UI", 10.2F);
            lblKhoa.ForeColor = Color.Black;
            lblKhoa.Location = new Point(480, 88);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(49, 23);
            lblKhoa.TabIndex = 2;
            lblKhoa.Text = "Khoa";
            // 
            // lblTenPhong
            // 
            lblTenPhong.AutoSize = true;
            lblTenPhong.Font = new Font("Segoe UI", 10.2F);
            lblTenPhong.ForeColor = Color.Black;
            lblTenPhong.Location = new Point(480, 38);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new Size(91, 23);
            lblTenPhong.TabIndex = 3;
            lblTenPhong.Text = "Tên phòng";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Font = new Font("Segoe UI", 10.2F);
            lblMaPhong.ForeColor = Color.Black;
            lblMaPhong.Location = new Point(30, 38);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(89, 23);
            lblMaPhong.TabIndex = 2;
            lblMaPhong.Text = "Mã phòng";
            // 
            // lblSoPhong
            // 
            lblSoPhong.AutoSize = true;
            lblSoPhong.Font = new Font("Segoe UI", 10.2F);
            lblSoPhong.ForeColor = Color.Black;
            lblSoPhong.Location = new Point(30, 88);
            lblSoPhong.Name = "lblSoPhong";
            lblSoPhong.Size = new Size(84, 23);
            lblSoPhong.TabIndex = 2;
            lblSoPhong.Text = "Số phòng";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnLamMoi);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Controls.Add(btnHuy);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnLuu);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            grbChucNang.ForeColor = Color.FromArgb(0, 122, 204);
            grbChucNang.Location = new Point(15, 180);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(950, 85);
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
            btnLamMoi.Location = new Point(765, 30);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 40);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(46, 204, 113);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(65, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 40);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(149, 165, 166);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(625, 30);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 40);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 122, 204);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(205, 30);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 40);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(41, 128, 185);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(485, 30);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 40);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(231, 76, 60);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(345, 30);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 40);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(0, 122, 204);
            btnTim.Cursor = Cursors.Hand;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(450, 286);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(100, 38);
            btnTim.TabIndex = 11;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // lblTim
            // 
            lblTim.AutoSize = true;
            lblTim.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblTim.Location = new Point(25, 293);
            lblTim.Name = "lblTim";
            lblTim.Size = new Size(80, 23);
            lblTim.TabIndex = 3;
            lblTim.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F);
            txtTimKiem.Location = new Point(115, 290);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(320, 30);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // dgvPhong
            // 
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(245, 247, 250);
            dgvPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.BackgroundColor = Color.White;
            dgvPhong.BorderStyle = BorderStyle.None;
            dgvPhong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvPhong.ColumnHeadersHeight = 40;
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPhong.Columns.AddRange(new DataGridViewColumn[] { colMaPhong, colSoPhong, colTenPhong, colTenKhoa });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvPhong.DefaultCellStyle = dataGridViewCellStyle9;
            dgvPhong.EnableHeadersVisualStyles = false;
            dgvPhong.GridColor = Color.FromArgb(224, 224, 224);
            dgvPhong.Location = new Point(15, 345);
            dgvPhong.MultiSelect = false;
            dgvPhong.Name = "dgvPhong";
            dgvPhong.ReadOnly = true;
            dgvPhong.RowHeadersVisible = false;
            dgvPhong.RowHeadersWidth = 51;
            dgvPhong.RowTemplate.Height = 35;
            dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhong.Size = new Size(950, 240);
            dgvPhong.TabIndex = 12;
            dgvPhong.CellClick += dgvPhong_CellClick;
            // 
            // colMaPhong
            // 
            colMaPhong.DataPropertyName = "MaPhong";
            colMaPhong.FillWeight = 80F;
            colMaPhong.HeaderText = "Mã phòng";
            colMaPhong.MinimumWidth = 6;
            colMaPhong.Name = "colMaPhong";
            colMaPhong.ReadOnly = true;
            // 
            // colSoPhong
            // 
            colSoPhong.DataPropertyName = "SoPhong";
            colSoPhong.FillWeight = 80F;
            colSoPhong.HeaderText = "Số phòng";
            colSoPhong.MinimumWidth = 6;
            colSoPhong.Name = "colSoPhong";
            colSoPhong.ReadOnly = true;
            // 
            // colTenPhong
            // 
            colTenPhong.DataPropertyName = "TenPhong";
            colTenPhong.FillWeight = 150F;
            colTenPhong.HeaderText = "Tên phòng";
            colTenPhong.MinimumWidth = 6;
            colTenPhong.Name = "colTenPhong";
            colTenPhong.ReadOnly = true;
            // 
            // colTenKhoa
            // 
            colTenKhoa.DataPropertyName = "TenKhoa";
            colTenKhoa.FillWeight = 150F;
            colTenKhoa.HeaderText = "Khoa";
            colTenKhoa.MinimumWidth = 6;
            colTenKhoa.Name = "colTenKhoa";
            colTenKhoa.ReadOnly = true;
            // 
            // frmPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 603);
            Controls.Add(dgvPhong);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTim);
            Controls.Add(btnTim);
            Controls.Add(grbChucNang);
            Controls.Add(grbThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Phòng - Hệ Thống Bệnh Viện";
            Load += frmPhong_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox grbThongTin;
        private Label label1;
        private GroupBox grbChucNang;
        private ComboBox comboBox1;
        private TextBox txtTenPhong;
        private TextBox txtSoPhong;
        private TextBox txtMaPhong;
        private Label lblKhoa;
        private Label lblTenPhong;
        private Label lblMaPhong;
        private Label lblSoPhong;
        private ComboBox cboKhoa;
        private Button button6;
        private Button button1;
        private Button button5;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button7;
        private TextBox textBox1;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnHuy;
        private Button btnSua;
        private Button btnLuu;
        private Button btnXoa;
        private Label lblTim;
        private Button btnTim;
        private TextBox txtTimKiem;
        private DataGridView dgvPhong;
        private DataGridViewTextBoxColumn colMaPhong;
        private DataGridViewTextBoxColumn colSoPhong;
        private DataGridViewTextBoxColumn colTenPhong;
        private DataGridViewTextBoxColumn colTenKhoa;
    }
}