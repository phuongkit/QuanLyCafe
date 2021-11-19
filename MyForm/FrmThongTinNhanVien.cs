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
    public partial class FrmThongTinNhanVien : Form
    {
        DBaccess.LoginNhanVienAccess lNVAc;
        DBaccess.NhanVienAccess NVAc;
        string IDNhanVien = null;
        string connectionString;
        FrmManHinhChinh frmMHC;
        public FrmThongTinNhanVien(FrmManHinhChinh frmMHC,string IDNhanVien, string connectionString)
        {
            this.frmMHC = frmMHC;
            this.IDNhanVien = IDNhanVien;
            this.connectionString = connectionString;
            lNVAc = new DBaccess.LoginNhanVienAccess(connectionString);
            NVAc = new DBaccess.NhanVienAccess(connectionString);
            InitializeComponent();
        }
        public void InitGUI()
        {
            if (!frmMHC.getStatusGroupCongCu())
            {
                frmMHC.setStatusGroupCongCu(true);
            }
            try
            {
                MyDatabase.f_LayThongTinNhanVien_Result nv = NVAc.getThongTinNhanVien(IDNhanVien);
                if (nv != null)
                {
                    txtID.Text = nv.ID;
                    txtTen.Text = nv.HoTen;
                    txtSDT.Text = nv.SDT;
                    txtCMND.Text = nv.CMND;
                    txtDiaChi.Text = nv.DiaChi;
                    dtNgayVaoLam.Value = nv.NgayVaoLam;
                    txtLoginName.Text = nv.LoginName;
                    txtMatKhauCu.Text = "";
                    txtMatKhauMoi.Text = "";
                    txtNhapLaiMatKhau.Text = "";
                    txtQuyen.Text = nv.Permission ? "Admin" : "Nhân viên";
                    dtNgayTao.Value = nv.Ngaytao;
                }
                else
                {
                    MessageBox.Show("Tải dữ liệu không thành công");
                }
                txtTen.Enabled = false;
                txtSDT.Enabled = false;
                txtCMND.Enabled = false;
                txtDiaChi.Enabled = false;
                txtMatKhauCu.Enabled = false;
                txtMatKhauMoi.Enabled = false;
                txtNhapLaiMatKhau.Enabled = false;
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                btnCapNhat.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            frmMHC.setStatusGroupCongCu(false);
            txtTen.Enabled = true;
            txtSDT.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMatKhauCu.Enabled = true;
            txtMatKhauMoi.Enabled = true;
            txtNhapLaiMatKhau.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool capNhatCaNhan = false;
            bool capNhatTaiKhoan = false;
            if (txtMatKhauCu.Text != "" || txtMatKhauMoi.Text != "" || txtNhapLaiMatKhau.Text != "")
            {
                try
                {
                    bool check = lNVAc.KiemTraLoGin(txtLoginName.Text, txtMatKhauCu.Text);
                    if (check)
                    {
                        if (txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
                        {
                            if (txtMatKhauMoi.Text.Length < 4)
                            {
                                txtMatKhauCu.ResetText();
                                txtMatKhauMoi.ResetText();
                                txtNhapLaiMatKhau.ResetText();
                                MessageBox.Show("Mật khẩu mới phải lớn hơn hoặc bằng 3 kí tự!");
                                return;
                            }
                            else
                            {
                                capNhatTaiKhoan = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu mới không khớp với nhau!");
                            txtMatKhauCu.ResetText();
                            txtMatKhauMoi.ResetText();
                            txtNhapLaiMatKhau.ResetText();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng!");
                        txtMatKhauCu.ResetText();
                        txtMatKhauMoi.ResetText();
                        txtNhapLaiMatKhau.ResetText();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            try
            {
                MyDatabase.f_LayThongTinNhanVien_Result f_nv = NVAc.getThongTinNhanVien(IDNhanVien);
                if (f_nv != null)
                {
                    if (txtTen.Text != f_nv.HoTen || txtSDT.Text != f_nv.SDT || txtCMND.Text != f_nv.CMND || txtDiaChi.Text != f_nv.DiaChi)
                    {
                        if (txtSDT.Text.Length > 9)
                        {
                            MessageBox.Show("Số điện thoại không quá 10 số!");
                            return;
                        }
                        if (txtCMND.Text.Length > 9)
                        {
                            MessageBox.Show("CMND/CCCD không quá 10 số!");
                            return;
                        }
                        capNhatCaNhan = true;
                    }
                    if (capNhatCaNhan && capNhatTaiKhoan)
                    {
                        DialogResult traloi = MessageBox.Show("Bạn vừa thay đổi thông tin cá nhân và thông tin tài khoản! Bạn có muốn cập nhật cả hai?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (traloi == DialogResult.OK)
                        {
                            MyDatabase.NhanVien nv = NVAc.getNhanVien(txtID.Text);
                            MyDatabase.LoginNhanVien lg = lNVAc.getLoginNhanVien(txtLoginName.Text);
                            if (nv != null && lg != null)
                            {
                                nv.HoTen = txtTen.Text;
                                nv.SDT = txtSDT.Text;
                                nv.CMND = txtCMND.Text;
                                nv.DiaChi = txtDiaChi.Text;
                                lg.Password = txtMatKhauMoi.Text;
                                NVAc.Sua(nv);
                                try
                                {
                                    lNVAc.Sua(lg);
                                    MessageBox.Show("Cập nhật thông tin cá nhân và mật khẩu thành công! Vui lòng đăng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                    frmMHC.LoadLogin();
                                    return;
                                }
                                catch (SqlException ex)
                                {
                                    MessageBox.Show(ex.Errors[0].Message);
                                    MessageBox.Show("Cập nhật thông tin cá nhân và mật khẩu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật không thành công");
                            }
                        }
                    }
                    else if (capNhatCaNhan == true && capNhatTaiKhoan == false)
                    {
                        DialogResult traloi = MessageBox.Show("Bạn vừa thay đổi thông tin cá nhân! Bạn có muốn cập nhật nó?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (traloi == DialogResult.OK)
                        {
                            MyDatabase.NhanVien nv = NVAc.getNhanVien(txtID.Text);
                            if (nv != null)
                            {
                                nv.HoTen = txtTen.Text;
                                nv.SDT = txtSDT.Text;
                                nv.CMND = txtCMND.Text;
                                nv.DiaChi = txtDiaChi.Text;
                                try
                                {
                                    NVAc.Sua(nv);
                                    MessageBox.Show("Cập nhật thành công");
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật không thành công");
                            }
                        }
                    }
                    else if (capNhatCaNhan == false && capNhatTaiKhoan == true)
                    {
                        DialogResult traloi = MessageBox.Show("Bạn vừa thay đổi thông tin tài khoản! Bạn có muốn cập nhật nó?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (traloi == DialogResult.OK)
                        {
                            MyDatabase.LoginNhanVien lg = lNVAc.getLoginNhanVien(txtLoginName.Text);
                            if (lg != null)
                            {
                                lg.Password = txtMatKhauMoi.Text;
                                try
                                {
                                    lNVAc.Sua(lg);
                                    MessageBox.Show("Cập nhật mật khẩu thành công! Vui lòng đăng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close();
                                    this.Close();
                                    frmMHC.LoadLogin();
                                    return;
                                }
                                catch (SqlException ex)
                                {
                                    MessageBox.Show(ex.Errors[0].Message);
                                    MessageBox.Show("Cập nhật thông tin cá nhân và mật khẩu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật không thành công");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi được cập nhật");
                    }
                }
                else
                {
                    MessageBox.Show("Tải dữ liệu không thành công");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitGUI();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            InitGUI();
        }

        private void FrmThongTinNhanVien_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                InitGUI();
            }
        }
    }
}
