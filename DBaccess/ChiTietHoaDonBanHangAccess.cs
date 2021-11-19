using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DBaccess
{
    internal class ChiTietHoaDonBanHangAccess
    {
        private string connectionString;
        public ChiTietHoaDonBanHangAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<MyDatabase.ChiTietHoaDonBanHang> Get()
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.ChiTietHoaDonBanHangs.ToList();
            }
        }
        public MyDatabase.ChiTietHoaDonBanHang getChiTietHoaDonBanHang(string IDHoaDon, string IDThucDon)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                MyDatabase.ChiTietHoaDonBanHang b = dbCafe.ChiTietHoaDonBanHangs.ToList().Find(p => p.IDhoaDonBH == IDHoaDon && p.IDthucDon == IDThucDon);
                return b;
            }
        }
        public void Them(MyDatabase.ChiTietHoaDonBanHang value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Insert_ChiTietHoaDonBanHang(value.IDhoaDonBH, value.IDthucDon, value.soLuong);
            }
        }
        public void Sua(MyDatabase.ChiTietHoaDonBanHang value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Update_ChiTietHoaDonBanHang(value.IDhoaDonBH, value.IDthucDon, value.soLuong);
            }
        }
        public void Xoa(MyDatabase.ChiTietHoaDonBanHang value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Delete_ChiTietHoaDonBanHang(value.IDhoaDonBH, value.IDthucDon);
            }
        }

        public void Xoa(string IDHoaDon, string IDThucDon)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Delete_ChiTietHoaDonBanHang(IDHoaDon, IDThucDon);
            }
        }
    }
}
