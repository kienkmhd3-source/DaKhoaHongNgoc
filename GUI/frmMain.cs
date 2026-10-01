using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.GUI;

namespace HospitalManagement.GUI
{
    public partial class frmMain : Form
    {
        public frmLogin LoginForm { get; set; }
        private bool isLogout = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private bool CoQuyen(string permission)
        {
            return Session.Permissions.Contains(permission);
        }

        private void KiemTraQuyen()
        {
            mnuKhoa.Visible = CoQuyen("KHOA");

            mnuPhong.Visible = CoQuyen("PHONG");

            mnuBacSi.Visible = CoQuyen("BACSI");

            mnuNhanVien.Visible = CoQuyen("NHANVIEN");

            mnuBenhNhan.Visible = CoQuyen("BENHNHAN");

            mnuGiuong.Visible = CoQuyen("GIUONG");

            mnuKhamBenh.Visible = CoQuyen("KHAMBENH");

            mnuNhapVien.Visible = CoQuyen("NHAPVIEN");

            mnuThongKe.Visible = CoQuyen("THONGKE");

            mnuTaiKhoan.Visible = CoQuyen("TAIKHOAN");
        }

        private void mnuKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa f = new frmKhoa();
            f.ShowDialog();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogout)
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                isLogout = true;
                Application.Exit();
            }
        }

        private void mnuPhong_Click(object sender, EventArgs e)
        {
            frmPhong f = new frmPhong();
            f.ShowDialog();
        }

        private void mnuBacSi_Click(object sender, EventArgs e)
        {
            frmBacSi f = new frmBacSi();
            f.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
        }

        private void mnuBenhNhan_Click(object sender, EventArgs e)
        {
            frmBenhNhan f = new frmBenhNhan();
            f.ShowDialog();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan f = new frmTaiKhoan();
            f.ShowDialog();
        }

        private void mnuGiuong_Click(object sender, EventArgs e)
        {
            frmGiuong f = new frmGiuong();
            f.ShowDialog();
        }

        private void mnuKhamBenh_Click(object sender, EventArgs e)
        {
            frmKhamBenh f = new frmKhamBenh();
            f.ShowDialog();
        }

        private void mnuNhapVien_Click(object sender, EventArgs e)
        {
            frmNhapVien f = new frmNhapVien();
            f.ShowDialog();
        }

        private void mnuThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            f.ShowDialog();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
            "Bạn có chắc muốn đăng xuất?",
            "Đăng xuất",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                isLogout = true;

                LoginForm.ResetLogin();

                LoginForm.Show();

                LoginForm.Activate();

                this.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            KiemTraQuyen();
        }
        
     }
}

