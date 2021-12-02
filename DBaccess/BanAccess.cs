using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyCafe.DBaccess
{
    internal class BanAccess
    {
        private string connectionString;
        public BanAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<MyDatabase.Ban> Get()
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.Bans.ToList();
            }
        }
        public MyDatabase.Ban getBan(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                MyDatabase.Ban b = dbCafe.Bans.ToList().Find(p => p.ID == ID);
                return b;
            }
        }
        public List<MyDatabase.f_LayThanhVienTheoBan_Result> getThanhVienTheoBan(string IDban)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                List<MyDatabase.f_LayThanhVienTheoBan_Result> tv = null;
                try
                {
                    tv = dbCafe.f_LayThanhVienTheoBan(IDban).ToList();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                return tv;
            }
        }

        public int getSLHoaDonChuaTT(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                int sl = dbCafe.HoaDonBanHangs.ToList().FindAll(p => p.IDban == ID && p.DaThanhToan == false).Count;
                return sl;
            }
        }
        public bool IsBanTrong(string IDBan)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                bool IsBanTrong = false;
                MyDatabase.HoaDonBanHang hdbh = new MyDatabase.HoaDonBanHang();
                hdbh = dbCafe.HoaDonBanHangs.ToList().Find(p => p.Ban.ID == IDBan && p.DaThanhToan == false);
                if (hdbh != null)
                {
                    IsBanTrong = true;
                }
                return IsBanTrong;
            }
        }
        public void Them(MyDatabase.Ban value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Insert_Ban(value.ID, value.TenBan, value.MaxSoLuong);
            }
        }
        public void Sua(MyDatabase.Ban value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Update_Ban(value.ID, value.TenBan, value.SoLuong, value.MaxSoLuong);
            }
        }
        public void Xoa(MyDatabase.Ban value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Delete_Ban(value.ID);
            }
        }

        public void Xoa(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Delete_Ban(ID);
            }
        }
    }
}
