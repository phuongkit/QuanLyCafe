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
    public partial class DoanhThu : Form
    {
        string connectionString;
        public DoanhThu(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private new void Load()
        {
            DBaccess.DoanhThuAccess dthu = new  DBaccess.DoanhThuAccess(connectionString);
            dgv_main.DataSource = null;
            dgv_main.Rows.Clear();
            dgv_main.DataSource = dthu.GetDoanhThu(Date_from.Value, Date_to.Value);
            dgv_main.AutoGenerateColumns = true;
        }

        private void Dgv_main_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MyForm.DoanhThuNgay dtn = new DoanhThuNgay(connectionString);
            dtn.Date_NgayChitiet.Value = (DateTime)dgv_main.Rows[e.RowIndex].Cells[0].Value; 
            dtn.ShowDialog();
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            this.Load();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            int index = dgv_main.CurrentRow != null ? dgv_main.CurrentRow.Index : -1;
            if (index > -1)
            {
                MyForm.DoanhThuNgay dtn = new DoanhThuNgay(connectionString);
                dtn.Date_NgayChitiet.Value = (DateTime)dgv_main.Rows[index].Cells[0].Value;
                dtn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày cần xem");
            }
        }

        private void DoanhThu_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Load();
            }
        }
    }
}
