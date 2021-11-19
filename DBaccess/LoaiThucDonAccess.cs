using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DBaccess
{
    internal class LoaiThucDonAccess
    {
        private string connectionString;
        public LoaiThucDonAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<MyDatabase.LoaiThucDon> Get()
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.LoaiThucDons.ToList();
            }
        }
        public MyDatabase.LoaiThucDon getLoaiThucDon(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.LoaiThucDons.ToList().Find(p => p.ID == ID);
            }
        }
        public List<MyDatabase.f_LayCTLoaiThucDon_Result> getCTLoaiThucDon(string ID)
        {
            using (var dbCafe = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                return dbCafe.f_LayCTLoaiThucDon(ID).ToList();
            }
        }
    }
}
