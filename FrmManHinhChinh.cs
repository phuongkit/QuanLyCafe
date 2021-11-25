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

        public void InitGUI()
        {
            NVAc = new DBaccess.NhanVienAccess(connectionString);
            MyForm.FrmSuDungDichVu frmThanhToan = new MyForm.FrmSuDungDichVu(IDNhanVien, connectionString);
            ShowForm(frmThanhToan);
        }
        private void btnTaiKhoanCuaToi_Click(object sender, EventArgs e)
        {
            MyForm.FrmThongTinNhanVien frmThongTin = new MyForm.FrmThongTinNhanVien(this, IDNhanVien, connectionString);
            ShowForm(frmThongTin);
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
                    form.Visible = true;
                }
                else
                {
                    //form.Hide();
                    form.Visible = false;
                }
            }
        }
        private void ShowForm(Form frm)
        {
            if (!CheckExistForm(frm.Name))
            {
                frm.MdiParent = this;
                grbChucNang.Controls.Add(frm);
            }
            ActiveChildForm(frm);
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

        private void FrmManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void sửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm.FrmSuDungDichVu frmThanhToan = new MyForm.FrmSuDungDichVu(IDNhanVien, connectionString);
            ShowForm(frmThanhToan);
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm.FrmSuDungNhapHang frmNhapHang = new MyForm.FrmSuDungNhapHang(IDNhanVien, connectionString);
            ShowForm(frmNhapHang);
        }

        private void thôngTinTàiKhoảnVàCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm.FrmThongTinNhanVien frmTTNV = new MyForm.FrmThongTinNhanVien(this, IDNhanVien, connectionString);
            ShowForm(frmTTNV);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
           {
                this.IDNhanVien = null;
                this.connectionString = null;
                DialogResult traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (traloi == DialogResult.OK)
                {
                    LoadLogin();
                }
            }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm.DoanhThu frmDT = new MyForm.DoanhThu(connectionString);
            ShowForm(frmDT);
        }

        private void quảnLýBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm.FrmBan frmB = new MyForm.FrmBan(this, connectionString);
            ShowForm(frmB);
        }

        private void quảnLýThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm.FrmThucDon frmTD = new MyForm.FrmThucDon(this, connectionString);
            ShowForm(frmTD);
        }

        private void quảnLýKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm.FrmKhoHang frmKH = new MyForm.FrmKhoHang(this, connectionString);
            ShowForm(frmKH);
        }

        private void quảnLýHóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm.FrmHoaDonNhapHang frmHDNH = new MyForm.FrmHoaDonNhapHang(this, connectionString);
            ShowForm(frmHDNH);
        }

        private void quảnLýHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm.FrmHoaDonBanHang frmHDBH = new MyForm.FrmHoaDonBanHang(this, connectionString);
            ShowForm(frmHDBH);
        }

        private void quảnLýTàiKhoảnVàNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm.FrmNhanVien frmNV = new MyForm.FrmNhanVien(this, IDNhanVien, connectionString);
            ShowForm(frmNV);
        }

        public bool getStatusMenuStrip()
        {
            return this.menuStrip1.Enabled;
        }
        public void setStatusMenuStrip(bool status)
        {
            this.menuStrip1.Enabled = status;
        }

        private void adminToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            bool Quyen = NVAc.getQuyen(IDNhanVien);
            if (!Quyen)
            {
                adminToolStripMenuItem.DropDown.Enabled = false;
            }
            else
            {
                adminToolStripMenuItem.DropDown.Enabled = true;
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Quyen = NVAc.getQuyen(IDNhanVien);
            if (!Quyen)
            {
                adminToolStripMenuItem.DropDown.Enabled = false;
                if (adminToolStripMenuItem.DropDown.Visible)
                {
                    MessageBox.Show("Bạn cần quyền admin để có thể truy cập chức năng này! Vui lòng liên hệ quản lý để cấp quyền");
                    adminToolStripMenuItem.DropDown.Visible = false;
                }
            }
            else
            {
                adminToolStripMenuItem.DropDown.Enabled = true;
            }
        }

        private void FrmManHinhChinh_Load(object sender, EventArgs e)
        {

        }

        private void grbChucNang_Enter(object sender, EventArgs e)
        {
         

        }
    }
}
