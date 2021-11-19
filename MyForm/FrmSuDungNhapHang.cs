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
    public partial class FrmSuDungNhapHang : Form
    {
        DBaccess.HoaDonNhapHangAccess HDNHAc;
        DBaccess.ChiTietHoaDonNhapHangAccess CTHDNHAc;
        DBaccess.KhoHangAccess KHAc;
        string IDNhanVien;
        string connectionString;
        int indexRowKH = -1;
        int indexRowCTHD = -1;
        public FrmSuDungNhapHang(string IDNhanVien, string connectionString)
        {
            this.connectionString = connectionString;
            this.IDNhanVien = IDNhanVien;
            HDNHAc = new DBaccess.HoaDonNhapHangAccess(connectionString);
            CTHDNHAc = new DBaccess.ChiTietHoaDonNhapHangAccess(connectionString);
            KHAc = new DBaccess.KhoHangAccess(connectionString);
            InitializeComponent();
        }
        public void InitGUI()
        {
            txtNhanVien.Text = IDNhanVien;
            txtSoHD.Text = HDNHAc.getIDHoaDonNHMoi();
            dtNgayTao.Value = DateTime.Now;
            DataBind();
        }
        public void DataBind()
        {
            dgvKhoHang.DataSource = KHAc.Get();
            if (dgvChiTietNhapHang.Columns.Count == 6)
            {
                dgvChiTietNhapHang.Columns[0].HeaderText = "ID";
                dgvChiTietNhapHang.Columns[0].Width = 50;
                dgvChiTietNhapHang.Columns[1].HeaderText = "Tên nguyên liệu"; 
                dgvChiTietNhapHang.Columns[1].Width = 150;
                dgvChiTietNhapHang.Columns[2].HeaderText = "SL"; 
                dgvChiTietNhapHang.Columns[2].Width = 70;
                dgvChiTietNhapHang.Columns[3].HeaderText = "Đơn giá"; 
                dgvChiTietNhapHang.Columns[3].Width = 80;
                dgvChiTietNhapHang.Columns[4].HeaderText = "Thành tiền";
                dgvChiTietNhapHang.Columns[4].Width = 80;
                dgvChiTietNhapHang.Columns[5].HeaderText = "ĐVT"; 
                dgvChiTietNhapHang.Columns[5].Width = 90;
            }
            dgvKhoHang.ClearSelection();
            dgvChiTietNhapHang.ClearSelection();
            indexRowCTHD = -1;
            indexRowKH = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int index = indexRowKH != -1 ? indexRowKH : -1;
            index = index != -1 ? index : indexRowCTHD;
            if (index != -1)
            {
                string soHD = txtSoHD.Text;
                int soLuong = int.Parse(nmSoLuong.Value.ToString());
                string IDKhoHang;
                if(index == indexRowCTHD)
                {
                    IDKhoHang = dgvChiTietNhapHang.Rows[index].Cells[0].Value.ToString();
                }
                else
                {
                    IDKhoHang = dgvKhoHang.Rows[index].Cells[0].Value.ToString();
                }
                if (HDNHAc.getHoaDonNhapHang(soHD) == null)
                {
                    try
                    {
                        HDNHAc.Them(new MyDatabase.HoaDonNhapHang() { ID = soHD, IDnhanVien = IDNhanVien, NgayTao = dtNgayTao.Value });
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                MyDatabase.ChiTietHoaDonNhapHang chitiet = CTHDNHAc.getChiTietHoaDonNhapHang(soHD, IDKhoHang);
                if (chitiet == null)
                {
                    try { 
                        CTHDNHAc.Them(new MyDatabase.ChiTietHoaDonNhapHang() { IDhoaDonNH = soHD, IDhang = IDKhoHang, soLuong = soLuong });
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Errors[0].Message);
                    }
                }
                else
                {
                    try { 
                        CTHDNHAc.Sua(new MyDatabase.ChiTietHoaDonNhapHang() { IDhoaDonNH = soHD, IDhang = IDKhoHang, soLuong = soLuong + chitiet.soLuong });
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Errors[0].Message);
                    }
                }
                dgvChiTietNhapHang.DataSource = HDNHAc.getChiTietHoaDonNhapHang(soHD);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần thêm!");
            }
            if (index == indexRowKH)
            {
                dgvChiTietNhapHang.ClearSelection();
            }
            else
            {
                dgvKhoHang.ClearSelection();
                dgvChiTietNhapHang.Rows[indexRowCTHD].Selected = true;
            }
            DataBind();
            MyDatabase.f_TinhTienHoaDonNH_Result tienHD = HDNHAc.getTienHoaDonNH(txtSoHD.Text);
            txtThanhTien.Text = tienHD != null ? tienHD.TongGia.ToString() : "0";
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            int index = indexRowKH != -1 ? indexRowKH : -1;
            index = index != -1 ? index : indexRowCTHD;
            if (index != -1)
            {
                string soHD = txtSoHD.Text;
                int soLuong = int.Parse(nmSoLuong.Value.ToString());
                string IDKhoHang;
                if (index == indexRowCTHD)
                {
                    IDKhoHang = dgvChiTietNhapHang.Rows[index].Cells[0].Value.ToString();
                }
                else
                {
                    IDKhoHang = dgvKhoHang.Rows[index].Cells[0].Value.ToString();
                }
                MyDatabase.ChiTietHoaDonNhapHang chitiet = CTHDNHAc.getChiTietHoaDonNhapHang(soHD, IDKhoHang);
                if (chitiet != null)
                {
                    soLuong = chitiet.soLuong - soLuong;
                    if (soLuong > 0)
                    {
                        try { 
                            CTHDNHAc.Sua(new MyDatabase.ChiTietHoaDonNhapHang() { IDhoaDonNH = soHD, IDhang = IDKhoHang, soLuong = soLuong });
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Errors[0].Message);
                        }
                    }
                    else if (soLuong == 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn xóa nguyên liêu này ra khỏi hóa đơn nhập hàng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            try
                            {
                                CTHDNHAc.Xoa(chitiet);
                                MessageBox.Show("Đã xóa thành công");
                                if (index == indexRowCTHD)
                                {
                                    index = -1;
                                    indexRowCTHD = -1;
                                }
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Errors[0].Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trong hóa đơn bán hàng, thực đơn này không chứa tới số lượng " + (chitiet.soLuong - soLuong).ToString());
                    }
                    dgvChiTietNhapHang.DataSource = HDNHAc.getChiTietHoaDonNhapHang(soHD);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nguyên liệu cần giảm!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần giảm!");
            }
            if (index == -1)
            {
                dgvChiTietNhapHang.ClearSelection();
                dgvKhoHang.ClearSelection();
                indexRowCTHD = -1;
                indexRowKH = -1;
            }
            else if (index == indexRowKH)
            {
                dgvChiTietNhapHang.ClearSelection();
            }
            else
            {
                dgvKhoHang.ClearSelection();
                dgvChiTietNhapHang.Rows[indexRowCTHD].Selected = true;
            }
            MyDatabase.f_TinhTienHoaDonNH_Result tienHD = HDNHAc.getTienHoaDonNH(txtSoHD.Text);
            txtThanhTien.Text = tienHD != null ? tienHD.TongGia.ToString() : "0";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = indexRowCTHD != -1 ? indexRowCTHD : -1;
            if (index != -1)
            {
                string soHD = txtSoHD.Text;
                string IDthucDon = dgvChiTietNhapHang.Rows[index].Cells["CTID"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thưc đơn này ra khỏi hóa đơn bán hàng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    try { 
                        CTHDNHAc.Xoa(soHD, IDthucDon);
                        MessageBox.Show("Đã xóa thành công");
                        dgvChiTietNhapHang.DataSource = HDNHAc.getChiTietHoaDonNhapHang(soHD);
                        indexRowCTHD = -1;
                        dgvChiTietNhapHang.ClearSelection();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Errors[0].Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần xóa!");
            }
            MyDatabase.f_TinhTienHoaDonNH_Result tienHD = HDNHAc.getTienHoaDonNH(txtSoHD.Text);
            txtThanhTien.Text = tienHD != null ? tienHD.TongGia.ToString() : "0";
        }

        private void dgvKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvChiTietNhapHang.ClearSelection();
            indexRowKH = e.RowIndex;
            indexRowCTHD = -1;
        }

        private void dgvChiTietNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvKhoHang.ClearSelection();
            indexRowKH = -1;
            indexRowCTHD = e.RowIndex;
        }

        private void FrmSuDungNhapHang_Load(object sender, EventArgs e)
        {
            dgvKhoHang.ClearSelection();
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            dgvChiTietNhapHang.DataSource = new MyDatabase.f_ChiTietHoaDonNhapHang_Result();
            InitGUI();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            MyDatabase.HoaDonNhapHang hd = HDNHAc.getHoaDonNhapHang(txtSoHD.Text);
            if (hd != null)
            {
                try
                {
                    HDNHAc.Xoa(hd);
                    MessageBox.Show("Đã hủy hóa đơn thành công");
                    dgvChiTietNhapHang.DataSource = new MyDatabase.f_ChiTietHoaDonNhapHang_Result();
                    InitGUI();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Vui lòng thử lại sau!");
            }
        }

        private void dgvChiTietNhapHang_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                InitGUI();
            }
        }
    }
}
