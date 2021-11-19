using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core;

namespace QuanLyCafe
{
    public partial class FrmManHinhChinh : Form
    {
        DBaccess.NhanVienAccess NVAc;
        string IDNhanVien = null;
        string connectionString = null;
        public FrmManHinhChinh()
        {
            InitializeComponent();
            LoadLogin();
        }
        public FrmManHinhChinh(string IDNhanVien)
        {
            InitializeComponent();
            InitGUI();
        }
        public void LoadLogin()
        {
            btnQuanLyNhanVien.Visible = btnThucDon.Visible = btnBan.Visible = btnHoaDonBanHang.Visible = btnHoaDonNhapHang.Visible = btnKhoHang.Visible = false;
            MyForm.FrmLogin frmLg = new MyForm.FrmLogin(this ,connectionString);
            this.Hide();
            frmLg.ShowDialog();
            if (connectionString == null)
            {
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    // WinForms app
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    // Console app
                    System.Environment.Exit(1);
                }
            }
            grbChucNang.Controls.Clear();
            InitGUI();
        }
        //private bool CheckOpened(string name)
        //{
        //    FormCollection fc = Application.OpenForms;

        //    foreach (Form frm in fc)
        //    {
        //        if (frm.Text == name)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public void InitGUI()
        {
            NVAc = new DBaccess.NhanVienAccess(connectionString);
            btnQuanLyNhanVien.Visible = btnThucDon.Visible = btnBan.Visible = btnHoaDonBanHang.Visible = btnHoaDonNhapHang.Visible = btnKhoHang.Visible = false;
            grbCongCu.Enabled = true;
            MyForm.FrmSuDungDichVu frmThanhToan = new MyForm.FrmSuDungDichVu(IDNhanVien, connectionString);
            ShowForm(frmThanhToan, btnSuDungDichVu);
        }
        private void btnTaiKhoanCuaToi_Click(object sender, EventArgs e)
        {
            MyForm.FrmThongTinNhanVien frmThongTin = new MyForm.FrmThongTinNhanVien(this, IDNhanVien, connectionString);
            ShowForm(frmThongTin, btnTaiKhoanCuaToi);
        }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            var forms = grbChucNang.Controls.OfType<Form>();
            foreach (Form frm in forms)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(Form frm)
        {
            var forms = grbChucNang.Controls.OfType<Form>();
            foreach (Form form in forms)
            {
                if (form.Name == frm.Name)
                {
                    //switch (frm.Name)
                    //{
                    //    case "DoanhThu":
                    //        form = (MyForm.DoanhThu)form;
                    //        break;
                    //}
                    //form.Show();
                    form.Visible = true;
                }
                else
                {
                    //form.Hide();
                    form.Visible = false;
                }
            }
            var buttons = grbCongCu.Controls.OfType<Button>();
            foreach (Button btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.LightGray;
                btn.FlatAppearance.BorderSize = 1;
            }
        }
        private void ShowForm(Form frm, Button btn)
        {
            if (!CheckExistForm(frm.Name))
            {
                frm.MdiParent = this;
                grbChucNang.Controls.Add(frm);
            }
            ActiveChildForm(frm);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.Blue;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void btnSuDungDichVu_Click(object sender, EventArgs e)
        {
            MyForm.FrmSuDungDichVu frmThanhToan = new MyForm.FrmSuDungDichVu(IDNhanVien,connectionString);
            ShowForm(frmThanhToan, btnSuDungDichVu);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            MyForm.FrmSuDungNhapHang frmNhapHang = new MyForm.FrmSuDungNhapHang(IDNhanVien, connectionString);
            ShowForm(frmNhapHang, btnNhapHang);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.IDNhanVien = null;
            this.connectionString = null;
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                LoadLogin();
            }
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            MyForm.FrmKhoHang frmKH = new MyForm.FrmKhoHang(this, connectionString);
            ShowForm(frmKH, btnKhoHang);
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            MyForm.FrmBan frmB = new MyForm.FrmBan(this, connectionString);
            ShowForm(frmB, btnBan);
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            MyForm.FrmThucDon frmTD = new MyForm.FrmThucDon(this, connectionString);
            ShowForm(frmTD, btnThucDon);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            MyForm.DoanhThu frmDT = new MyForm.DoanhThu(connectionString);
            ShowForm(frmDT, btnDoanhThu);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            bool Quyen = NVAc.getQuyen(IDNhanVien);
            if (!Quyen)
            {
                MessageBox.Show("Bạn cần quyền admin để có thể truy cập chức năng này! Vui lòng liên hệ quản lý để cấp quyền");
            }
            else
            {
                if (btnKhoHang.Visible == false)
                {
                    btnQuanLyNhanVien.Visible = btnThucDon.Visible = btnBan.Visible = btnHoaDonBanHang.Visible = 
                        btnHoaDonNhapHang.Visible = btnKhoHang.Visible = true;
                }
                else
                {
                    btnQuanLyNhanVien.Visible = btnThucDon.Visible = btnBan.Visible = btnHoaDonBanHang.Visible = 
                        btnHoaDonNhapHang.Visible = btnKhoHang.Visible = false;
                    MyForm.FrmSuDungDichVu frmThanhToan = new MyForm.FrmSuDungDichVu(IDNhanVien,connectionString);
                    ShowForm(frmThanhToan, btnSuDungDichVu);
                }
            }
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            MyForm.FrmNhanVien frmNV = new MyForm.FrmNhanVien(this, IDNhanVien, connectionString);
            ShowForm(frmNV, btnQuanLyNhanVien);
        }

        private void btnHoaDonBanHang_Click(object sender, EventArgs e)
        {
            MyForm.FrmHoaDonBanHang frmHDBH = new MyForm.FrmHoaDonBanHang(this, connectionString);
            ShowForm(frmHDBH, btnHoaDonBanHang);
        }
        private void btnHoaDonNhapHang_Click(object sender, EventArgs e)
        {
            MyForm.FrmHoaDonNhapHang frmHDNH = new MyForm.FrmHoaDonNhapHang(this, connectionString);
            ShowForm(frmHDNH, btnHoaDonNhapHang);
        }
        public string getIDNhanVien()
        {
            return IDNhanVien;
        }
        public void setIDNhanVien(string IDNhanVien)
        {
            this.IDNhanVien = IDNhanVien;
        }
        public string getConnectionString()
        {
            return connectionString;
        }
        public void setConnectionString(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public bool getStatusGroupCongCu()
        {
            return grbCongCu.Enabled;
        }
        public void setStatusGroupCongCu(bool Enable)
        {
            this.grbCongCu.Enabled = Enable;
        }

        private void FrmManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
