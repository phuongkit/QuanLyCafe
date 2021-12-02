using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyCafe.DBaccess
{
    public class ThanhVienAccess
    {
        private string connectionString;
        public ThanhVienAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<MyDatabase.ThanhVien> Get()
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.ThanhViens.ToList();
            }
        }
        public MyDatabase.ThanhVien getThanhVien(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                MyDatabase.ThanhVien tv;
                tv = dbCafe.ThanhViens.ToList().Find(p => p.ID == ID);
                return tv;
            }
        }
        public MyDatabase.HoaDonBanHang getHoaDonBanHangTheoKhachHang(string IDKhachHang)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                MyDatabase.HoaDonBanHang hd = dbCafe.HoaDonBanHangs.ToList().Find(p => p.IDthanhVien == IDKhachHang && p.DaThanhToan == false);
                return hd;
            }
        }
        public void Them(MyDatabase.ThanhVien value)
        {
            try
            {
                MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
                db.sp_Insert_ThanhVien(value.ID, value.HoTen, value.SDT, value.Email, value.CMND, value.DiaChi, value.NgayTao);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void Sua(MyDatabase.ThanhVien value)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            try
            {
                db.sp_Update_ThanhVien(value.ID, value.HoTen, value.SDT, value.Email, value.CMND, value.DiaChi, value.NgayTao);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void Xoa(MyDatabase.ThanhVien value)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            db.sp_Delete_ThanhVien(value.ID);
        }

        public void Xoa(string ID)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            db.sp_Delete_ThanhVien(ID);
        }
    }
}
