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
    public partial class FrmManHinhChinhAdmin : Form
    {
        MyForm.FrmLogin frmLG;
        DBaccess.NhanVienAccess NVAc;
        string IDNhanVien = null;
        string connectionString = null;
        bool thoat = true;
        public FrmManHinhChinhAdmin()
        {
            InitializeComponent();
            InitGUI();
        }
        public FrmManHinhChinhAdmin(MyForm.FrmLogin frmLG, string IDNhanVien, string connectionString)
        {
            this.frmLG = frmLG;
            this.IDNhanVien = IDNhanVien;
            this.connectionString = connectionString;
            InitializeComponent();
            InitGUI();
        }
        public void LoadLogin()
        {
            frmLG.Show();
            this.Close();
        }

        public void InitGUI()
        {
            NVAc = new DBaccess.NhanVienAccess(connectionString);
            grbCongCu.Enabled = true;
            MyForm.FrmThongTinNhanVien frmTTNV = new MyForm.FrmThongTinNhanVien(this, IDNhanVien, connectionString);
            ShowForm(frmTTNV, btnTaiKhoanCuaToi);
        }
        private void btnTaiKhoanCuaToi_Click(object sender, EventArgs e)
        {
            MyForm.FrmThongTinNhanVien frmTTNV = new MyForm.FrmThongTinNhanVien(this, IDNhanVien, connectionString);
            ShowForm(frmTTNV, btnTaiKhoanCuaToi);
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
        public void ShowForm(Form frm)
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
        public bool getStatusGroupCongCu()
        {
            return grbCongCu.Enabled;
        }
        public void setStatusGroupCongCu(bool Enable)
        {
            this.grbCongCu.Enabled = Enable;
        }
        private void FrmManHinhChinhAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thoat)
            {
                DialogResult traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.IDNhanVien = null;
            this.connectionString = null;
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                thoat = false;
                LoadLogin();
            }
        }

        private void btnQL_bàn_Click(object sender, EventArgs e)
        {
            MyForm.FrmBan frmB = new MyForm.FrmBan(this, connectionString);
            ShowForm(frmB, btnQL_bàn);
        }

        private void btnQL_thựcđơn_Click(object sender, EventArgs e)
        {
            MyForm.FrmThucDon frmTD = new MyForm.FrmThucDon(this, connectionString);
            ShowForm(frmTD, btnQL_thựcđơn);
        }

        private void btnQL_khohàng_Click(object sender, EventArgs e)
        {
            MyForm.FrmKhoHang frmKH = new MyForm.FrmKhoHang(this, connectionString);
            ShowForm(frmKH, btnQL_khohàng);
        }

        private void btnQL_hđnhập_Click(object sender, EventArgs e)
        {
            MyForm.FrmHoaDonNhapHang frmNH = new MyForm.FrmHoaDonNhapHang(this, connectionString);
            ShowForm(frmNH, btnQL_hđnhập);
        }

        private void btnQL_hđbán_Click(object sender, EventArgs e)
        {
            MyForm.FrmHoaDonBanHang frmBH = new MyForm.FrmHoaDonBanHang(this, connectionString);
            ShowForm(frmBH, btnQL_hđbán);
        }

        private void btnQL_tknv_Click(object sender, EventArgs e)
        {
            MyForm.FrmNhanVien frmNV = new MyForm.FrmNhanVien(this, IDNhanVien, connectionString);
            ShowForm(frmNV, btnQL_tknv);
        }

        private void btnQL_KhachHang_Click(object sender, EventArgs e)
        {
            MyForm.FrmThanhVien frmTV = new MyForm.FrmThanhVien(this, connectionString);
            ShowForm(frmTV, btnQL_KhachHang);
        }

        private void btnBCDoanhThu_Click(object sender, EventArgs e)
        {
            MyForm.BaoCao frmBC = new MyForm.BaoCao(this, connectionString);
            ShowForm(frmBC, btnBCDoanhThu);
        }
    }
}
