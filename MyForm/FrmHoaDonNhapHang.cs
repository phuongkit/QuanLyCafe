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
    public partial class FrmHoaDonNhapHang : Form
    {
        FrmManHinhChinh frmMHC;
        DBaccess.HoaDonNhapHangAccess HDNHAc;
        DBaccess.ChiTietHoaDonNhapHangAccess CTHDNHAc;
        string connectionString;
        List<MyDatabase.NhanVien> listNhanVien;
        List<MyDatabase.KhoHang> listKhoHang;
        bool Them, ThemCT;
        public FrmHoaDonNhapHang(FrmManHinhChinh frmMHC, string connectionString)
        {
            this.frmMHC = frmMHC;
            this.connectionString = connectionString;
            HDNHAc = new DBaccess.HoaDonNhapHangAccess(connectionString);
            CTHDNHAc = new DBaccess.ChiTietHoaDonNhapHangAccess(connectionString);
            InitializeComponent();
        }
        public void InitGUI()
        {
            if (!frmMHC.getStatusMenuStrip())
            {
                frmMHC.setStatusMenuStrip(true);
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnBoQua.Enabled = false;
            txtIDHoaDon.Enabled = cbbNhanVien.Enabled = dtNgayTao.Enabled = false;
            txtCTIDHoaDon.Enabled = cbbCTKhoHang.Enabled = nmCTSoLuong.Enabled = false;
            btnChiTietThem.Enabled = btnChiTietSua.Enabled = btnChiTietXoa.Enabled = btnChiTietLuu.Enabled = btnChiTietBoQua.Enabled = false;
        }

        public void DataBind()
        {
            DBaccess.BanAccess BAc = new DBaccess.BanAccess(connectionString);
            DBaccess.NhanVienAccess NVAc = new DBaccess.NhanVienAccess(connectionString);
            listNhanVien = NVAc.Get();

            dgvHoaDon.DataSource = HDNHAc.Get();
            dgvHoaDon.Columns["NhanVien"].Visible = false;
            dgvHoaDon.Columns["ChiTietHoaDonNhapHangs"].Visible = false;

            (dgvHoaDon.Columns["IDnhanVien"] as DataGridViewComboBoxColumn).DataSource = listNhanVien;
            (dgvHoaDon.Columns["IDnhanVien"] as DataGridViewComboBoxColumn).DisplayMember = "HoTen";
            (dgvHoaDon.Columns["IDnhanVien"] as DataGridViewComboBoxColumn).ValueMember = "ID";

            cbbNhanVien.DataSource = listNhanVien;
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "ID";

            txtIDHoaDon.DataBindings.Clear();
            cbbNhanVien.DataBindings.Clear();
            dtNgayTao.DataBindings.Clear();
            txtIDHoaDon.DataBindings.Add("Text", dgvHoaDon.DataSource, "ID", true, DataSourceUpdateMode.Never);
            cbbNhanVien.DataBindings.Add("SelectedValue", dgvHoaDon.DataSource, "IDnhanVien", true, DataSourceUpdateMode.Never);
            dtNgayTao.DataBindings.Add("Value", dgvHoaDon.DataSource, "Ngaytao", true, DataSourceUpdateMode.Never);
            dgvChiTietHoaDon.DataSource = new List<MyDatabase.ChiTietHoaDonNhapHang>();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmMHC.setStatusMenuStrip(false);
            Them = true;
            txtIDHoaDon.Enabled = cbbNhanVien.Enabled = dtNgayTao.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnBoQua.Enabled = true;
            txtIDHoaDon.Text = HDNHAc.getIDHoaDonNHMoi();

            txtCTIDHoaDon.Enabled = cbbCTKhoHang.Enabled = nmCTSoLuong.Enabled = false;
            btnChiTietThem.Enabled = btnChiTietSua.Enabled = btnChiTietXoa.Enabled = btnChiTietLuu.Enabled = btnChiTietBoQua.Enabled = false;
            dgvChiTietHoaDon.DataSource = new List<MyDatabase.ChiTietHoaDonNhapHang>();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmMHC.setStatusMenuStrip(false);
            Them = false;
            txtIDHoaDon.Enabled = cbbNhanVien.Enabled = dtNgayTao.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnBoQua.Enabled = true;
            txtIDHoaDon.Enabled = false;

            txtCTIDHoaDon.Enabled = cbbCTKhoHang.Enabled = nmCTSoLuong.Enabled = false;
            btnChiTietThem.Enabled = btnChiTietSua.Enabled = btnChiTietXoa.Enabled = btnChiTietLuu.Enabled = btnChiTietBoQua.Enabled = false;
            dgvChiTietHoaDon.DataSource = new List<MyDatabase.ChiTietHoaDonNhapHang>();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MyDatabase.HoaDonNhapHang hdnh = new MyDatabase.HoaDonNhapHang();
            hdnh = HDNHAc.getHoaDonNhapHang(txtIDHoaDon.Text);
            DialogResult traloi = MessageBox.Show("Bọn có muốn xóa hóa đơn này và các thông tin liên quan?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                try
                {
                    HDNHAc.Xoa(hdnh);
                    MessageBox.Show("Đã xóa thành công!");
                    InitGUI();
                    DataBind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            txtCTIDHoaDon.Enabled = cbbCTKhoHang.Enabled = nmCTSoLuong.Enabled = false;
            btnChiTietThem.Enabled = btnChiTietSua.Enabled = btnChiTietXoa.Enabled = btnChiTietLuu.Enabled = btnChiTietBoQua.Enabled = false;
            dgvChiTietHoaDon.DataSource = new List<MyDatabase.ChiTietHoaDonNhapHang>();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ID = txtIDHoaDon.Text;
            try
            {
                MyDatabase.HoaDonNhapHang hdnh = new MyDatabase.HoaDonNhapHang();
                hdnh = HDNHAc.getHoaDonNhapHang(ID);
                if (Them)
                {
                    if (hdnh == null)
                    {
                        try
                        {
                            MyDatabase.HoaDonNhapHang hd = new MyDatabase.HoaDonNhapHang();
                            hd.ID = txtIDHoaDon.Text;
                            hd.IDnhanVien = cbbNhanVien.SelectedValue.ToString();
                            hd.NgayTao = dtNgayTao.Value;
                            HDNHAc.Them(hd);
                            MessageBox.Show("Đã thêm thành công!");
                            InitGUI();
                            DataBind();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn với ID = " + ID + " đã được tạo! Vui lòng thử lại với ID khác!");
                        InitGUI();
                        DataBind();
                    }
                }
                else
                {
                    hdnh.IDnhanVien = cbbNhanVien.SelectedValue.ToString();
                    hdnh.NgayTao = dtNgayTao.Value;
                    HDNHAc.Sua(hdnh);
                    MessageBox.Show("Đã cập nhật thành công!");
                    InitGUI();
                    DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            InitGUI();
            DataBind();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DBaccess.KhoHangAccess KHAc = new DBaccess.KhoHangAccess(connectionString);
            listKhoHang = KHAc.Get();
            string ID = txtIDHoaDon.Text;
            txtCTIDHoaDon.Text = ID;
            dgvChiTietHoaDon.DataSource = HDNHAc.getCTHDNH(ID);
            dgvChiTietHoaDon.Columns["HoaDonNhapHang"].Visible = false;
            dgvChiTietHoaDon.Columns["KhoHang"].Visible = false;

            (dgvChiTietHoaDon.Columns["IDhang"] as DataGridViewComboBoxColumn).DataSource = listKhoHang;
            (dgvChiTietHoaDon.Columns["IDhang"] as DataGridViewComboBoxColumn).DisplayMember = "Ten";
            (dgvChiTietHoaDon.Columns["IDhang"] as DataGridViewComboBoxColumn).ValueMember = "ID";

            cbbCTKhoHang.DataSource = listKhoHang;
            cbbCTKhoHang.DisplayMember = "Ten";
            cbbCTKhoHang.ValueMember = "ID";

            txtCTIDHoaDon.DataBindings.Clear();
            cbbCTKhoHang.DataBindings.Clear();
            nmCTSoLuong.DataBindings.Clear();

            txtCTIDHoaDon.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "IDhoaDonNH", true, DataSourceUpdateMode.Never);
            cbbCTKhoHang.DataBindings.Add("SelectedValue", dgvChiTietHoaDon.DataSource, "IDhang", true, DataSourceUpdateMode.Never);
            nmCTSoLuong.DataBindings.Add("Value", dgvChiTietHoaDon.DataSource, "soLuong", true, DataSourceUpdateMode.Never);

            btnChiTietThem.Enabled = btnChiTietSua.Enabled = btnChiTietXoa.Enabled = true;
        }

        private void btnChiTietThem_Click(object sender, EventArgs e)
        {
            frmMHC.setStatusMenuStrip(false);
            ThemCT = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnBoQua.Enabled = false;
            btnChiTietThem.Enabled = btnChiTietSua.Enabled = btnChiTietXoa.Enabled = false;
            btnChiTietLuu.Enabled = btnChiTietBoQua.Enabled = true;
            cbbCTKhoHang.Enabled = nmCTSoLuong.Enabled = true;
        }

        private void btnChiTietSua_Click(object sender, EventArgs e)
        {
            frmMHC.setStatusMenuStrip(false);
            ThemCT = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnBoQua.Enabled = false;
            btnChiTietThem.Enabled = btnChiTietSua.Enabled = btnChiTietXoa.Enabled = false;
            btnChiTietLuu.Enabled = btnChiTietBoQua.Enabled = true;
            txtCTIDHoaDon.Enabled = cbbCTKhoHang.Enabled = false;
            nmCTSoLuong.Enabled = true;
        }

        private void btnChiTietXoa_Click(object sender, EventArgs e)
        {
            MyDatabase.ChiTietHoaDonNhapHang cthdnh = new MyDatabase.ChiTietHoaDonNhapHang();
            cthdnh = CTHDNHAc.getChiTietHoaDonNhapHang(txtCTIDHoaDon.Text, cbbCTKhoHang.SelectedValue.ToString());
            DialogResult traloi = MessageBox.Show("Bọn có muốn xóa thực đơn này khỏi hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                try { 
                    CTHDNHAc.Xoa(cthdnh);
                    MessageBox.Show("Đã xóa thành công!");
                    InitGUI();
                    DataBind();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Errors[0].Message);
                }
            }
            InitGUI();
            DataBind();
        }

        private void btnChiTietLuu_Click(object sender, EventArgs e)
        {
            string IDHoaDon = txtCTIDHoaDon.Text;
            string IDHang = cbbCTKhoHang.SelectedValue.ToString();
            int soLuong = int.Parse(nmCTSoLuong.Value.ToString());
            MyDatabase.ChiTietHoaDonNhapHang cthdnh = new MyDatabase.ChiTietHoaDonNhapHang();
            cthdnh = CTHDNHAc.getChiTietHoaDonNhapHang(IDHoaDon, IDHang);
            if (ThemCT)
            {
                if (cthdnh == null)
                {
                    MyDatabase.ChiTietHoaDonNhapHang cthd = new MyDatabase.ChiTietHoaDonNhapHang();
                    cthd.IDhoaDonNH = IDHoaDon;
                    cthd.IDhang = IDHang;
                    cthd.soLuong = soLuong;
                    try
                    {
                        CTHDNHAc.Them(cthd);
                        MessageBox.Show("Đã thêm thành công!");
                        InitGUI();
                        DataBind();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Errors[0].Message);
                    }
                }
                else
                {
                    MessageBox.Show("Hóa đơn với ID = " + IDHoaDon + " đã có thực đơn với ID =" + IDHang + "! Vui lòng thử lại với ID thực đơn khác!");
                    InitGUI();
                    DataBind();
                }
            }
            else
            {
                cthdnh.soLuong = soLuong;
                try
                {
                    CTHDNHAc.Sua(cthdnh);
                    MessageBox.Show("Đã cập nhật thành công!");
                    InitGUI();
                    DataBind();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Errors[0].Message);
                }
            }
        }

        private void FrmHoaDonNhapHang_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                InitGUI();
                DataBind();
            }
        }

        private void btnChiTietBoQua_Click(object sender, EventArgs e)
        {
            InitGUI();
            DataBind();
        }
    }
}
