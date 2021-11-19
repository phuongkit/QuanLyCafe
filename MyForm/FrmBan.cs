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
    public partial class FrmBan : Form
    {
        FrmManHinhChinh frmMHC;
        DBaccess.BanAccess BAc;
        string connectionString;
        List<Trangthai> trangthai;
        bool Them;
        public FrmBan(FrmManHinhChinh frmMHC, string connectionString)
        {
            this.frmMHC = frmMHC;
            this.connectionString = connectionString;
            BAc = new DBaccess.BanAccess(connectionString);
            InitializeComponent();
        }

        private void dataBiding()
        {
            if (!frmMHC.getStatusGroupCongCu())
            {
                frmMHC.setStatusGroupCongCu(true);
            }
            trangthai = new List<Trangthai>()
            {
                new Trangthai(){Type=true,Name="Có người" },
                new Trangthai(){Type=false,Name="Trống"}
            };
            DGVBan.DataSource = BAc.Get();

            (DGVBan.Columns["TrangTha"] as DataGridViewComboBoxColumn).DataSource = trangthai;
            (DGVBan.Columns["TrangTha"] as DataGridViewComboBoxColumn).DisplayMember = "Name";
            (DGVBan.Columns["TrangTha"] as DataGridViewComboBoxColumn).ValueMember = "Type";

            cbbTrangThai.DataSource = trangthai;
            cbbTrangThai.DisplayMember = "Name";
            cbbTrangThai.ValueMember = "Type";

            txtID.DataBindings.Clear();
            txtTenBan.DataBindings.Clear();
            cbbTrangThai.DataBindings.Clear();
            txtID.DataBindings.Add("Text", DGVBan.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtTenBan.DataBindings.Add("Text", DGVBan.DataSource, "TenBan", true, DataSourceUpdateMode.Never);
            cbbTrangThai.DataBindings.Add("SelectedValue", DGVBan.DataSource, "TrangThai", true, DataSourceUpdateMode.Never);
            btnSave.Enabled = btnCancel.Enabled = false;
            btnCreate.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
            txtID.Enabled = txtTenBan.Enabled = cbbTrangThai.Enabled = false;
        }
        private void clear()
        {
            txtID.Text = txtTenBan.Text = "";
        }
        private void FormBan_Load(object sender, EventArgs e)
        {
            DGVBan.AutoGenerateColumns = false;
            dataBiding();
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
            txtID.Enabled = txtTenBan.Enabled = true;
            cbbTrangThai.DataBindings.Clear();
            clear();
            txtID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var b = new MyDatabase.Ban();
            if (Them)
            {
                try
                {
                    b.ID = txtID.Text.Trim();
                    b.TenBan = txtTenBan.Text.Trim();
                    if (bool.Parse(cbbTrangThai.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Bạn đang tạo trạng thái là trống! Không thể thay đổi");
                        dataBiding();
                        return;
                    }
                    BAc.Them(b);
                    MessageBox.Show("Đã thêm thành công");
                    dataBiding();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    b = BAc.getBan(txtID.Text.Trim());
                    b.TenBan = txtTenBan.Text.Trim();
                    bool newTrangThai = bool.Parse(cbbTrangThai.SelectedValue.ToString());
                    bool oldTrangThai = b.TrangThai;
                    bool IsBanTrong = BAc.IsBanTrong(b.ID);
                    if (newTrangThai != oldTrangThai)
                    {
                        if (newTrangThai == true && IsBanTrong == false)
                        {
                            MessageBox.Show("Trạng thái mới không thể được cập nhật! Chưa có hóa đơn bán hàng chưa thanh toán nào trên bàn này!");
                            dataBiding();
                            return;
                        }
                        else if (newTrangThai == false && IsBanTrong == true)
                        {
                            MessageBox.Show("Trạng thái mới không thể được cập nhật! Đã tồn tại hóa đơn bán hàng chưa thanh toán trên bàn này!");
                            dataBiding();
                            return;
                        }
                    }
                    b.TrangThai = newTrangThai;
                    BAc.Sua(b);
                    MessageBox.Show("Đã sửa thành công");
                    dataBiding();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            dataBiding();
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
            txtTenBan.Enabled = cbbTrangThai.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa bàn này không?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MyDatabase.Ban b = new MyDatabase.Ban();
                b = BAc.getBan(txtID.Text.Trim());
                bool IsBanTrong = BAc.IsBanTrong(b.ID);
                if (IsBanTrong == true)
                {
                    MessageBox.Show("Không thể xóa bàn này! Đã tồn tại hóa đơn bán hàng chưa thanh toán trên bàn này!");
                    dataBiding();
                    return;
                }
                BAc.Xoa(b);
            }
            MessageBox.Show("Đã xóa thành công");
            dataBiding();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public class Trangthai
        {
            public bool Type { get; set; }
            public string Name { get; set; }
        }

        private void FrmBan_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                DGVBan.AutoGenerateColumns = false;
                dataBiding();
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                txtID.Enabled = txtTenBan.Enabled = cbbTrangThai.Enabled = false;
            }
        }
    }
}
