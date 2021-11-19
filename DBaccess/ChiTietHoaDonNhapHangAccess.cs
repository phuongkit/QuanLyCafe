using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyCafe.DBaccess
{
    internal class ChiTietHoaDonNhapHangAccess
    {
        private string connectionString;
        public ChiTietHoaDonNhapHangAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<MyDatabase.ChiTietHoaDonNhapHang> Get()
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.ChiTietHoaDonNhapHangs.ToList();
            }
        }
        public MyDatabase.ChiTietHoaDonNhapHang getChiTietHoaDonNhapHang(string IDHoaDon, string IDKHoHang)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                MyDatabase.ChiTietHoaDonNhapHang b = dbCafe.ChiTietHoaDonNhapHangs.ToList().Find(p => p.IDhoaDonNH == IDHoaDon && p.IDhang == IDKHoHang);
                return b;
            }
        }
        public void Them(MyDatabase.ChiTietHoaDonNhapHang value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                try
                {
                    dbCafe.sp_Insert_ChiTietHoaDonNhapHang(value.IDhoaDonNH, value.IDhang, value.soLuong);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
        public void Sua(MyDatabase.ChiTietHoaDonNhapHang value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                try
                {
                    dbCafe.sp_Update_ChiTietHoaDonNhapHang(value.IDhoaDonNH, value.IDhang, value.soLuong);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
        public void Xoa(MyDatabase.ChiTietHoaDonNhapHang value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                try
                {
                    dbCafe.sp_Delete_ChiTietHoaDonNhapHang(value.IDhoaDonNH, value.IDhang);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }

        public void Xoa(string IDHoaDon, string IDKhoHang)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                try
                {
                    dbCafe.sp_Delete_ChiTietHoaDonNhapHang(IDHoaDon, IDKhoHang);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
    }
}
