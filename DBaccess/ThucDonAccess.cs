using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyCafe.DBaccess
{
    internal class ThucDonAccess
    {
        private string connectionString;
        public ThucDonAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<MyDatabase.ThucDon> Get()
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.ThucDons.ToList();
            }
        }
        public MyDatabase.ThucDon getThucDon(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                MyDatabase.ThucDon b = dbCafe.ThucDons.ToList().Find(p => p.ID == ID);
                return b;
            }
        }
        public void Them(MyDatabase.ThucDon value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                try
                {
                    dbCafe.sp_Insert_ThucDon(value.ID, value.Ten, value.DonViTinh, value.DonGia, value.LoaiThucDon.ID);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
        public void Sua(MyDatabase.ThucDon value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                try
                {
                    dbCafe.sp_Update_ThucDon(value.ID, value.Ten, value.DonViTinh, value.DonGia, value.LoaiThucDon.ID);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
        public void Xoa(MyDatabase.ThucDon value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Delete_ThucDon(value.ID);
            }
        }

        public void Xoa(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Delete_ThucDon(ID);
            }
        }
    }
}
