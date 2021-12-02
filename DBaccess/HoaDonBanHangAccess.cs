using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DBaccess
{
    internal class HoaDonBanHangAccess
    {
        private string connectionString;
        public HoaDonBanHangAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<MyDatabase.HoaDonBanHang> Get()
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.HoaDonBanHangs.ToList();
            }
        }
        public MyDatabase.HoaDonBanHang getHoaDonBanHang(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                MyDatabase.HoaDonBanHang b = dbCafe.HoaDonBanHangs.ToList().Find(p => p.ID == ID);
                return b;
            }
        }
        public List<MyDatabase.f_ChiTietHoaDonBanHang_Result> getChiTietHoaDonBanHang(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.f_ChiTietHoaDonBanHang(ID).ToList();
            }
        }
        public List<MyDatabase.ChiTietHoaDonBanHang> getCTHDBH(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.ChiTietHoaDonBanHangs.ToList().FindAll(p => p.IDhoaDonBH == ID);
            }
        }
        public MyDatabase.f_TinhTienHoaDonBH_Result getTienHoaDonBH(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.f_TinhTienHoaDonBH().ToList().Find(p => p.ID == ID);
            }
        }
        public string getIDHoaDonBHMoi()
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.f_TaoIDHoaDonBanHangMoi().ToList().FirstOrDefault().IDHDMoi;
            }
        }
        public MyDatabase.HoaDonBanHang getHoaDonBHtheoBanChuaThanhToan(string IDban, string IDthanhVien)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.HoaDonBanHangs.ToList().Find(p => p.IDban == IDban && p.IDthanhVien == IDthanhVien && p.DaThanhToan == false);
            }
        }
        public void Them(MyDatabase.HoaDonBanHang value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Insert_HoaDonBanHang(value.ID, value.IDnhanVien, value.IDthanhVien, value.IDban, value.Ngaytao);
            }
        }
        public void Sua(MyDatabase.HoaDonBanHang value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Update_HoaDonBanHang(value.ID, value.IDnhanVien, value.IDthanhVien, value.IDban, value.Ngaytao, value.DaThanhToan);
            }
        }
        public void Xoa(MyDatabase.HoaDonBanHang value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Delete_HoaDonBanHang(value.ID);
            }
        }

        public void Xoa(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Delete_HoaDonBanHang(ID);
            }
        }
    }
}
