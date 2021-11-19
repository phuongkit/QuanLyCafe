using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DBaccess
{
    internal class HoaDonNhapHangAccess
    {
        private string connectionString;
        public HoaDonNhapHangAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<MyDatabase.HoaDonNhapHang> Get()
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.HoaDonNhapHangs.ToList();
            }
        }
        public MyDatabase.HoaDonNhapHang getHoaDonNhapHang(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                MyDatabase.HoaDonNhapHang b = dbCafe.HoaDonNhapHangs.ToList().Find(p => p.ID == ID);
                return b;
            }
        }
        public List<MyDatabase.f_ChiTietHoaDonNhapHang_Result> getChiTietHoaDonNhapHang(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.f_ChiTietHoaDonNhapHang(ID).ToList();
            }
        }
        public List<MyDatabase.ChiTietHoaDonNhapHang> getCTHDNH(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.ChiTietHoaDonNhapHangs.ToList().FindAll(p => p.IDhoaDonNH == ID);
            }
        }
        public MyDatabase.f_TinhTienHoaDonNH_Result getTienHoaDonNH(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.f_TinhTienHoaDonNH().ToList().Find(p => p.ID == ID);
            }
        }
        public string getIDHoaDonNHMoi()
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.f_TaoIDHoaDonNhapHangMoi().ToList().FirstOrDefault().IDHDMoi;
            }
        }
        public void Them(MyDatabase.HoaDonNhapHang value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Insert_HoaDonNhapHang(value.ID, value.IDnhanVien, value.NgayTao);
            }
        }
        public void Sua(MyDatabase.HoaDonNhapHang value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Update_HoaDonNhapHang(value.ID, value.IDnhanVien, value.NgayTao);
            }
        }
        public void Xoa(MyDatabase.HoaDonNhapHang value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Delete_HoaDonNhapHang(value.ID);
            }
        }

        public void Xoa(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Delete_HoaDonNhapHang(ID);
            }
        }
    }
}
