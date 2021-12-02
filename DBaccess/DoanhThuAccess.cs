using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DBaccess
{
    internal class DoanhThuAccess
    {
        private string connectionString;
        public DoanhThuAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<MyDatabase.HoaDonNhapHang> GetHoaDonNhapHang()
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            return db.HoaDonNhapHangs.ToList();
        }

        public List<MyDatabase.f_LayCTHoaDonNhapHang_Result> Get_ChiTiet(string ID)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            return db.f_LayCTHoaDonNhapHang(ID).ToList();
        }

        public List<MyDatabase.f_DoanhThu_Result> GetDoanhThu(DateTime daybegin, DateTime dayend)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            return db.f_DoanhThu(daybegin, dayend).ToList();
        }
        public List<MyDatabase.f_DoanhThuThang_Result> GetDoanhThuThang(int monthBegin, int yearBegin, int monthEnd, int yearEnd)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            return db.f_DoanhThuThang(monthBegin, yearBegin, monthEnd, yearEnd).ToList();
        }
        public List<MyDatabase.f_TopThucDon_Result> GetTopThucDon(int day, int month, int year)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            return db.f_TopThucDon(day, month, year).ToList();
        }
        public List<MyDatabase.f_TopNhanVien_Result> GetTopNhanVien(int day, int month, int year)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            return db.f_TopNhanVien(day, month, year).ToList();
        }
        public List<MyDatabase.f_TopThanhVien_Result> GetTopThanhVien(int day, int month, int year)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            return db.f_TopThanhVien(day, month, year).ToList();
        }
        public List<MyDatabase.f_DoanhThuNgay_BanHang_Result> GetDoanhThuNgay_BanHang(DateTime date)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            return db.f_DoanhThuNgay_BanHang(date).ToList();
        }

        public List<MyDatabase.f_DoanhThuNgay_NhapHang_Result> GetDoanhThuNgay_NhapHang(DateTime date)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            return db.f_DoanhThuNgay_NhapHang(date).ToList();
        }
    
    }
}
