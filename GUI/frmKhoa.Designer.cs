namespace HospitalManagement.GUI
{
    partial class frmKhoa
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
            txtMoTa = new TextBox();
            lblMoTa = new Label();
            txtTenKhoa = new TextBox();
            txtMaKhoa = new TextBox();
            lblTenKhoa = new Label();
            lblMaKhoa = new Label();
            grbChucNang = new GroupBox();
            btnLamMoi = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            lblTim = new Label();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            dgvKhoa = new DataGridView();
            colMaKhoa = new DataGridViewTextBoxColumn();
            colTenKhoa = new DataGridViewTextBoxColumn();
            colMoTa = new DataGridViewTextBoxColumn();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(txtMoTa);
            grbThongTin.Controls.Add(lblMoTa);
            grbThongTin.Controls.Add(txtTenKhoa);
            grbThongTin.Controls.Add(txtMaKhoa);
            grbThongTin.Controls.Add(lblTenKhoa);
            grbThongTin.Controls.Add(lblMaKhoa);
            grbThongTin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbThongTin.ForeColor = Color.FromArgb(0, 122, 204);
            grbThongTin.Location = new Point(15, 65);
            grbThongTin.Margin = new Padding(4, 3, 4, 3);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(4, 3, 4, 3);
            grbThongTin.Size = new Size(950, 130);
            grbThongTin.TabIndex = 0;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "THÔNG TIN KHOA";
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMoTa.Location = new Point(530, 35);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(390, 70);
            txtMoTa.TabIndex = 3;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoTa.ForeColor = Color.Black;
            lblMoTa.Location = new Point(450, 38);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(55, 23);
            lblMoTa.TabIndex = 2;
            lblMoTa.Text = "Mô tả";
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenKhoa.Location = new Point(130, 75);
            txtTenKhoa.Margin = new Padding(4, 3, 4, 3);
            txtTenKhoa.MaxLength = 100;
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(280, 30);
            txtTenKhoa.TabIndex = 1;
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.CharacterCasing = CharacterCasing.Upper;
            txtMaKhoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaKhoa.Location = new Point(130, 35);
            txtMaKhoa.Margin = new Padding(4, 3, 4, 3);
            txtMaKhoa.MaxLength = 10;
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(280, 30);
            txtMaKhoa.TabIndex = 1;
            // 
            // lblTenKhoa
            // 
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenKhoa.ForeColor = Color.Black;
            lblTenKhoa.Location = new Point(30, 78);
            lblTenKhoa.Margin = new Padding(4, 0, 4, 0);
            lblTenKhoa.Name = "lblTenKhoa";
            lblTenKhoa.Size = new Size(78, 23);
            lblTenKhoa.TabIndex = 0;
            lblTenKhoa.Text = "Tên khoa";
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaKhoa.ForeColor = Color.Black;
            lblMaKhoa.Location = new Point(30, 38);
            lblMaKhoa.Margin = new Padding(4, 0, 4, 0);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(76, 23);
            lblMaKhoa.TabIndex = 0;
            lblMaKhoa.Text = "Mã khoa";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnLamMoi);
            grbChucNang.Controls.Add(btnHuy);
            grbChucNang.Controls.Add(btnLuu);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbChucNang.ForeColor = Color.FromArgb(0, 122, 204);
            grbChucNang.Location = new Point(15, 205);
            grbChucNang.Margin = new Padding(4, 3, 4, 3);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(4, 3, 4, 3);
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
            btnLamMoi.TabIndex = 5;
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
            btnHuy.Location = new Point(625, 30);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 40);
            btnHuy.TabIndex = 4;
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
            btnLuu.Location = new Point(485, 30);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 40);
            btnLuu.TabIndex = 3;
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
            btnXoa.Location = new Point(345, 30);
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
            btnSua.Location = new Point(205, 30);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 40);
            btnSua.TabIndex = 1;
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
            btnThem.Location = new Point(65, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 122, 204);
            label1.Location = new Point(370, 15);
            label1.Name = "label1";
            label1.Size = new Size(218, 37);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ KHOA";
            // 
            // lblTim
            // 
            lblTim.AutoSize = true;
            lblTim.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTim.Location = new Point(25, 313);
            lblTim.Name = "lblTim";
            lblTim.Size = new Size(80, 23);
            lblTim.TabIndex = 3;
            lblTim.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(115, 310);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(320, 30);
            txtTimKiem.TabIndex = 4;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(0, 122, 204);
            btnTim.Cursor = Cursors.Hand;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(450, 306);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(100, 38);
            btnTim.TabIndex = 5;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // dgvKhoa
            // 
            dgvKhoa.AllowUserToAddRows = false;
            dgvKhoa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 250);
            dgvKhoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhoa.BackgroundColor = Color.White;
            dgvKhoa.BorderStyle = BorderStyle.None;
            dgvKhoa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKhoa.ColumnHeadersHeight = 40;
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKhoa.Columns.AddRange(new DataGridViewColumn[] { colMaKhoa, colTenKhoa, colMoTa });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvKhoa.DefaultCellStyle = dataGridViewCellStyle3;
            dgvKhoa.EnableHeadersVisualStyles = false;
            dgvKhoa.GridColor = Color.FromArgb(224, 224, 224);
            dgvKhoa.Location = new Point(15, 360);
            dgvKhoa.MultiSelect = false;
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.ReadOnly = true;
            dgvKhoa.RowHeadersVisible = false;
            dgvKhoa.RowHeadersWidth = 51;
            dgvKhoa.RowTemplate.Height = 35;
            dgvKhoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhoa.Size = new Size(950, 225);
            dgvKhoa.TabIndex = 6;
            dgvKhoa.CellClick += dgvKhoa_CellClick;
            // 
            // colMaKhoa
            // 
            colMaKhoa.DataPropertyName = "MaKhoa";
            colMaKhoa.FillWeight = 25F;
            colMaKhoa.HeaderText = "Mã khoa";
            colMaKhoa.MinimumWidth = 6;
            colMaKhoa.Name = "colMaKhoa";
            colMaKhoa.ReadOnly = true;
            // 
            // colTenKhoa
            // 
            colTenKhoa.DataPropertyName = "TenKhoa";
            colTenKhoa.FillWeight = 35F;
            colTenKhoa.HeaderText = "Tên khoa";
            colTenKhoa.MinimumWidth = 6;
            colTenKhoa.Name = "colTenKhoa";
            colTenKhoa.ReadOnly = true;
            // 
            // colMoTa
            // 
            colMoTa.DataPropertyName = "MoTa";
            colMoTa.FillWeight = 40F;
            colMoTa.HeaderText = "Mô tả";
            colMoTa.MinimumWidth = 6;
            colMoTa.Name = "colMoTa";
            colMoTa.ReadOnly = true;
            // 
            // frmKhoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 603);
            Controls.Add(dgvKhoa);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTim);
            Controls.Add(label1);
            Controls.Add(grbChucNang);
            Controls.Add(grbThongTin);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmKhoa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản Lý Khoa - Hệ Thống Bệnh Viện";
            Load += frmKhoa_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbThongTin;
        private TextBox txtMaKhoa;
        private Label lblMaKhoa;
        private TextBox txtTenKhoa;
        private Label lblTenKhoa;
        private GroupBox grbChucNang;
        private Button btnHuy;
        private Button btnLamMoi;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private Label lblTim;
        private TextBox txtTimKiem;
        private Button btnTim;
        private DataGridView dgvKhoa;
        private TextBox txtMoTa;
        private Label lblMoTa;
        private DataGridViewTextBoxColumn colMaKhoa;
        private DataGridViewTextBoxColumn colTenKhoa;
        private DataGridViewTextBoxColumn colMoTa;
    }
}