using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCafe.MyForm
{
    public partial class FrmSuDungDichVu : Form
    {
        DBaccess.ChiTietHoaDonBanHangAccess CTHDBHAc;
        DBaccess.HoaDonBanHangAccess HDBHAc;
        DBaccess.LoaiThucDonAccess LTDAc;
        DBaccess.ThanhVienAccess TVAc;
        DBaccess.BanAccess BAc;
        ImageList imgsBan;
        string IDNhanVien;
        string connectionString;
        int indexRowTD = -1;
        int indexRowCTTD = -1;
        List<MyDatabase.ThanhVien> thanhViens;
        public FrmSuDungDichVu(string IDNhanVien, string connectionString)
        {
            this.connectionString = connectionString;
            CTHDBHAc = new DBaccess.ChiTietHoaDonBanHangAccess(connectionString);
            HDBHAc = new DBaccess.HoaDonBanHangAccess(connectionString);
            LTDAc = new DBaccess.LoaiThucDonAccess(connectionString);
            TVAc = new DBaccess.ThanhVienAccess(connectionString);
            BAc = new DBaccess.BanAccess(connectionString);
            this.IDNhanVien = IDNhanVien;
            InitializeComponent();
        }
        //Khởi tạo dữ liệu ban đầu
        #region initial data
        public void DataBind()
        {
            LoadTreeView();
            LoadListViewBan();
            dtNgay.Value = DateTime.Now;
            txtNhanVien.Text = IDNhanVien;
            thanhViens = TVAc.Get();
            cbbKhachHang.DataSource = thanhViens;
            cbbKhachHang.DisplayMember = "HoTen";
            cbbKhachHang.ValueMember = "ID";
            dgvChiTietHoaDon.DataSource = HDBHAc.getChiTietHoaDonBanHang("-1");
            dgvChiTietHoaDon.ClearSelection();
            dgvThucDon.ClearSelection();
            dgvKhachHang.ClearSelection();
        }
        public void LoadTreeView()
        {
            try
            {
                trvLoaiThucDon.Nodes.Clear();
                List<MyDatabase.LoaiThucDon> ltd = LTDAc.Get();
                for (int i = 0; i < LTDAc.Get().Count; i++)
                {
                    TreeNode node = new TreeNode();
                    node.Text = ltd[i].TenloaiThucDon;
                    node.Name = ltd[i].ID;
                    if (i == 0)
                    {
                        node.BackColor = Color.LightGray;
                    }
                    trvLoaiThucDon.Nodes.Add(node);
                }
                trvLoaiThucDon.SelectedNode = trvLoaiThucDon.GetNodeAt(0, 0);
                dgvThucDon.DataSource = LTDAc.getCTLoaiThucDon("00");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadListViewBan()
        {
            try
            {
                lsvBan.Items.Clear();
                List<MyDatabase.Ban> bans = BAc.Get();
                string imgPath = Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "Resources";
                imgsBan = new ImageList() { ImageSize = new Size(64, 64) };
                imgsBan.Images.Add(new Bitmap(imgPath + "\\coffee.png"));
                imgsBan.Images.Add(MakeGrayscale(new Bitmap(imgPath + "\\coffee.png")));
                lsvBan.LargeImageList = imgsBan;
                for (int i = 0; i < bans.Count; i++)
                {
                    ListViewItem lsvItem = new ListViewItem();
                    int SL = bans.ToList()[i].SoLuong;
                    int maxSL = bans.ToList()[i].MaxSoLuong;
                    lsvItem.Text = bans.ToList()[i].TenBan + " " + SL.ToString() + "/" + maxSL.ToString();
                    lsvItem.Name = bans.ToList()[i].ID;
                    lsvItem.ImageIndex = bans.ToList()[i].SoLuong == maxSL ? 1 : 0;
                    lsvBan.Items.Add(lsvItem);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Bitmap MakeGrayscale(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            Graphics g = Graphics.FromImage(newBitmap);


            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
           new float[] {.3f, .3f, .3f, 0, 0},
           new float[] {.59f, .59f, .59f, 0, 0},
           new float[] {.11f, .11f, .11f, 0, 0},
           new float[] {0, 0, 0, 1, 0},
           new float[] {0, 0, 0, 0, 1}
               });

            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            g.Dispose();
            return newBitmap;
        }
        #endregion

        //Xử lí sự kiện
        #region event

        private void trvLoaiThucDon_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                foreach (TreeNode node in trvLoaiThucDon.Nodes)
                {
                    node.BackColor = Color.White;
                }
                e.Node.BackColor = Color.LightGray;
                dgvThucDon.DataSource = LTDAc.getCTLoaiThucDon(e.Node.Name.ToString());
                dgvThucDon.ClearSelection();
                indexRowTD = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lsvBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView lsv = sender as ListView;
                if (lsv.SelectedItems.Count > 0)
                {
                    ListViewItem lsvItem = lsv.SelectedItems[0];
                    List<MyDatabase.Ban> bans = BAc.Get();
                    for (int i = 0; i < lsvBan.Items.Count; i++)
                    {
                        int SL = bans[i].SoLuong;
                        int maxSL = bans[i].MaxSoLuong;
                        lsvBan.Items[i].ImageIndex = bans[i].SoLuong == maxSL ? 1 : 0;
                        lsvBan.Items[i].Text = bans[i].TenBan + " " + SL.ToString() + "/" + maxSL.ToString();
                    }
                    txtBan.Text = lsvItem.Name;

                    dgvKhachHang.DataSource = BAc.getThanhVienTheoBan(lsvBan.SelectedItems[0].Name);
                    dgvKhachHang.ClearSelection();

                    dgvChiTietHoaDon.DataSource = HDBHAc.getChiTietHoaDonBanHang("-1");

                    btnHuy.Text = "Tạo Hóa Đơn";
                    btnHuy.Image = global::QuanLyCafe.Properties.Resources.edit_add;
                    txtSoHD.Text = HDBHAc.getIDHoaDonBHMoi();
                    btnTim.Enabled = txtIDKhachHang.Enabled = cbbKhachHang.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtBan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bàn để đặt hóa đơn!");
                return;
            }
            int index = indexRowTD != -1 ? indexRowTD : indexRowCTTD;
            if (index > -1)
            {
                int soLuong = int.Parse(nmSoLuong.Value.ToString());
                string soHD = txtSoHD.Text;
                string IDThanhVien = cbbKhachHang.SelectedValue.ToString();
                string IDthucDon;
                if (index == indexRowTD)
                {
                    IDthucDon = dgvThucDon.Rows[index].Cells["ID"].Value.ToString();
                }
                else
                {
                    IDthucDon = dgvChiTietHoaDon.Rows[index].Cells["IDThucDon"].Value.ToString();
                }
                if (HDBHAc.getHoaDonBanHang(soHD) == null)
                {
                    int SLHD = BAc.getSLHoaDonChuaTT(lsvBan.SelectedItems[0].Name), MaxSL = BAc.getBan(lsvBan.SelectedItems[0].Name).MaxSoLuong;
                    if (SLHD == MaxSL)
                    {
                        MessageBox.Show("Bàn này đã đủ người, không thể tạo thêm!");
                        return;
                    }
                    try
                    {
                        HDBHAc.Them(new MyDatabase.HoaDonBanHang() { ID = soHD, IDnhanVien = IDNhanVien, IDthanhVien = IDThanhVien, IDban = lsvBan.SelectedItems[0].Name, Ngaytao = dtNgay.Value });
                        dgvKhachHang.DataSource = BAc.getThanhVienTheoBan(lsvBan.SelectedItems[0].Name);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                MyDatabase.ChiTietHoaDonBanHang chitiet = CTHDBHAc.getChiTietHoaDonBanHang(soHD, IDthucDon);
                if (chitiet == null)
                {
                    try { 
                        CTHDBHAc.Them(new MyDatabase.ChiTietHoaDonBanHang() { IDhoaDonBH = soHD, IDthucDon = IDthucDon, soLuong = soLuong });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                else
                {
                    try { 
                    CTHDBHAc.Sua(new MyDatabase.ChiTietHoaDonBanHang() { IDhoaDonBH = soHD, IDthucDon = IDthucDon, soLuong = soLuong + chitiet.soLuong });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                dgvChiTietHoaDon.DataSource = HDBHAc.getChiTietHoaDonBanHang(soHD);
                if (dgvChiTietHoaDon.Columns.Count == 6)
                {
                    dgvChiTietHoaDon.Columns[0].Width = 30;
                    dgvChiTietHoaDon.Columns[1].Width = 115;
                    dgvChiTietHoaDon.Columns[2].Width = 40;
                    dgvChiTietHoaDon.Columns[3].Width = 50;
                    dgvChiTietHoaDon.Columns[4].Width = 50;
                    dgvChiTietHoaDon.Columns[5].Width = 40;
                    dgvChiTietHoaDon.Columns[0].HeaderText = "ID";
                    dgvChiTietHoaDon.Columns[1].HeaderText = "Mặt hàng";
                    dgvChiTietHoaDon.Columns[2].HeaderText = "SL";
                    dgvChiTietHoaDon.Columns[3].HeaderText = "Đơn Giá";
                    dgvChiTietHoaDon.Columns[4].HeaderText = "Thành Tiền";
                    dgvChiTietHoaDon.Columns[5].HeaderText = "ĐVT";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thực đơn và số lượng cần thêm vào!");
            }
            if (index == indexRowTD)
            {
                dgvChiTietHoaDon.ClearSelection();
            }
            else
            {
                dgvThucDon.ClearSelection();
                dgvChiTietHoaDon.Rows[indexRowCTTD].Selected = true;
            }
            MyDatabase.f_TinhTienHoaDonBH_Result tienHD = HDBHAc.getTienHoaDonBH(txtSoHD.Text);
            txtThanhTien.Text = tienHD != null ? tienHD.TongGia.ToString() : "0";

        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            int index = indexRowTD != -1 ? indexRowTD : indexRowCTTD;
            if (index > -1)
            {
                int soLuong = int.Parse(nmSoLuong.Value.ToString());
                string soHD = txtSoHD.Text;
                string IDthucDon;
                if (index == indexRowTD)
                {
                    IDthucDon = dgvThucDon.Rows[index].Cells["ID"].Value.ToString();
                }
                else
                {
                    IDthucDon = dgvChiTietHoaDon.Rows[index].Cells["IDThucDon"].Value.ToString();
                }
                MyDatabase.ChiTietHoaDonBanHang chitiet = CTHDBHAc.getChiTietHoaDonBanHang(soHD, IDthucDon);
                if (chitiet == null)
                {
                    MessageBox.Show("Thực đơn này chưa tồn tại trong hóa đơn bán hàng!");
                }
                else
                {
                    soLuong = chitiet.soLuong - soLuong;
                    if (soLuong > 0)
                    {
                        CTHDBHAc.Sua(new MyDatabase.ChiTietHoaDonBanHang() { IDhoaDonBH = soHD, IDthucDon = IDthucDon, soLuong = soLuong });
                    }
                    else if (soLuong == 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn xóa thưc đơn này ra khỏi hóa đơn bán hàng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            try
                            {
                                CTHDBHAc.Xoa(chitiet);
                                MessageBox.Show("Đã xóa thành công");
                                if (index == indexRowCTTD)
                                {
                                    index = -1;
                                    indexRowCTTD = -1;
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
                            MessageBox.Show("Trong hóa đơn bán hàng, thực đơn này không chứa tới số lượng " + (chitiet.soLuong - soLuong).ToString());
                        }
                    }
                }
                dgvChiTietHoaDon.DataSource = HDBHAc.getChiTietHoaDonBanHang(soHD);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thực đơn và số lượng cần giảm vào!");
            }
            if (index == -1)
            {
                dgvThucDon.ClearSelection();
                dgvChiTietHoaDon.ClearSelection();
            }
            else if (index == indexRowTD)
            {
                dgvChiTietHoaDon.ClearSelection();
            }
            else
            {
                dgvThucDon.ClearSelection();
                dgvChiTietHoaDon.Rows[indexRowCTTD].Selected = true;
            }
            MyDatabase.f_TinhTienHoaDonBH_Result tienHD = HDBHAc.getTienHoaDonBH(txtSoHD.Text);
            txtThanhTien.Text = tienHD != null ? tienHD.TongGia.ToString() : "0";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = indexRowCTTD;
            if (index > -1)
            {
                string soHD = txtSoHD.Text;
                string IDthucDon = dgvChiTietHoaDon.Rows[index].Cells["IDThucDon"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thưc đơn này ra khỏi hóa đơn bán hàng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        CTHDBHAc.Xoa(soHD, IDthucDon);
                        MessageBox.Show("Đã xóa thành công");
                        dgvChiTietHoaDon.DataSource = HDBHAc.getChiTietHoaDonBanHang(soHD);
                        indexRowCTTD = -1;
                        dgvChiTietHoaDon.ClearSelection();
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
                MessageBox.Show("Vui lòng chọn thực đơn trong hóa đơn bán hàng cần xóa khỏi danh sách!");
            }
            MyDatabase.f_TinhTienHoaDonBH_Result tienHD = HDBHAc.getTienHoaDonBH(txtSoHD.Text);
            txtThanhTien.Text = tienHD != null ? tienHD.TongGia.ToString() : "0";
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvThucDon.ClearSelection();
            indexRowTD = -1;
            indexRowCTTD = e.RowIndex;
        }

        private void dgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvChiTietHoaDon.ClearSelection();
            indexRowTD = e.RowIndex;
            indexRowCTTD = -1;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!txtSoHD.Text.Equals(""))
            {
                try
                {
                    MyDatabase.HoaDonBanHang hd = HDBHAc.getHoaDonBanHang(txtSoHD.Text);

                    if (hd != null)
                    {
                        hd.DaThanhToan = true;
                        HDBHAc.Sua(hd);
                        DialogResult traloi = MessageBox.Show("Thanh toán thành công! Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (traloi == DialogResult.OK)
                        {
                            string tenKhachHang = thanhViens.Find(p => p.ID == cbbKhachHang.SelectedValue.ToString()).HoTen;
                            Report.FrmReport frmReport = new Report.FrmReport(connectionString, txtSoHD.Text, tenKhachHang, true);
                            frmReport.ShowDialog();
                        }
                        dgvChiTietHoaDon.DataSource = HDBHAc.getChiTietHoaDonBanHang("-1");
                        dgvKhachHang.DataSource = BAc.getThanhVienTheoBan(lsvBan.SelectedItems[0].Name);
                        dgvKhachHang.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng tạo hóa đơn cho bàn này trước!");
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
                MessageBox.Show("Vui lòng tạo hóa đơn cho bàn này trước!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string ban = txtBan.Text;
            if(ban.Equals("") || ban.Equals(null))
            {
                MessageBox.Show("Vui lòng chọn bàn trước");
                return;
            }
            string name = btnHuy.Text.ToUpper();
            if (name.Equals("TẠO HÓA ĐƠN"))
            {
                btnHuy.Text = "Hủy Hóa Đơn";
                btnHuy.Image = global::QuanLyCafe.Properties.Resources.edit_delete;
            }
            else
            {
                try
                {
                    MyDatabase.HoaDonBanHang hd = HDBHAc.getHoaDonBanHang(txtSoHD.Text);
                    if (hd != null)
                    {
                        HDBHAc.Xoa(hd);
                        MessageBox.Show("Đã hủy hóa đơn thành công");
                        dgvChiTietHoaDon.DataSource = HDBHAc.getChiTietHoaDonBanHang("-1");
                        dgvKhachHang.DataSource = BAc.getThanhVienTheoBan(lsvBan.SelectedItems[0].Name);
                        dgvKhachHang.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng tạo hóa đơn cho bàn này trước");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void FrmSuDungDichVu_Load(object sender, EventArgs e)
        {
            dgvThucDon.ClearSelection();
        }

        private void FrmSuDungDichVu_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                DataBind();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (txtSoHD.Text.Equals("") || txtSoHD.Text.Equals(null))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần in!");
            }
            else
            {
                try
                {
                    MyDatabase.HoaDonBanHang hd = HDBHAc.getHoaDonBanHang(txtSoHD.Text);
                    if (hd != null)
                    {
                        string tenKhachHang = thanhViens.Find(p => p.ID == cbbKhachHang.SelectedValue.ToString()).HoTen;
                        Report.FrmReport frmReport = new Report.FrmReport(connectionString, txtSoHD.Text, tenKhachHang, true);
                        frmReport.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng tạo hóa đơn trước!");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHuy.Text = "Hủy Hóa Đơn";
            btnHuy.Image = global::QuanLyCafe.Properties.Resources.edit_delete;
            int curRow = dgvKhachHang.CurrentRow.Index;
            btnTim.Enabled = txtIDKhachHang.Enabled = cbbKhachHang.Enabled = false;
            if (curRow != -1)
            {
                string ID = dgvKhachHang.Rows[curRow].Cells[0].Value.ToString();
                string IDHoaDon = dgvKhachHang.Rows[curRow].Cells[4].Value.ToString();
                cbbKhachHang.SelectedItem = thanhViens.Find(p => p.ID == ID);
                try
                {
                    dgvChiTietHoaDon.DataSource = HDBHAc.getChiTietHoaDonBanHang(IDHoaDon);
                    txtSoHD.Text = IDHoaDon;
                    MyDatabase.f_TinhTienHoaDonBH_Result tienHD = HDBHAc.getTienHoaDonBH(txtSoHD.Text);
                    txtThanhTien.Text = tienHD != null ? tienHD.TongGia.ToString() : "0";
                    dgvThucDon.ClearSelection();
                    dgvChiTietHoaDon.ClearSelection();
                    indexRowTD = -1;
                    indexRowCTTD = -1;
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại sau!");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            MyDatabase.ThanhVien tv = TVAc.getThanhVien(txtIDKhachHang.Text);
            if (tv == null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                cbbKhachHang.SelectedIndex = cbbKhachHang.Items.IndexOf(thanhViens.Find(p => p.ID == tv.ID));
            }
        }
    }
}
