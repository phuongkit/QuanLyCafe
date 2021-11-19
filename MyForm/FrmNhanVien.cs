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
    public partial class FrmNhanVien : Form
    {
        FrmManHinhChinh frmMHC;
        DBaccess.NhanVienAccess NVAc;
        DBaccess.LoginNhanVienAccess LGNVAc;
        List<Quyen> listquyen;
        string IDNhanVien;
        string connectionString;
        bool Them;
        public FrmNhanVien(FrmManHinhChinh frmMHC, string IDNhanVien, string connectionString)
        {
            this.frmMHC = frmMHC;
            this.IDNhanVien = IDNhanVien;
            this.connectionString = connectionString;
            NVAc = new DBaccess.NhanVienAccess(connectionString);
            LGNVAc = new DBaccess.LoginNhanVienAccess(connectionString);
            InitializeComponent();
        }
        public void InitGUI()
        {
            if (!frmMHC.getStatusGroupCongCu())
            {
                frmMHC.setStatusGroupCongCu(true);
            }
            txtIDNhanVien.Enabled = txtID.Enabled = txtTen.Enabled = txtSDT.Enabled = txtCMND.Enabled = txtDiaChi.Enabled = dtNgayVaoLam.Enabled = dtNgayNghiViec.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
            lblDNhanVien.Visible = lblLoginName.Visible = lblNgayTao.Visible = lblPassword.Visible = lblQuyen.Visible = false;
            txtIDNhanVien.Visible = txtLoginName.Visible = txtPassword.Visible = cbbQuyen.Visible = dtNgayTao.Visible = false;
            btnTaoTaiKhoan.Visible = btnXoaTaiKhoan.Visible = btnCapNhatTaiKhoan.Visible = btnResetMatKhau.Visible = false;
            lbTaiKhoan.Visible = true;
            lbTaiKhoan.Text = "Chưa load dữ liệu";
        }
        public void DataBind()
        {
            dgvNhanVien.DataSource = NVAc.Get();
            dgvNhanVien.Columns["HoaDonBanHangs"].Visible = false;
            dgvNhanVien.Columns["HoaDonNhapHangs"].Visible = false;
            dgvNhanVien.Columns["LoginNhanViens"].Visible = false;
            txtID.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            dtNgayVaoLam.DataBindings.Clear();
            dtNgayNghiViec.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvNhanVien.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtTen.DataBindings.Add("Text", dgvNhanVien.DataSource, "HoTen", true, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", dgvNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Add("Text", dgvNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never);
            txtCMND.DataBindings.Add("Text", dgvNhanVien.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            dtNgayVaoLam.DataBindings.Add("Value", dgvNhanVien.DataSource, "NgayVaoLam", true, DataSourceUpdateMode.Never);
            dtNgayNghiViec.DataBindings.Add("Value", dgvNhanVien.DataSource, "NgayNghiViec", true, DataSourceUpdateMode.Never);
            listquyen = new List<Quyen>(){
                        new Quyen(){Type=true,Name="Admin" },
                        new Quyen(){Type=false,Name="Nhân viên"}
                    };
            cbbQuyen.DataSource = listquyen;
            cbbQuyen.DisplayMember = "Name";
            cbbQuyen.ValueMember = "Type";
        }


        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNhanVien.CurrentRow.Index;
            if (index > -1)
            {
                try
                {
                    string IDNhanVien = txtID.Text;
                    MyDatabase.LoginNhanVien lgNV = NVAc.getLoginNhanVien(IDNhanVien);
                    if (lgNV != null)
                    {
                        txtIDNhanVien.Text = lgNV.IDNhanVien;
                        txtLoginName.Text = lgNV.LoginName;
                        cbbQuyen.SelectedValue = lgNV.Permission;
                        dtNgayTao.Value = lgNV.Ngaytao;
                        lblDNhanVien.Visible = lblLoginName.Visible = lblNgayTao.Visible = lblPassword.Visible = lblQuyen.Visible = true;
                        txtIDNhanVien.Visible = txtLoginName.Visible = txtPassword.Visible = cbbQuyen.Visible = dtNgayTao.Visible = true;
                        btnXoaTaiKhoan.Visible = btnCapNhatTaiKhoan.Visible = btnResetMatKhau.Visible = true;
                        btnTaoTaiKhoan.Visible = false;
                        lbTaiKhoan.Visible = false;
                        txtLoginName.Enabled = false;
                    }
                    else
                    {
                        InitGUI();
                        btnTaoTaiKhoan.Visible = true;
                        txtLoginName.Enabled = true;
                        lbTaiKhoan.Text = "Nhân viên này chưa tạo tài khoản";
                        btnTaoTaiKhoan.Text = "Yêu cầu tạo";
                        txtIDNhanVien.Text = txtID.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmMHC.setStatusGroupCongCu(false);
            Them = true;
            txtID.Enabled = txtTen.Enabled = txtSDT.Enabled = txtCMND.Enabled = txtDiaChi.Enabled = dtNgayVaoLam.Enabled = dtNgayNghiViec.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmMHC.setStatusGroupCongCu(false);
            Them = false;
            txtTen.Enabled = txtSDT.Enabled = txtCMND.Enabled = txtDiaChi.Enabled = dtNgayVaoLam.Enabled = dtNgayNghiViec.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    NVAc.Them(new MyDatabase.NhanVien() { ID = txtID.Text, HoTen = txtTen.Text, SDT = txtSDT.Text, CMND = txtCMND.Text, DiaChi = txtDiaChi.Text, NgayVaoLam = dtNgayVaoLam.Value });
                    MessageBox.Show("Đã thêm thành công");
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
                try
                {
                    MyDatabase.NhanVien nv = new MyDatabase.NhanVien();
                    nv.ID = txtID.Text;
                    nv.HoTen = txtTen.Text;
                    nv.SDT = txtSDT.Text;
                    nv.CMND = txtCMND.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.NgayVaoLam = dtNgayVaoLam.Value;
                    nv.NgayNghiViec = dtNgayNghiViec.Value;
                    NVAc.Sua(nv);
                    MessageBox.Show("Đã cập nhật thành công");
                    InitGUI();
                    DataBind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            if (ID != IDNhanVien)
            {
                DialogResult traloi = MessageBox.Show("Bạn có muốn xóa nhân viên với ID = " + ID + " và tài khoản của nhân viên(nếu có) không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (traloi == DialogResult.OK)
                {
                    try
                    {
                        NVAc.Xoa(ID);
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
                else
                {
                    InitGUI();
                    DataBind();
                }
            }
            else
            {
                MessageBox.Show("Đây là bạn, không thể xóa chính bạn khỏi danh sách nhân viên! Vui lòng liên hệ quản lý!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            InitGUI();
            DataBind();
        }
        public class Quyen
        {
            public bool Type { get; set; }
            public string Name { get; set; }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if (lbTaiKhoan.Visible)
            {
                lbTaiKhoan.Visible = false;
                btnTaoTaiKhoan.Text = "Tạo tài khoản";
                lblDNhanVien.Visible = lblLoginName.Visible = lblNgayTao.Visible = lblPassword.Visible = lblQuyen.Visible = true;
                txtIDNhanVien.Visible = txtLoginName.Visible = txtPassword.Visible = cbbQuyen.Visible = dtNgayTao.Visible = true;
                dtNgayTao.Value = DateTime.Now;
            }
            else
            {
                if (txtLoginName.Text == "")
                {
                    MessageBox.Show("Không thể để trống loginame");
                    return;
                }
                int index = dgvNhanVien.CurrentRow.Index;
                if (index > -1)
                {
                    try
                    {
                        string ID = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
                        MyDatabase.LoginNhanVien nv = new MyDatabase.LoginNhanVien();
                        nv = NVAc.getLoginNhanVien(ID);
                        if (nv == null)
                        {
                            MyDatabase.LoginNhanVien lgNV = new MyDatabase.LoginNhanVien();
                            lgNV = LGNVAc.getLoginNhanVien(txtLoginName.Text);
                            if (lgNV == null)
                            {
                                MessageBox.Show("Loginname này đã được tạo, vui lòng tạo với tên khác!");
                            }
                            else
                            {
                                string password = txtPassword.Text;
                                if (password.Length < 8)
                                {
                                    MessageBox.Show("Mật khẩu phải lớn hơn 7 kí tự");
                                    return;
                                }
                                try
                                {
                                    LGNVAc.Them(new MyDatabase.LoginNhanVien() { IDNhanVien = ID, LoginName = txtLoginName.Text, Password = txtPassword.Text, Permission = bool.Parse(cbbQuyen.SelectedValue.ToString()), Ngaytao = dtNgayTao.Value });
                                    MessageBox.Show("Thêm tài khoản thành công");
                                }
                                catch (SqlException ex)
                                {
                                    MessageBox.Show(ex.Errors[0].Message);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nhân viên này đã có tài khoản! Không thể tạo thêm!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để tạo tài khoản");
                }
            }
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string LoginName = txtLoginName.Text;
            if (ID != IDNhanVien)
            {
                DialogResult traloi = MessageBox.Show("Bạn có muốn xóa tài khoản của nhân viên có ID =" + ID + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (traloi == DialogResult.OK)
                {
                    try
                    {
                        MyDatabase.LoginNhanVien lgNV = new MyDatabase.LoginNhanVien();
                        lgNV = LGNVAc.getLoginNhanVien(LoginName);
                        if (lgNV != null)
                        {
                            try
                            {
                                LGNVAc.Xoa(lgNV);
                                MessageBox.Show("Đã xóa thành công!");
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
                            MessageBox.Show("Đã xảy ra lỗi khi xóa");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Đây là tài khoản của bạn! Không thể xóa khi đăng nhập!");
            }
        }

        private void btnCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string LoginName = txtLoginName.Text;
            try
            {
                MyDatabase.LoginNhanVien lgNV = new MyDatabase.LoginNhanVien();
                lgNV = LGNVAc.getLoginNhanVien(LoginName);
                if (lgNV != null)
                {
                    string password = txtPassword.Text;
                    if (password == "")
                    {
                        password = lgNV.Password;
                    }
                    else if (password.Length < 4)
                    {
                        MessageBox.Show("Mật khẩu mới phải lớn hơn 3 kí tự!");
                        return;
                    }
                    lgNV.Password = password;
                    lgNV.Permission = bool.Parse(cbbQuyen.SelectedValue.ToString());
                    lgNV.Ngaytao = dtNgayTao.Value;
                    try
                    {
                        LGNVAc.Sua(lgNV);
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Errors[0].Message);
                    }
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại sau!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string LoginName = txtLoginName.Text;
            try
            {
                MyDatabase.LoginNhanVien lgNV = new MyDatabase.LoginNhanVien();
                lgNV = LGNVAc.getLoginNhanVien(LoginName);
                if (lgNV != null)
                {
                    lgNV.Password = "12345";
                    DialogResult traloi = MessageBox.Show("Bạn có muốn reset tài khoản này về mật khẩu mặc định (mặc định: 12345) không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (traloi == DialogResult.OK)
                    {
                        try
                        {
                            LGNVAc.Sua(lgNV);
                            MessageBox.Show("Đặt lại mật khẩu thành công!");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Errors[0].Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại sau!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void FrmNhanVien_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                InitGUI();
                DataBind();
            }
        }
    }
}
