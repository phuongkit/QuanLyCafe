using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.MyForm
{
    public partial class FrmLogin : Form
    {
        private string IDNhanVien = null;
        private string connectionString = null;
        public FrmLogin()
        {
            InitializeComponent();
            btnLogin.TabStop = false;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;

            btnExit.TabStop = false;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
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
            string dataSource = string.Format(@"{0}\SQLEXPRESS", Environment.MachineName);
            string initialCatalog = "QuanLyCafe";
            DBaccess.AppSetting setting = new DBaccess.AppSetting();

            connectionString = setting.getConnectionString(dataSource, initialCatalog, userName, passWord);
            using (var db = new MyDatabase.QuanLyCafeEntities(connectionString))
            {
                try
                {
                    DBaccess.LoginNhanVienAccess lgnv = new DBaccess.LoginNhanVienAccess(connectionString);
                    MyDatabase.LoginNhanVien nv = lgnv.getLoginNhanVien(userName);
                    if (nv != null)
                    {
                        if (rdbtnAdmin.Checked == true)
                        {
                            if (!nv.Permission)
                            {
                                MessageBox.Show("Bạn không có quyền đăng nhập với chức năng này");
                                return;
                            }
                            this.IDNhanVien = lgnv.getIDNhanVien(userName);
                            FrmManHinhChinhAdmin frmAdmin = new FrmManHinhChinhAdmin(this, IDNhanVien, connectionString);
                            frmAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            this.IDNhanVien = lgnv.getIDNhanVien(userName);
                            FrmManHinhChinhNhanVien frmNV = new FrmManHinhChinhNhanVien(this, IDNhanVien, connectionString);
                            frmNV.Show();
                            this.Hide();
                        }
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
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.connectionString = "";
            this.IDNhanVien = "";
        }
    }
}
