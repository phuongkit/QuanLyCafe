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
    public partial class FrmThanhVien : Form
    {
        FrmManHinhChinhNhanVien frmNV;
        private DBaccess.ThanhVienAccess TVAc;
        private string connectionString;
        private bool Them;
        public FrmThanhVien(FrmManHinhChinhNhanVien frmMHC, string connectionString)
        {
            this.frmNV = frmMHC;
            this.connectionString = connectionString;
            TVAc = new DBaccess.ThanhVienAccess(connectionString);
            InitializeComponent();
        }
        public void DataBind()
        {
            btnCapNhatThanhVien.Enabled = btnCheckEmail.Enabled = btnLuu.Enabled = false;
            txtIDNhanVien.Enabled = txtHoTen.Enabled = txtSDT.Enabled = txtEmail.Enabled = txtCMND.Enabled = dtNgayTao.Enabled = false;
            dgvKhachHang.DataSource = TVAc.Get();

            txtIDNhanVien.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            dtNgayTao.DataBindings.Clear();
            txtIDNhanVien.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtCMND.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            dtNgayTao.DataBindings.Add(new Binding("Value", dgvKhachHang.DataSource, "NgayTao", true, DataSourceUpdateMode.Never));
        }

        private void btnTaoThanhVien_Click(object sender, EventArgs e)
        {
            Them = true;
            txtHoTen.Enabled = txtSDT.Enabled = txtEmail.Enabled = txtCMND.Enabled = dtNgayTao.Enabled = true;
            txtIDNhanVien.Text = txtHoTen.Text = txtSDT.Text = txtEmail.Text = txtCMND.Text = "";
            btnLuu.Enabled = btnCheckEmail.Enabled = true;
            btnTaoThanhVien.Enabled = btnCapNhatThanhVien.Enabled = false;
            dtNgayTao.Value = DateTime.Now;
        }

        private void btnCapNhatThanhVien_Click(object sender, EventArgs e)
        {
            txtIDNhanVien.Enabled = txtHoTen.Enabled = txtSDT.Enabled = txtEmail.Enabled = txtCMND.Enabled = dtNgayTao.Enabled = true;
            Them = false;
            btnLuu.Enabled = btnCheckEmail.Enabled = true;
            btnTaoThanhVien.Enabled = btnCapNhatThanhVien.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    MyDatabase.ThanhVien tv = new MyDatabase.ThanhVien();
                    tv.ID = txtIDNhanVien.Text;
                    tv.HoTen = txtHoTen.Text;
                    tv.Email = txtEmail.Text;
                    tv.DiaChi = txtCMND.Text;
                    tv.CMND = txtCMND.Text;
                    tv.NgayTao = dtNgayTao.Value;
                    tv.SDT = txtSDT.Text;
                    TVAc.Them(tv);
                    DataBind();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    DataBind();
                }
            }
            else
            {
                try
                {
                    MyDatabase.ThanhVien tv = TVAc.getThanhVien(txtIDNhanVien.Text);
                    tv.HoTen = txtHoTen.Text;
                    tv.Email = txtEmail.Text;
                    tv.DiaChi = txtCMND.Text;
                    tv.CMND = txtCMND.Text;
                    tv.NgayTao = dtNgayTao.Value;
                    tv.SDT = txtSDT.Text;
                    TVAc.Sua(tv);
                    DataBind();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    DataBind();
                }
            }
        }
    }
}
