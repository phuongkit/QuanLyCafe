using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DBaccess
{
    internal class NhanVienAccess
    {
        private string connectionString;
        public NhanVienAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<MyDatabase.NhanVien> Get()
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.NhanViens.ToList();
            }
        }
        public MyDatabase.f_LayThongTinNhanVien_Result getThongTinNhanVien(string IDNhanVien)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                MyDatabase.f_LayThongTinNhanVien_Result ttNV = dbCafe.f_LayThongTinNhanVien(IDNhanVien).First();
                return ttNV;
            }
        }
        public MyDatabase.NhanVien getNhanVien(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                MyDatabase.NhanVien nv = dbCafe.NhanViens.ToList().Find(p => p.ID == ID);
                return nv;
            }
        }
        public bool getQuyen(string IDNhanVien)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                bool quyen = false;
                MyDatabase.f_LayThongTinNhanVien_Result ttNV = dbCafe.f_LayThongTinNhanVien(IDNhanVien).ToList().FirstOrDefault();
                if (ttNV != null)
                {
                    quyen = ttNV.Permission;
                }
                return quyen;
            }
        }
        public string getLoginName(string IDNhanVien)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                string LoginName = "anonymous";
                MyDatabase.f_LayThongTinNhanVien_Result ttNV = dbCafe.f_LayThongTinNhanVien(IDNhanVien).ToList().FirstOrDefault();
                if (ttNV != null)
                {
                    LoginName = ttNV.LoginName;
                }
                return LoginName;
            }
        }
        public MyDatabase.LoginNhanVien getLoginNhanVien(string IDNhanVien)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                MyDatabase.LoginNhanVien lgNV = new MyDatabase.LoginNhanVien();
                lgNV = dbCafe.LoginNhanViens.ToList().Find(p => p.IDNhanVien == IDNhanVien);
                return lgNV;
            }
        }

        public void Them(MyDatabase.NhanVien value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Insert_NhanVien(value.ID, value.HoTen, value.SDT, value.CMND, value.DiaChi, value.NgayVaoLam, null, value.LuongCoBan);

            }
        }
        public void Sua(MyDatabase.NhanVien value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Update_NhanVien(value.ID, value.HoTen, value.SDT, value.CMND, value.DiaChi, value.NgayVaoLam, value.NgayNghiViec, value.LuongCoBan);
            }
        }
        public void Xoa(MyDatabase.NhanVien value)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Delete_NhanVien(value.ID);
            }
        }

        public void Xoa(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                dbCafe.sp_Delete_NhanVien(ID);
            }
        }

    }
}
