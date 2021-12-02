using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyCafe.MyForm
{
    public partial class FrmBan : Form
    {
        FrmManHinhChinh frmMHC;
        DBaccess.BanAccess BAc;
        string connectionString;
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
            if (!frmMHC.getStatusMenuStrip())
            {
                frmMHC.setStatusMenuStrip(true);
            }
            List<int> SoLuongs = new List<int>()
            {
                1, 2, 4
            };
            DGVBan.DataSource = BAc.Get();

            (DGVBan.Columns["MaxSoLuong"] as DataGridViewComboBoxColumn).DataSource = SoLuongs;

            cbbMaxSL.DataSource = SoLuongs;

            txtID.DataBindings.Clear();
            txtTenBan.DataBindings.Clear();
            nmSL.DataBindings.Clear();
            cbbMaxSL.DataBindings.Clear();
            txtID.DataBindings.Add("Text", DGVBan.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtTenBan.DataBindings.Add("Text", DGVBan.DataSource, "TenBan", true, DataSourceUpdateMode.Never);
            nmSL.DataBindings.Add("Value", DGVBan.DataSource, "SoLuong", true, DataSourceUpdateMode.Never);
            cbbMaxSL.DataBindings.Add("SelectedValue", DGVBan.DataSource, "MaxSoLuong", true, DataSourceUpdateMode.Never);
            btnSave.Enabled = btnCancel.Enabled = false;
            btnCreate.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
            txtID.Enabled = txtTenBan.Enabled = nmSL.Enabled = cbbMaxSL.Enabled = false;
        }
        private void clear()
        {
            txtID.Text = txtTenBan.Text = "";
            nmSL.Value=0;
        }
        private void FormBan_Load(object sender, EventArgs e)
        {
            DGVBan.AutoGenerateColumns = false;
            dataBiding();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Them = true;
            frmMHC.setStatusMenuStrip(false);
            btnCreate.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtID.Enabled = txtTenBan.Enabled = cbbMaxSL.Enabled = true;
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
                    b.SoLuong = 0;
                    b.MaxSoLuong = int.Parse(cbbMaxSL.SelectedValue.ToString());
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
                    string ID = txtID.Text.Trim();
                    b = BAc.getBan(ID);
                    b.TenBan = txtTenBan.Text.Trim();
                    int oldSL = b.SoLuong, newSL = int.Parse(nmSL.Value.ToString());
                    int oldMaxSL = b.MaxSoLuong, newMaxSL = int.Parse(cbbMaxSL.SelectedValue.ToString());
                    if (oldSL != newSL || oldMaxSL != newMaxSL)
                    {
                        int curSL = BAc.getSLHoaDonChuaTT(ID);
                        if (newSL > -1 && newSL == curSL && newSL <= newMaxSL)
                        {
                            b.SoLuong = newSL;
                            b.MaxSoLuong = newMaxSL;
                        }
                        else
                        {
                            MessageBox.Show("Số lượng mới không thể được cập nhật! Vui lòng thử lại sau!");
                            dataBiding();
                            return;
                        }
                    }
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
            frmMHC.setStatusMenuStrip(false);
            btnCreate.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtID.Enabled = false;
            txtTenBan.Enabled = cbbMaxSL.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa bàn này không?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MyDatabase.Ban b = new MyDatabase.Ban();
                b = BAc.getBan(txtID.Text.Trim());
                bool IsBanTrong = BAc.getSLHoaDonChuaTT(b.ID) == 0 ? true : false;
                if (!IsBanTrong)
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

        private void FrmBan_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                DGVBan.AutoGenerateColumns = false;
                dataBiding();
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                txtID.Enabled = txtTenBan.Enabled = cbbMaxSL.Enabled = false;
            }
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel|*.xls|Excel 2010|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportExcel(DGVBan, saveFileDialog.FileName);
                DialogResult traloi = MessageBox.Show("Đã xuất thành công, bạn có muốn gửi mail không?", " Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    Report.InputMesseageBox frmIMB = new Report.InputMesseageBox("Báo cáo danh sách bàn", "Báo cáo danh sách bàn ngày " + new DateTime(), saveFileDialog.FileName);
                    frmIMB.ShowDialog();
                }
            }
        }
        private void ExportExcel(DataGridView dgv, string fileName)
        {

            try
            {
                app obj = new app();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 35;

                obj.Cells[1, 1] = "Báo cáo danh sách bàn trong quán";
                obj.Cells[2, 1] = "Ngày tạo:" + DateTime.Now.ToShortDateString();

                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    obj.Cells[3, i + 1] = dgv.Columns[i].HeaderText;
                }


                for (int i = 0; i < dgv.RowCount; i++)
                {
                    obj.Cells[i + 4, 1] = dgv.Rows[i].Cells[0].Value.ToString();
                    obj.Cells[i + 4, 2] = dgv.Rows[i].Cells[1].Value.ToString();
                    string status = dgv.Rows[i].Cells[2].Value.ToString().ToUpper();
                    if(status.Equals("TRUE"))
                    {
                        obj.Cells[i + 4, 3] = "Có người";
                    }
                    else
                    {
                        obj.Cells[i + 4, 3] = "Trống";
                    }
                }


                obj.ActiveWorkbook.SaveCopyAs(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
