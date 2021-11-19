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
    public partial class DoanhThuNgay : Form
    {
        string connectionString;
        public DoanhThuNgay(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
            LoadBanHang();
        }

        public void LoadNhapHang()
        {
            Dgv_main.DataSource = null;
            Dgv_main.Rows.Clear();
            DBaccess.DoanhThuAccess dth = new DBaccess.DoanhThuAccess(connectionString);
            Dgv_main.DataSource = dth.GetDoanhThuNgay_BanHang(DateTime.Now);
        }

        public void LoadBanHang()
        {
            Dgv_main.DataSource = null;
            Dgv_main.Rows.Clear();
            DBaccess.DoanhThuAccess dth = new DBaccess.DoanhThuAccess(connectionString);
            Dgv_main.DataSource = dth.GetDoanhThuNgay_NhapHang(DateTime.Now);
        }

        private void Btn_switch_Click(object sender, EventArgs e)
        {
            switch(this.btn_switch.Text)
            {
                case "Nhập Hàng": 
                    this.btn_switch.Text = "Bán Hàng";
                    LoadNhapHang();
                    break;
                case "Bán Hàng": 
                    this.btn_switch.Text = "Nhập Hàng"; 
                    LoadBanHang();
                    break;
                default: break;
            }
        }
    }
}
