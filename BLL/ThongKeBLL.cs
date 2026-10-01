using HospitalManagement.DAL;
using System;
using System.Data;

namespace HospitalManagement.BLL
{
    public class ThongKeBLL
    {
        private readonly ThongKeDAL dal = new ThongKeDAL();

        #region TỔNG QUAN

        public int TongBenhNhan()
        {
            return dal.TongBenhNhan();
        }

        public int TongKhamBenh()
        {
            return dal.TongKhamBenh();
        }

        public int TongNhapVien()
        {
            return dal.TongNhapVien();
        }

        public int TongBacSi()
        {
            return dal.TongBacSi();
        }

        public int TongGiuongTrong()
        {
            return dal.TongGiuongTrong();
        }

        public int TongGiuongDangSuDung()
        {
            return dal.TongGiuongDangSuDung();
        }

        #endregion

        #region DASHBOARD

        public DataTable BenhNhanGanDay()
        {
            return dal.BenhNhanGanDay();
        }

        public DataTable NhapVienGanDay()
        {
            return dal.NhapVienGanDay();
        }

        #endregion

        #region THỐNG KÊ

        public DataTable ThongKeBenhNhan(DateTime tuNgay, DateTime denNgay)
        {
            return dal.ThongKeBenhNhan(tuNgay, denNgay);
        }

        public DataTable ThongKeKhamBenh(DateTime tuNgay, DateTime denNgay)
        {
            return dal.ThongKeKhamBenh(tuNgay, denNgay);
        }

        public DataTable ThongKeNhapVien(DateTime tuNgay, DateTime denNgay)
        {
            return dal.ThongKeNhapVien(tuNgay, denNgay);
        }

        #endregion

        #region DANH MỤC

        public DataTable DanhSachBacSi()
        {
            return dal.DanhSachBacSi();
        }

        public DataTable DanhSachGiuong()
        {
            return dal.DanhSachGiuong();
        }

        public DataTable DanhSachPhong()
        {
            return dal.DanhSachPhong();
        }

        public DataTable DanhSachKhoa()
        {
            return dal.DanhSachKhoa();
        }

        #endregion

        #region CHI TIẾT

        public DataTable LichSuKhamBenh(string maBN)
        {
            return dal.LichSuKhamBenh(maBN);
        }

        public DataTable ChiTietNhapVien(string maNhapVien)
        {
            return dal.ChiTietNhapVien(maNhapVien);
        }

        public DataTable DanhSachPhongTheoKhoa(string maKhoa)
        {
            return dal.DanhSachPhongTheoKhoa(maKhoa);
        }

        public DataTable DanhSachGiuongTheoPhong(string maPhong)
        {
            return dal.DanhSachGiuongTheoPhong(maPhong);
        }

        public DataTable DanhSachBenhNhanTheoBacSi(string maBS)
        {
            return dal.DanhSachBenhNhanTheoBacSi(maBS);
        }

        #endregion
    }
}