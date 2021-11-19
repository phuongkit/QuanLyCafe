using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyCafe.DBaccess
{
    internal class KhoHangAccess
    {
        private string connectionString;
        public KhoHangAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<MyDatabase.KhoHang> Get()
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            return db.KhoHangs.ToList();
        }

        public void Them(MyDatabase.KhoHang value)
        {
            try
            {
                MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
                db.sp_Insert_KhoHang(value.ID, value.Ten, value.DonViTinh, value.soLuong, value.DonGia);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void Sua(MyDatabase.KhoHang value)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            try
            {
                db.sp_Update_KhoHang(value.ID, value.Ten, value.DonViTinh, value.soLuong, value.DonGia);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void Xoa(MyDatabase.KhoHang value)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            db.sp_Delete_KhoHang(value.ID);
        }

        public void Xoa(string ID)
        {
            MyDatabase.QuanLyCafeEntities db = new MyDatabase.QuanLyCafeEntities(connectionString);
            db.sp_Delete_KhoHang(ID);
        }
    }
}
