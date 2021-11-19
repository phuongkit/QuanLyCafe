using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCafe.MyForm
{
    public partial class FrmThucDon : Form
    {
        FrmManHinhChinh frmMHC;
        DBaccess.LoaiThucDonAccess LTDAc;
        DBaccess.ThucDonAccess TDAc;
        string connectionString;
        bool Them;
        public FrmThucDon(FrmManHinhChinh frmMHC, string connectionString)
        {
            this.frmMHC = frmMHC;
            this.connectionString = connectionString;
            LTDAc = new DBaccess.LoaiThucDonAccess(connectionString);
            TDAc = new DBaccess.ThucDonAccess(connectionString);
            InitializeComponent();
        }

        private void loadData()
        {
            if (!frmMHC.getStatusGroupCongCu())
            {
                frmMHC.setStatusGroupCongCu(true);
            }
            List<MyDatabase.LoaiThucDon> listloaimon = new List<MyDatabase.LoaiThucDon>();
            listloaimon.Add(new MyDatabase.LoaiThucDon() { ID = null, TenloaiThucDon = null });
            foreach (var item in LTDAc.Get())
            {
                listloaimon.Add(item);
            }
            cbbLoaiMon.DataSource = listloaimon;
            cbbLoaiMon.DisplayMember = "TenLoaiThucDon";
            cbbLoaiMon.ValueMember = "ID";

            (DGV.Columns["IDLoaiThucDon"] as DataGridViewComboBoxColumn).DataSource = listloaimon;
            (DGV.Columns["IDLoaiThucDon"] as DataGridViewComboBoxColumn).DisplayMember = "TenLoaiThucDon";
            (DGV.Columns["IDLoaiThucDon"] as DataGridViewComboBoxColumn).ValueMember = "ID";
            DGV.DataSource = TDAc.Get();
            DGV.Columns["ChiTietHoaDonBanHangs"].Visible = false;
            DGV.Columns["LoaiThucDon"].Visible = false;
            clear();
            btnCreate.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtID.Enabled = false;
        }      
        private void dataBinding()
        {
            loadData();
            txtID.DataBindings.Clear();
            cbbLoaiMon.DataBindings.Clear();
            txtDonViTinh.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();
            txtTenMon.DataBindings.Clear();
            txtID.DataBindings.Add(new Binding("Text", DGV.DataSource, "ID",true,DataSourceUpdateMode.Never));
            txtTenMon.DataBindings.Add(new Binding("Text", DGV.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            txtDonViTinh.DataBindings.Add(new Binding("Text", DGV.DataSource, "DonViTinh", true, DataSourceUpdateMode.Never));
            txtDonGia.DataBindings.Add(new Binding("Text", DGV.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
            cbbLoaiMon.DataBindings.Add(new Binding("SelectedValue", DGV.DataSource, "IDLoaiThucDon", true, DataSourceUpdateMode.Never));
        }
        private void clear()
        {
            txtID.Text = txtDonGia.Text = txtDonViTinh.Text = cbbLoaiMon.Text = txtTenMon.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Them = true;
            frmMHC.setStatusGroupCongCu(false);
            btnCreate.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtID.Enabled = txtTenMon.Enabled = txtDonViTinh.Enabled = txtDonGia.Enabled = cbbLoaiMon.Enabled = true;
            clear();
            txtID.Focus();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataBinding();
        }

        private void FrmThucDon_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            dataBinding();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            MyDatabase.ThucDon t = new MyDatabase.ThucDon() ;
            if (Them)
            {
                try
                {
                    t.ID = txtID.Text.Trim();
                    t.Ten = txtTenMon.Text.Trim();
                    t.DonViTinh = txtDonViTinh.Text.Trim();
                    t.DonGia = float.Parse(txtDonGia.Text.ToString());
                    t.LoaiThucDon = LTDAc.getLoaiThucDon(cbbLoaiMon.SelectedValue.ToString().Trim());
                    TDAc.Them(t);
                    MessageBox.Show("Đã thêm thành công");
                    dataBinding();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Errors[0].Message);
                }
            }
            else
            {
                try
                {
                    t.ID = txtID.Text.Trim();
                    t.Ten = txtTenMon.Text.Trim();
                    t.DonViTinh = txtDonViTinh.Text.Trim();
                    t.DonGia = float.Parse(txtDonGia.Text.ToString());
                    t.LoaiThucDon = LTDAc.getLoaiThucDon(cbbLoaiMon.SelectedValue.ToString().Trim());
                    TDAc.Sua(t);
                    MessageBox.Show("Đã sửa thành công");
                    dataBinding();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Errors[0].Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Them = false;
            frmMHC.setStatusGroupCongCu(false);
            btnCreate.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtID.Enabled = false;
            txtTenMon.Enabled = txtDonViTinh.Enabled = txtDonGia.Enabled = cbbLoaiMon.Enabled = true;
            txtID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc mình muốn xóa dòng này không?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MyDatabase.ThucDon t = TDAc.getThucDon(txtID.Text.Trim());
                    TDAc.Xoa(t);
                    MessageBox.Show("Đã xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            dataBinding();
        }

        private void FrmThucDon_VisibleChanged(object sender, EventArgs e)
        {
            txtID.Enabled = txtTenMon.Enabled = txtDonViTinh.Enabled = txtDonGia.Enabled = cbbLoaiMon.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            dataBinding();
        }
    }
}
