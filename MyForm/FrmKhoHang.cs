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
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyCafe.MyForm
{
    public partial class FrmKhoHang : Form
    {
        FrmManHinhChinhAdmin frmMHC;
        int themFlag = 1;   //Flag = 0 sua, Flag = 1 them
        string connectionString;
        public FrmKhoHang(FrmManHinhChinhAdmin frmMHC, string connectionString)
        {
            this.frmMHC = frmMHC;
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private new void Load()
        {
            dgv_main.DataSource = null;
            dgv_main.Rows.Clear();
            dgv_main.Refresh();
            DBaccess.KhoHangAccess kh = new DBaccess.KhoHangAccess(connectionString);
            dgv_main.DataSource = kh.Get();
            dgv_main.Columns[0].Width = 125;
            dgv_main.Columns[0].HeaderText = "ID";
            dgv_main.Columns[1].Width = 250;
            dgv_main.Columns[1].HeaderText = "Tên nguyên liệu";
            dgv_main.Columns[2].Width = 180;
            dgv_main.Columns[2].HeaderText = "Đơn vị tính";
            dgv_main.Columns[3].Width = 200;
            dgv_main.Columns[3].HeaderText = "Số lượng";
            dgv_main.Columns[4].Width = 200;
            dgv_main.Columns[5].HeaderText = "Đơn giá";
            dgv_main.AutoGenerateColumns = true;
            try
            {
                txt_mathang.Text = dgv_main.Rows[0].Cells[1].Value.ToString();
                txt_soluong.Text = dgv_main.Rows[0].Cells[3].Value.ToString();
                txt_dongia.Text = dgv_main.Rows[0].Cells[4].Value.ToString();
                txt_donvi.Text = txt_donvi.Text = dgv_main.Rows[0].Cells[2].Value.ToString();
                txt_id.Text = dgv_main.Rows[0].Cells[0].Value.ToString();
            }
            catch
            {

            }
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled = true;
            btn_ok.Enabled = btn_huy.Enabled = false;
            txt_id.Enabled = txt_mathang.Enabled = txt_soluong.Enabled = txt_donvi.Enabled = txt_dongia.Enabled = false;
        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled = false;
            btn_ok.Enabled = btn_huy.Enabled = true;
            txt_id.Text = txt_mathang.Text = txt_soluong.Text = txt_donvi.Text = txt_dongia.Text = "";
            txt_id.Enabled = txt_mathang.Enabled = txt_soluong.Enabled = txt_donvi.Enabled = txt_dongia.Enabled = true;
            themFlag = 1;
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                MyDatabase.KhoHang kh = new MyDatabase.KhoHang
                {
                    ID = txt_id.Text,
                    Ten = txt_mathang.Text,
                    DonViTinh = txt_donvi.Text,
                    soLuong = int.Parse(txt_soluong.Text),
                    DonGia = float.Parse(txt_dongia.Text)
                };
                DBaccess.KhoHangAccess kha = new DBaccess.KhoHangAccess(connectionString);
                if (themFlag == 1)
                {
                    try
                    {
                        kha.Them(kh);
                        MessageBox.Show("Da them xong", "Them", MessageBoxButtons.OK);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Errors[0].Message);
                    }
                }
                else
                {
                    try
                    {
                        kha.Sua(kh);
                        MessageBox.Show("Da sua xong", "sua", MessageBoxButtons.OK);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Errors[0].Message);
                    }
                }
                //
                Load();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK);
            }
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ban co chac chan muon xoa?", "Xoa", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                try
                {
                    string ID = txt_id.Text;
                    DBaccess.KhoHangAccess kha = new DBaccess.KhoHangAccess(connectionString);
                    kha.Xoa(ID);
                    Load();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btn_sua_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled = false;
            btn_ok.Enabled = btn_huy.Enabled = true;
            txt_id.Enabled = txt_mathang.Enabled = txt_soluong.Enabled = txt_donvi.Enabled = txt_dongia.Enabled = true;
            themFlag = 0;
        }

        private void Btn_huy_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void Dgv_main_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txt_id.Text = dgv_main.Rows[index].Cells[0].Value.ToString();
            txt_mathang.Text = dgv_main.Rows[index].Cells[1].Value.ToString();
            txt_soluong.Text = dgv_main.Rows[index].Cells[3].Value.ToString();
            txt_dongia.Text = dgv_main.Rows[index].Cells[4].Value.ToString();
            txt_donvi.Text = txt_donvi.Text = dgv_main.Rows[index].Cells[2].Value.ToString();
        }

        private void FrmKhoHang_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Load();
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel|*.xls|Excel 2010|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportExcel(dgv_main, saveFileDialog.FileName);
                DialogResult traloi = MessageBox.Show("Đã xuất thành công, bạn có muốn gửi mail không?", " Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    Report.InputMesseageBox frmIMB = new Report.InputMesseageBox("Báo cáo danh sách thực đơn", "Báo cáo danh sách thực đơn ngày " + new DateTime(), saveFileDialog.FileName);
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
                obj.Cells[1, 1] = "Báo cáo danh sách nguyên liệu trong quán";
                obj.Cells[2, 1] = "Ngày tạo:" + DateTime.Now.ToShortDateString();

                for (int i = 0; i < dgv.ColumnCount - 1; i++)
                {
                    obj.Cells[3, i + 1] = dgv.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgv.RowCount; i++)
                {
                    obj.Cells[i + 4, 1] = dgv.Rows[i].Cells[0].Value.ToString();
                    obj.Cells[i + 4, 2] = dgv.Rows[i].Cells[1].Value.ToString();
                    obj.Cells[i + 4, 3] = dgv.Rows[i].Cells[2].Value.ToString();
                    obj.Cells[i + 4, 4] = dgv.Rows[i].Cells[3].Value.ToString();
                    obj.Cells[i + 4, 5] = dgv.Rows[i].Cells[4].Value.ToString() + " đồng";
                }


                obj.ActiveWorkbook.SaveCopyAs(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
