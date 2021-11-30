using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Management;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;

namespace QuanLyCafe.MyForm
{
    public partial class FrmLogin : Form
    {
        //DBaccess.LoginNhanVienAccess lNVAc;
        private string IDNhanVien = null;
        private string connectionString = null;
        FrmManHinhChinh frmMHC;
        //MyDatabase.QuanLyCafeEntities db;
        public FrmLogin(FrmManHinhChinh frmMHC,string connectionString)
        {
            this.frmMHC = frmMHC;
            this.connectionString = connectionString;
            //lNVAc = new DBaccess.LoginNhanVienAccess(connectionString);
            //db = new MyDatabase.QuanLyCafeEntities(connectionString);
            InitializeComponent();
            //db.Database.Connection.ConnectionString
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txbPassWord.PasswordChar = (char)0;
            }
            else
            {
                txbPassWord.PasswordChar = '*';
            }
        }
        public string getIDNhanVien()
        {
            return this.IDNhanVien;
        }
        public string getConnectionString()
        {
            return this.connectionString;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            //if (lNVAc.KiemTraLoGin(userName, passWord))
            //IDNhanVien = lNVAc.getIDNhanVien(userName);
            //IDNhanVien = "01";
            string dataSource = cbbDataSource.Text;
            string initialCatalog = "QuanLyCafe";
            DBaccess.AppSetting setting = new DBaccess.AppSetting();

            connectionString = setting.getConnectionString(dataSource, initialCatalog, userName, passWord);
            using (var db = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                try
                {
                    DBaccess.LoginNhanVienAccess lgnv = new DBaccess.LoginNhanVienAccess(connectionString);
                    if (lgnv.getLoginNhanVien(userName) != null)
                    {
                        this.IDNhanVien = lgnv.getIDNhanVien(userName);
                        this.Hide();
                        frmMHC.Show();
                        frmMHC.setIDNhanVien(this.IDNhanVien);
                        frmMHC.setConnectionString(connectionString);
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản này không trùng khớp với tài khoản trên CSDL! Vui lòng thử lại với tài khoản khác!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data Source hay tài khoản này không trùng khớp với tài khoản trên hệ thống! Vui lòng thử lại với tài khoản khác!");
                    return;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                //Application.Exit();
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (IDNhanVien == null)
            //{
            //    if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            //    {
            //        Application.Exit();
            //    }
            //}
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cbbDataSource.Items.Add(".");
            cbbDataSource.Items.Add("(local)");
            cbbDataSource.Items.Add(@".\SQLEXPRESS");
            cbbDataSource.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cbbDataSource.Items.Add(string.Format(@"{0}\SQLEXPRESS01", Environment.MachineName));
            cbbDataSource.SelectedIndex = 3;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
