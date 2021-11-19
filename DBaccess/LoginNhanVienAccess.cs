using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyCafe.DBaccess
{
    internal class LoginNhanVienAccess
    {
        private string connectionString;
        public LoginNhanVienAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public bool KiemTraLoGin(string LoginName, string Password)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                bool Invalid = false;
                Invalid = dbCafe.f_KiemTraLoGin(LoginName, Password).ToList().FirstOrDefault().Invalid == true ? true : false;
                return Invalid;    
            }
        }
        public string getIDNhanVien(string LoginName)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                string ID = null;
                ID = dbCafe.LoginNhanViens.ToList().Find(p => p.LoginName == LoginName).IDNhanVien;
                return ID;
            }
        }
        public MyDatabase.LoginNhanVien getLoginNhanVien(string LoginName)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                MyDatabase.LoginNhanVien lgNV = dbCafe.LoginNhanViens.ToList().Find(p => p.LoginName == LoginName);
                return lgNV;
            }
        }
        public void Them(MyDatabase.LoginNhanVien value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                try
                {
                    dbCafe.sp_Insert_LoginNhanVien(value.IDNhanVien, value.LoginName, value.Password, value.Permission, value.Ngaytao);
                }
                catch(SqlException ex)
                {
                    throw ex;
                }
            }
        }
        public void Sua(MyDatabase.LoginNhanVien value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                try
                {
                    dbCafe.sp_Update_LoginNhanVien(value.IDNhanVien, value.LoginName, value.Password, value.Permission, value.Ngaytao);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
        public void Xoa(MyDatabase.LoginNhanVien value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                try
                {
                    dbCafe.sp_Delete_LoginNhanVien(value.LoginName);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }

        public void Xoa(string LoginName)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                try
                {
                    dbCafe.sp_Delete_LoginNhanVien(LoginName);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
    }
}
