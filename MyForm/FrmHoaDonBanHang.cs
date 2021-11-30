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
    public partial class FrmHoaDonBanHang : Form
    {
        FrmManHinhChinh frmMHC;
        DBaccess.HoaDonBanHangAccess HDBHAc;
        DBaccess.ChiTietHoaDonBanHangAccess CTHDBHAc;
        string connectionString;
        List<ThanhToan> listthanhtoan;
        List<MyDatabase.NhanVien> listNhanVien;
        List<MyDatabase.Ban> listBan;
        List<MyDatabase.ThucDon> listThucDon;
        bool Them, ThemCT;
        public FrmHoaDonBanHang(FrmManHinhChinh frmMHC, string connectionString)
        {
            this.frmMHC = frmMHC;
            this.connectionString = connectionString;
            HDBHAc = new DBaccess.HoaDonBanHangAccess(connectionString);
            CTHDBHAc = new DBaccess.ChiTietHoaDonBanHangAccess(connectionString);
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
            txtIDHoaDon.Enabled = cbbNhanVien.Enabled = cbbBan.Enabled = cbbTinhTrang.Enabled = dtNgayTao.Enabled = false;
            txtCTIDHoaDon.Enabled = cbbCTThucDon.Enabled = nmCTSoLuong.Enabled = false;
            btnChiTietThem.Enabled = btnChiTietSua.Enabled = btnChiTietXoa.Enabled = btnChiTietLuu.Enabled = btnChiTietBoQua.Enabled = false;
        }
        public void DataBind()
        {
            DBaccess.BanAccess BAc = new DBaccess.BanAccess(connectionString);
            DBaccess.NhanVienAccess NVAc = new DBaccess.NhanVienAccess(connectionString);
            listBan = BAc.Get();
            listNhanVien = NVAc.Get();
            listthanhtoan = new List<ThanhToan>()
            {
                new ThanhToan(){Type=true,Name="Đã thanh toán" },
                new ThanhToan(){Type=false,Name="chưa thanh toán"}
            };

            dgvHoaDon.DataSource = HDBHAc.Get();
            dgvHoaDon.Columns["Ban"].Visible = false;
            dgvHoaDon.Columns["NhanVien"].Visible = false;
            dgvHoaDon.Columns["ChiTietHoaDonBanHangs"].Visible = false;

            (dgvHoaDon.Columns["IDnhanVien"] as DataGridViewComboBoxColumn).DataSource = listNhanVien;
            (dgvHoaDon.Columns["IDnhanVien"] as DataGridViewComboBoxColumn).DisplayMember = "HoTen";
            (dgvHoaDon.Columns["IDnhanVien"] as DataGridViewComboBoxColumn).ValueMember = "ID";

            (dgvHoaDon.Columns["IDban"] as DataGridViewComboBoxColumn).DataSource = listBan;
            (dgvHoaDon.Columns["IDban"] as DataGridViewComboBoxColumn).DisplayMember = "TenBan";
            (dgvHoaDon.Columns["IDban"] as DataGridViewComboBoxColumn).ValueMember = "ID";

            (dgvHoaDon.Columns["DaThanhToan"] as DataGridViewComboBoxColumn).DataSource = listthanhtoan;
            (dgvHoaDon.Columns["DaThanhToan"] as DataGridViewComboBoxColumn).DisplayMember = "Name";
            (dgvHoaDon.Columns["DaThanhToan"] as DataGridViewComboBoxColumn).ValueMember = "Type";

            cbbNhanVien.DataSource = listNhanVien;
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "ID";

            cbbBan.DataSource = listBan;
            cbbBan.DisplayMember = "TenBan";
            cbbBan.ValueMember = "ID";

            cbbTinhTrang.DataSource = listthanhtoan;
            cbbTinhTrang.DisplayMember = "Name";
            cbbTinhTrang.ValueMember = "Type";

            txtIDHoaDon.DataBindings.Clear();
            cbbNhanVien.DataBindings.Clear();
            cbbBan.DataBindings.Clear();
            dtNgayTao.DataBindings.Clear(); 
            cbbTinhTrang.DataBindings.Clear();
            txtIDHoaDon.DataBindings.Add("Text", dgvHoaDon.DataSource, "ID", true, DataSourceUpdateMode.Never);
            cbbNhanVien.DataBindings.Add("SelectedValue", dgvHoaDon.DataSource, "IDnhanVien", true, DataSourceUpdateMode.Never);
            cbbBan.DataBindings.Add("SelectedValue", dgvHoaDon.DataSource, "IDban", true, DataSourceUpdateMode.Never);
            cbbTinhTrang.DataBindings.Add("SelectedValue", dgvHoaDon.DataSource, "DaThanhToan", true, DataSourceUpdateMode.Never);
            dtNgayTao.DataBindings.Add("Value", dgvHoaDon.DataSource, "Ngaytao", true, DataSourceUpdateMode.Never);
            dgvChiTietHoaDon.DataSource = new List<MyDatabase.ChiTietHoaDonBanHang>();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmMHC.setStatusMenuStrip(false);
            Them = true;
            txtIDHoaDon.Enabled = cbbNhanVien.Enabled = cbbBan.Enabled = cbbTinhTrang.Enabled = dtNgayTao.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnBoQua.Enabled = true;
            txtIDHoaDon.Text = HDBHAc.getIDHoaDonBHMoi();

            txtCTIDHoaDon.Enabled = cbbCTThucDon.Enabled = nmCTSoLuong.Enabled = false;
            btnChiTietThem.Enabled = btnChiTietSua.Enabled = btnChiTietXoa.Enabled = btnChiTietLuu.Enabled = btnChiTietBoQua.Enabled = false;
            dgvChiTietHoaDon.DataSource = new List<MyDatabase.ChiTietHoaDonBanHang>();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmMHC.setStatusMenuStrip(false);
            Them = false;
            txtIDHoaDon.Enabled = cbbNhanVien.Enabled = cbbBan.Enabled = cbbTinhTrang.Enabled = dtNgayTao.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnBoQua.Enabled = true;
            txtIDHoaDon.Enabled = false;

            txtCTIDHoaDon.Enabled = cbbCTThucDon.Enabled = nmCTSoLuong.Enabled = false;
            btnChiTietThem.Enabled = btnChiTietSua.Enabled = btnChiTietXoa.Enabled = btnChiTietLuu.Enabled = btnChiTietBoQua.Enabled = false;
            dgvChiTietHoaDon.DataSource = new List<MyDatabase.ChiTietHoaDonBanHang>();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                MyDatabase.HoaDonBanHang hdbh = new MyDatabase.HoaDonBanHang();
                hdbh = HDBHAc.getHoaDonBanHang(txtIDHoaDon.Text);
                DialogResult traloi = MessageBox.Show("Bọn có muốn xóa hóa đơn này và các thông tin liên quan?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (traloi == DialogResult.OK)
                {
                    HDBHAc.Xoa(hdbh);
                    MessageBox.Show("Đã xóa thành công!");
                    InitGUI();
                    DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            txtCTIDHoaDon.Enabled = cbbCTThucDon.Enabled = nmCTSoLuong.Enabled = false;
            btnChiTietThem.Enabled = btnChiTietSua.Enabled = btnChiTietXoa.Enabled = btnChiTietLuu.Enabled = btnChiTietBoQua.Enabled = false;
            dgvChiTietHoaDon.DataSource = new List<MyDatabase.ChiTietHoaDonBanHang>();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ID = txtIDHoaDon.Text;
            try
            {
                MyDatabase.HoaDonBanHang hdbh = new MyDatabase.HoaDonBanHang();
                hdbh = HDBHAc.getHoaDonBanHang(ID);
                if (Them)
                {
                    if (hdbh == null)
                    {
                        MyDatabase.HoaDonBanHang hd = new MyDatabase.HoaDonBanHang();
                        hd.ID = txtIDHoaDon.Text;
                        hd.IDban = cbbBan.SelectedValue.ToString();
                        hd.IDnhanVien = cbbNhanVien.SelectedValue.ToString();
                        hd.Ngaytao = dtNgayTao.Value;
                        hd.DaThanhToan = bool.Parse(cbbTinhTrang.SelectedValue.ToString());
                        HDBHAc.Them(hd);
                        MessageBox.Show("Đã thêm thành công!");
                        InitGUI();
                        DataBind();
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
                    hdbh.IDban = cbbBan.SelectedValue.ToString();
                    hdbh.IDnhanVien = cbbNhanVien.SelectedValue.ToString();
                    hdbh.Ngaytao = dtNgayTao.Value;
                    hdbh.DaThanhToan = bool.Parse(cbbTinhTrang.SelectedValue.ToString());
                    HDBHAc.Sua(hdbh);
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
            DBaccess.ThucDonAccess TDAc = new DBaccess.ThucDonAccess(connectionString);
            listThucDon = TDAc.Get();
            string ID = txtIDHoaDon.Text;
            dgvChiTietHoaDon.DataSource = HDBHAc.getCTHDBH(ID);
            dgvChiTietHoaDon.Columns["HoaDonBanHang"].Visible = false;
            dgvChiTietHoaDon.Columns["ThucDon"].Visible = false;

            (dgvChiTietHoaDon.Columns["IDthucDon"] as DataGridViewComboBoxColumn).DataSource = listThucDon;
            (dgvChiTietHoaDon.Columns["IDthucDon"] as DataGridViewComboBoxColumn).DisplayMember = "Ten";
            (dgvChiTietHoaDon.Columns["IDthucDon"] as DataGridViewComboBoxColumn).ValueMember = "ID";

            cbbCTThucDon.DataSource = listThucDon;
            cbbCTThucDon.DisplayMember = "Ten";
            cbbCTThucDon.ValueMember = "ID";

            txtCTIDHoaDon.DataBindings.Clear();
            cbbCTThucDon.DataBindings.Clear();
            nmCTSoLuong.DataBindings.Clear();

            txtCTIDHoaDon.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "IDhoaDonBH", true, DataSourceUpdateMode.Never);
            cbbCTThucDon.DataBindings.Add("SelectedValue", dgvChiTietHoaDon.DataSource, "IDthucDon", true, DataSourceUpdateMode.Never);
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
            cbbCTThucDon.Enabled = nmCTSoLuong.Enabled = true;
        }

        private void btnChiTietSua_Click(object sender, EventArgs e)
        {
            frmMHC.setStatusMenuStrip(false);
            ThemCT = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnBoQua.Enabled = false;
            btnChiTietThem.Enabled = btnChiTietSua.Enabled = btnChiTietXoa.Enabled = false;
            btnChiTietLuu.Enabled = btnChiTietBoQua.Enabled = true;
            txtCTIDHoaDon.Enabled = cbbCTThucDon.Enabled = false;
            nmCTSoLuong.Enabled = true;
        }

        private void btnChiTietXoa_Click(object sender, EventArgs e)
        {
            try
            {
                MyDatabase.ChiTietHoaDonBanHang cthdbh = new MyDatabase.ChiTietHoaDonBanHang();
                cthdbh = CTHDBHAc.getChiTietHoaDonBanHang(txtCTIDHoaDon.Text, cbbCTThucDon.SelectedValue.ToString());
                DialogResult traloi = MessageBox.Show("Bọn có muốn xóa thực đơn này khỏi hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (traloi == DialogResult.OK)
                {
                    CTHDBHAc.Xoa(cthdbh);
                    MessageBox.Show("Đã xóa thành công!");
                    InitGUI();
                    DataBind();
                }
                InitGUI();
                DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnChiTietLuu_Click(object sender, EventArgs e)
        {
            string IDHoaDon = txtCTIDHoaDon.Text;
            string IDThucDon = cbbCTThucDon.SelectedValue.ToString();
            int soLuong = int.Parse(nmCTSoLuong.Value.ToString());
            MyDatabase.ChiTietHoaDonBanHang cthdbh = new MyDatabase.ChiTietHoaDonBanHang();
            cthdbh = CTHDBHAc.getChiTietHoaDonBanHang(IDHoaDon, IDThucDon);
            if (ThemCT)
            {
                if (cthdbh == null)
                {
                    try
                    {
                        MyDatabase.ChiTietHoaDonBanHang cthd = new MyDatabase.ChiTietHoaDonBanHang();
                        cthd.IDhoaDonBH = IDHoaDon;
                        cthd.IDthucDon = IDThucDon;
                        cthd.soLuong = soLuong;
                        CTHDBHAc.Them(cthd);
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
                    MessageBox.Show("Hóa đơn với ID = " + IDHoaDon + " đã có thực đơn với ID =" + IDThucDon + "! Vui lòng thử lại với ID thực đơn khác!");
                    InitGUI();
                    DataBind();
                }
            }
            else
            {
                try
                {
                    cthdbh.soLuong = soLuong;
                    CTHDBHAc.Sua(cthdbh);
                    MessageBox.Show("Đã cập nhật thành công!");
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

        private void btnChiTietBoQua_Click(object sender, EventArgs e)
        {
            InitGUI();
            DataBind();
        }

        private void FrmHoaDonBanHang_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                InitGUI();
                DataBind();
            }
        }

        private void btnExportExcell_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel|*.xls|Excel 2010|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportExcel(dgvHoaDon, saveFileDialog.FileName);
                DialogResult traloi = MessageBox.Show("Đã xuất thành công, bạn có muốn gửi mail không?", " Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    Report.InputMesseageBox frmIMB = new Report.InputMesseageBox("Báo cáo danh sách hóa đơn bán hàng", "Báo cáo danh sách hóa đơn bán hàng ngày " + new DateTime(), saveFileDialog.FileName);
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
                obj.Cells[1, 1] = "Báo cáo danh sách hóa đơn bán hàng trong quán";
                obj.Cells[2, 1] = "Ngày tạo:" + DateTime.Now.ToShortDateString();

                for (int i = 0; i < dgv.ColumnCount - 3; i++)
                {
                    obj.Cells[3, i + 1] = dgv.Columns[i].HeaderText;
                }


                for (int i = 0; i < dgv.RowCount; i++)
                {
                    obj.Cells[i + 4, 1] = dgv.Rows[i].Cells[0].Value.ToString();
                    obj.Cells[i + 4, 2] = dgv.Rows[i].Cells[1].EditedFormattedValue.ToString();
                    obj.Cells[i + 4, 3] = dgv.Rows[i].Cells[2].EditedFormattedValue.ToString();
                    obj.Cells[i + 4, 4] = dgv.Rows[i].Cells[3].Value.ToString();
                    string status = dgv.Rows[i].Cells[4].Value.ToString().ToUpper();
                    if (status.Equals("TRUE"))
                    {
                        obj.Cells[i + 4, 5] = "Đã thanh toán";
                    }
                    else
                    {
                        obj.Cells[i + 4, 5] = "Chưa thanh toán";
                    }
                }


                obj.ActiveWorkbook.SaveCopyAs(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public class ThanhToan
        {
            public bool Type { get; set; }
            public string Name { get; set; }
        }
    }
}
