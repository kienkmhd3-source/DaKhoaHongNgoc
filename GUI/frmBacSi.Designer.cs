namespace HospitalManagement.GUI
{
    partial class frmBacSi
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
            txtKyNang = new TextBox();
            txtLichLamViec = new TextBox();
            txtChuyenNganh = new TextBox();
            lblLichLamViec = new Label();
            lblKyNang = new Label();
            lblChuyenNganh = new Label();
            lblNhanVien = new Label();
            cboNhanVien = new ComboBox();
            txtMaBS = new TextBox();
            lblMaBS = new Label();
            grbChucNang = new GroupBox();
            btnLamMoi = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvBacSi = new DataGridView();
            colMaBS = new DataGridViewTextBoxColumn();
            colNhanVien = new DataGridViewTextBoxColumn();
            colChuyenNganh = new DataGridViewTextBoxColumn();
            colKyNang = new DataGridViewTextBoxColumn();
            colLichLamViec = new DataGridViewTextBoxColumn();
            colMaNV = new DataGridViewTextBoxColumn();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBacSi).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(txtKyNang);
            grbThongTin.Controls.Add(txtLichLamViec);
            grbThongTin.Controls.Add(txtChuyenNganh);
            grbThongTin.Controls.Add(lblLichLamViec);
            grbThongTin.Controls.Add(lblKyNang);
            grbThongTin.Controls.Add(lblChuyenNganh);
            grbThongTin.Controls.Add(lblNhanVien);
            grbThongTin.Controls.Add(cboNhanVien);
            grbThongTin.Controls.Add(txtMaBS);
            grbThongTin.Controls.Add(lblMaBS);
            grbThongTin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            grbThongTin.ForeColor = Color.FromArgb(0, 122, 204);
            grbThongTin.Location = new Point(20, 20);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(900, 170);
            grbThongTin.TabIndex = 0;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "THÔNG TIN BÁC SĨ";
            // 
            // txtKyNang
            // 
            txtKyNang.Font = new Font("Segoe UI", 10.2F);
            txtKyNang.Location = new Point(610, 36);
            txtKyNang.Name = "txtKyNang";
            txtKyNang.Size = new Size(250, 30);
            txtKyNang.TabIndex = 5;
            // 
            // txtLichLamViec
            // 
            txtLichLamViec.Font = new Font("Segoe UI", 10.2F);
            txtLichLamViec.Location = new Point(610, 78);
            txtLichLamViec.Name = "txtLichLamViec";
            txtLichLamViec.Size = new Size(250, 30);
            txtLichLamViec.TabIndex = 5;
            // 
            // txtChuyenNganh
            // 
            txtChuyenNganh.Font = new Font("Segoe UI", 10.2F);
            txtChuyenNganh.Location = new Point(160, 120);
            txtChuyenNganh.Name = "txtChuyenNganh";
            txtChuyenNganh.Size = new Size(250, 30);
            txtChuyenNganh.TabIndex = 5;
            // 
            // lblLichLamViec
            // 
            lblLichLamViec.AutoSize = true;
            lblLichLamViec.Font = new Font("Segoe UI", 10.2F);
            lblLichLamViec.ForeColor = Color.Black;
            lblLichLamViec.Location = new Point(490, 81);
            lblLichLamViec.Name = "lblLichLamViec";
            lblLichLamViec.Size = new Size(107, 23);
            lblLichLamViec.TabIndex = 4;
            lblLichLamViec.Text = "Lịch làm việc";
            // 
            // lblKyNang
            // 
            lblKyNang.AutoSize = true;
            lblKyNang.Font = new Font("Segoe UI", 10.2F);
            lblKyNang.ForeColor = Color.Black;
            lblKyNang.Location = new Point(490, 39);
            lblKyNang.Name = "lblKyNang";
            lblKyNang.Size = new Size(72, 23);
            lblKyNang.TabIndex = 4;
            lblKyNang.Text = "Kỹ năng";
            // 
            // lblChuyenNganh
            // 
            lblChuyenNganh.AutoSize = true;
            lblChuyenNganh.Font = new Font("Segoe UI", 10.2F);
            lblChuyenNganh.ForeColor = Color.Black;
            lblChuyenNganh.Location = new Point(35, 123);
            lblChuyenNganh.Name = "lblChuyenNganh";
            lblChuyenNganh.Size = new Size(122, 23);
            lblChuyenNganh.TabIndex = 4;
            lblChuyenNganh.Text = "Chuyên ngành";
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 10.2F);
            lblNhanVien.ForeColor = Color.Black;
            lblNhanVien.Location = new Point(35, 81);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(88, 23);
            lblNhanVien.TabIndex = 3;
            lblNhanVien.Text = "Nhân viên";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.Font = new Font("Segoe UI", 10.2F);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(160, 78);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(250, 31);
            cboNhanVien.TabIndex = 2;
            // 
            // txtMaBS
            // 
            txtMaBS.Font = new Font("Segoe UI", 10.2F);
            txtMaBS.Location = new Point(160, 36);
            txtMaBS.Name = "txtMaBS";
            txtMaBS.Size = new Size(250, 30);
            txtMaBS.TabIndex = 1;
            // 
            // lblMaBS
            // 
            lblMaBS.AutoSize = true;
            lblMaBS.Font = new Font("Segoe UI", 10.2F);
            lblMaBS.ForeColor = Color.Black;
            lblMaBS.Location = new Point(35, 39);
            lblMaBS.Name = "lblMaBS";
            lblMaBS.Size = new Size(82, 23);
            lblMaBS.TabIndex = 1;
            lblMaBS.Text = "Mã bác sĩ";
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
            grbChucNang.Location = new Point(20, 205);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(900, 85);
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
            btnLamMoi.Location = new Point(710, 32);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 40);
            btnLamMoi.TabIndex = 2;
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
            btnHuy.Location = new Point(580, 32);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 40);
            btnHuy.TabIndex = 2;
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
            btnLuu.Location = new Point(450, 32);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 40);
            btnLuu.TabIndex = 2;
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
            btnXoa.Location = new Point(320, 32);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 40);
            btnXoa.TabIndex = 2;
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
            btnSua.Location = new Point(190, 32);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 40);
            btnSua.TabIndex = 2;
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
            btnThem.Location = new Point(60, 32);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 40);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblTimKiem.Location = new Point(25, 310);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(80, 23);
            lblTimKiem.TabIndex = 2;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F);
            txtTimKiem.Location = new Point(125, 307);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(300, 30);
            txtTimKiem.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(0, 122, 204);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(440, 303);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(110, 36);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvBacSi
            // 
            dgvBacSi.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            dgvBacSi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBacSi.BackgroundColor = Color.White;
            dgvBacSi.BorderStyle = BorderStyle.None;
            dgvBacSi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBacSi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBacSi.ColumnHeadersHeight = 40;
            dgvBacSi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBacSi.Columns.AddRange(new DataGridViewColumn[] { colMaBS, colNhanVien, colChuyenNganh, colKyNang, colLichLamViec, colMaNV });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBacSi.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBacSi.EnableHeadersVisualStyles = false;
            dgvBacSi.GridColor = Color.FromArgb(224, 224, 224);
            dgvBacSi.Location = new Point(20, 360);
            dgvBacSi.MultiSelect = false;
            dgvBacSi.Name = "dgvBacSi";
            dgvBacSi.ReadOnly = true;
            dgvBacSi.RowHeadersVisible = false;
            dgvBacSi.RowHeadersWidth = 51;
            dgvBacSi.RowTemplate.Height = 35;
            dgvBacSi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBacSi.Size = new Size(900, 270);
            dgvBacSi.TabIndex = 5;
            dgvBacSi.CellClick += dgvBacSi_CellClick;
            // 
            // colMaBS
            // 
            colMaBS.DataPropertyName = "MaBS";
            colMaBS.HeaderText = "Mã BS";
            colMaBS.MinimumWidth = 6;
            colMaBS.Name = "colMaBS";
            colMaBS.ReadOnly = true;
            colMaBS.Width = 90;
            // 
            // colNhanVien
            // 
            colNhanVien.DataPropertyName = "HoTen";
            colNhanVien.HeaderText = "Nhân viên";
            colNhanVien.MinimumWidth = 6;
            colNhanVien.Name = "colNhanVien";
            colNhanVien.ReadOnly = true;
            colNhanVien.Width = 220;
            // 
            // colChuyenNganh
            // 
            colChuyenNganh.DataPropertyName = "ChuyenNganh";
            colChuyenNganh.HeaderText = "Chuyên ngành";
            colChuyenNganh.MinimumWidth = 6;
            colChuyenNganh.Name = "colChuyenNganh";
            colChuyenNganh.ReadOnly = true;
            colChuyenNganh.Width = 180;
            // 
            // colKyNang
            // 
            colKyNang.DataPropertyName = "KyNang";
            colKyNang.HeaderText = "Kỹ năng";
            colKyNang.MinimumWidth = 6;
            colKyNang.Name = "colKyNang";
            colKyNang.ReadOnly = true;
            colKyNang.Width = 200;
            // 
            // colLichLamViec
            // 
            colLichLamViec.DataPropertyName = "LichLamViec";
            colLichLamViec.HeaderText = "Lịch làm việc";
            colLichLamViec.MinimumWidth = 6;
            colLichLamViec.Name = "colLichLamViec";
            colLichLamViec.ReadOnly = true;
            colLichLamViec.Width = 180;
            // 
            // colMaNV
            // 
            colMaNV.DataPropertyName = "MaNV";
            colMaNV.HeaderText = "Mã NV";
            colMaNV.MinimumWidth = 6;
            colMaNV.Name = "colMaNV";
            colMaNV.ReadOnly = true;
            colMaNV.Visible = false;
            colMaNV.Width = 125;
            // 
            // frmBacSi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(940, 653);
            Controls.Add(dgvBacSi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(grbChucNang);
            Controls.Add(grbThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmBacSi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thông Tin Bác Sĩ";
            Load += frmBacSi_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBacSi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbThongTin;
        private TextBox textBox2;
        private TextBox txtTimKiem;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblTimKiem;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox grbChucNang;
        private TextBox txtMaBS;
        private Label lblMaBS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnLamMoi;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnTimKiem;
        private DataGridView dgvBacSi;
        private TextBox txtKyNang;
        private TextBox txtLichLamViec;
        private TextBox txtChuyenNganh;
        private Label lblLichLamViec;
        private Label lblKyNang;
        private Label lblChuyenNganh;
        private Label lblNhanVien;
        private ComboBox cboNhanVien;
        private DataGridViewTextBoxColumn colMaBS;
        private DataGridViewTextBoxColumn colNhanVien;
        private DataGridViewTextBoxColumn colChuyenNganh;
        private DataGridViewTextBoxColumn colKyNang;
        private DataGridViewTextBoxColumn colLichLamViec;
        private DataGridViewTextBoxColumn colMaNV;
    }
}