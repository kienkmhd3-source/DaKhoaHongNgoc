namespace HospitalManagement.GUI
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuTaiKhoan = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuKhoa = new ToolStripMenuItem();
            mnuPhong = new ToolStripMenuItem();
            mnuGiuong = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuBacSi = new ToolStripMenuItem();
            mnuBenhNhan = new ToolStripMenuItem();
            mnuNghiepVu = new ToolStripMenuItem();
            mnuKhamBenh = new ToolStripMenuItem();
            mnuNhapVien = new ToolStripMenuItem();
            mnuThongKe = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            menuStrip1.ForeColor = Color.FromArgb(0, 122, 204);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuDanhMuc, mnuQuanLy, mnuNghiepVu, mnuThongKe, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 10, 0, 10);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1182, 49);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuTaiKhoan, mnuDangXuat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Padding = new Padding(12, 0, 12, 0);
            mnuHeThong.Size = new Size(120, 29);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuTaiKhoan
            // 
            mnuTaiKhoan.Font = new Font("Segoe UI", 10.8F);
            mnuTaiKhoan.ForeColor = Color.Black;
            mnuTaiKhoan.Name = "mnuTaiKhoan";
            mnuTaiKhoan.Padding = new Padding(0, 5, 0, 5);
            mnuTaiKhoan.Size = new Size(184, 38);
            mnuTaiKhoan.Text = "Tài khoản";
            mnuTaiKhoan.Click += mnuTaiKhoan_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Font = new Font("Segoe UI", 10.8F);
            mnuDangXuat.ForeColor = Color.Black;
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Padding = new Padding(0, 5, 0, 5);
            mnuDangXuat.Size = new Size(184, 38);
            mnuDangXuat.Text = "Đăng xuất ";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuKhoa, mnuPhong, mnuGiuong });
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Padding = new Padding(12, 0, 12, 0);
            mnuDanhMuc.Size = new Size(128, 29);
            mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuKhoa
            // 
            mnuKhoa.Font = new Font("Segoe UI", 10.8F);
            mnuKhoa.ForeColor = Color.Black;
            mnuKhoa.Name = "mnuKhoa";
            mnuKhoa.Padding = new Padding(0, 5, 0, 5);
            mnuKhoa.Size = new Size(157, 38);
            mnuKhoa.Text = "Khoa";
            mnuKhoa.Click += mnuKhoa_Click;
            // 
            // mnuPhong
            // 
            mnuPhong.Font = new Font("Segoe UI", 10.8F);
            mnuPhong.ForeColor = Color.Black;
            mnuPhong.Name = "mnuPhong";
            mnuPhong.Padding = new Padding(0, 5, 0, 5);
            mnuPhong.Size = new Size(157, 38);
            mnuPhong.Text = "Phòng";
            mnuPhong.Click += mnuPhong_Click;
            // 
            // mnuGiuong
            // 
            mnuGiuong.Font = new Font("Segoe UI", 10.8F);
            mnuGiuong.ForeColor = Color.Black;
            mnuGiuong.Name = "mnuGiuong";
            mnuGiuong.Padding = new Padding(0, 5, 0, 5);
            mnuGiuong.Size = new Size(157, 38);
            mnuGiuong.Text = "Giường";
            mnuGiuong.Click += mnuGiuong_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuNhanVien, mnuBacSi, mnuBenhNhan });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Padding = new Padding(12, 0, 12, 0);
            mnuQuanLy.Size = new Size(106, 29);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Font = new Font("Segoe UI", 10.8F);
            mnuNhanVien.ForeColor = Color.Black;
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Padding = new Padding(0, 5, 0, 5);
            mnuNhanVien.Size = new Size(186, 38);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuBacSi
            // 
            mnuBacSi.Font = new Font("Segoe UI", 10.8F);
            mnuBacSi.ForeColor = Color.Black;
            mnuBacSi.Name = "mnuBacSi";
            mnuBacSi.Padding = new Padding(0, 5, 0, 5);
            mnuBacSi.Size = new Size(186, 38);
            mnuBacSi.Text = "Bác sĩ";
            mnuBacSi.Click += mnuBacSi_Click;
            // 
            // mnuBenhNhan
            // 
            mnuBenhNhan.Font = new Font("Segoe UI", 10.8F);
            mnuBenhNhan.ForeColor = Color.Black;
            mnuBenhNhan.Name = "mnuBenhNhan";
            mnuBenhNhan.Padding = new Padding(0, 5, 0, 5);
            mnuBenhNhan.Size = new Size(186, 38);
            mnuBenhNhan.Text = "Bệnh nhân ";
            mnuBenhNhan.Click += mnuBenhNhan_Click;
            // 
            // mnuNghiepVu
            // 
            mnuNghiepVu.DropDownItems.AddRange(new ToolStripItem[] { mnuKhamBenh, mnuNhapVien });
            mnuNghiepVu.Name = "mnuNghiepVu";
            mnuNghiepVu.Padding = new Padding(12, 0, 12, 0);
            mnuNghiepVu.Size = new Size(129, 29);
            mnuNghiepVu.Text = "Nghiệp vụ";
            // 
            // mnuKhamBenh
            // 
            mnuKhamBenh.Font = new Font("Segoe UI", 10.8F);
            mnuKhamBenh.ForeColor = Color.Black;
            mnuKhamBenh.Name = "mnuKhamBenh";
            mnuKhamBenh.Padding = new Padding(0, 5, 0, 5);
            mnuKhamBenh.Size = new Size(188, 38);
            mnuKhamBenh.Text = "Khám bệnh";
            mnuKhamBenh.Click += mnuKhamBenh_Click;
            // 
            // mnuNhapVien
            // 
            mnuNhapVien.Font = new Font("Segoe UI", 10.8F);
            mnuNhapVien.ForeColor = Color.Black;
            mnuNhapVien.Name = "mnuNhapVien";
            mnuNhapVien.Padding = new Padding(0, 5, 0, 5);
            mnuNhapVien.Size = new Size(188, 38);
            mnuNhapVien.Text = "Nhập viện";
            mnuNhapVien.Click += mnuNhapVien_Click;
            // 
            // mnuThongKe
            // 
            mnuThongKe.Name = "mnuThongKe";
            mnuThongKe.Padding = new Padding(12, 0, 12, 0);
            mnuThongKe.Size = new Size(119, 29);
            mnuThongKe.Text = "Thống kê";
            mnuThongKe.Click += mnuThongKe_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Padding = new Padding(12, 0, 12, 0);
            mnuTroGiup.Size = new Size(110, 29);
            mnuTroGiup.Text = "Trợ giúp";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1182, 653);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản Lý Bệnh Viện";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuKhoa;
        private ToolStripMenuItem mnuPhong;
        private ToolStripMenuItem mnuGiuong;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuBacSi;
        private ToolStripMenuItem mnuBenhNhan;
        private ToolStripMenuItem mnuNghiepVu;
        private ToolStripMenuItem mnuKhamBenh;
        private ToolStripMenuItem mnuNhapVien;
        private ToolStripMenuItem mnuThongKe;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuTaiKhoan;
    }
}