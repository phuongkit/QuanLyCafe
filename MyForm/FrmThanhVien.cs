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
        FrmManHinhChinhAdmin frmAdmin;
        private DBaccess.ThanhVienAccess TVAc;
        private string connectionString;
        private bool Them;
        public FrmThanhVien(FrmManHinhChinhNhanVien frmMHC, string connectionString)
        {
            this.frmNV = frmMHC;
            this.connectionString = connectionString;
            TVAc = new DBaccess.ThanhVienAccess(connectionString);
            InitializeComponent();
            DataBind();
        }
        public FrmThanhVien(FrmManHinhChinhAdmin frmMHC, string connectionString)
        {
            this.frmAdmin = frmMHC;
            this.connectionString = connectionString;
            TVAc = new DBaccess.ThanhVienAccess(connectionString);
            InitializeComponent();
            DataBind();
        }
        public void DataBind()
        {
            btnTaoThanhVien.Enabled = true;
            btnCapNhatThanhVien.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnBoQua.Enabled = false;
            txtDiaChi.Enabled = txtIDNhanVien.Enabled = txtHoTen.Enabled = txtSDT.Enabled = txtEmail.Enabled = txtCMND.Enabled = dtNgayTao.Enabled = false;
            dgvKhachHang.DataSource = TVAc.Get();
            dgvKhachHang.Columns["HoaDonBanHangs"].Visible = false;

            txtIDNhanVien.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            dtNgayTao.DataBindings.Clear();
            txtIDNhanVien.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtCMND.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            dtNgayTao.DataBindings.Add(new Binding("Value", dgvKhachHang.DataSource, "NgayTao", true, DataSourceUpdateMode.Never));
        }

        private void btnTaoThanhVien_Click(object sender, EventArgs e)
        {
            Them = true;
            txtDiaChi.Enabled = txtHoTen.Enabled = txtSDT.Enabled = txtEmail.Enabled = txtCMND.Enabled = dtNgayTao.Enabled = true;
            txtIDNhanVien.Text = txtHoTen.Text = txtSDT.Text = txtEmail.Text = txtCMND.Text = "";
            btnLuu.Enabled = btnXoa.Enabled = btnBoQua.Enabled = true;
            btnTaoThanhVien.Enabled = btnCapNhatThanhVien.Enabled = false;
            dtNgayTao.Value = DateTime.Now;
        }

        private void btnCapNhatThanhVien_Click(object sender, EventArgs e)
        {
            txtDiaChi.Enabled = txtIDNhanVien.Enabled = txtHoTen.Enabled = txtSDT.Enabled = txtEmail.Enabled = txtCMND.Enabled = dtNgayTao.Enabled = true;
            Them = false;
            btnLuu.Enabled = btnXoa.Enabled = btnBoQua.Enabled = true;
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
                    MessageBox.Show("Đã thêm thành công!");
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
                    MessageBox.Show("Đã cập nhật thành công!");
                    DataBind();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    DataBind();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thành viên này không?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MyDatabase.ThanhVien tv = new MyDatabase.ThanhVien();
                tv = TVAc.getThanhVien(txtIDNhanVien.Text);

                TVAc.Xoa(tv);
                
                MessageBox.Show("Đã xóa thành công");
                DataBind();
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTaoThanhVien.Enabled = btnCapNhatThanhVien.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
