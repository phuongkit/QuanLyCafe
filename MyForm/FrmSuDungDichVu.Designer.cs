
namespace QuanLyCafe.MyForm
{
    partial class FrmSuDungDichVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.IDThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTsoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTdonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvBan = new System.Windows.Forms.ListView();
            this.trvLoaiThucDon = new System.Windows.Forms.TreeView();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbKhachHang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDKhachHang = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.IDKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AllowUserToResizeColumns = false;
            this.dgvThucDon.AllowUserToResizeRows = false;
            this.dgvThucDon.ColumnHeadersHeight = 29;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten,
            this.DonViTinh,
            this.DonGia});
            this.dgvThucDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvThucDon.Location = new System.Drawing.Point(1057, 373);
            this.dgvThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThucDon.MultiSelect = false;
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.ReadOnly = true;
            this.dgvThucDon.RowHeadersVisible = false;
            this.dgvThucDon.RowHeadersWidth = 51;
            this.dgvThucDon.RowTemplate.Height = 24;
            this.dgvThucDon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucDon.Size = new System.Drawing.Size(431, 423);
            this.dgvThucDon.TabIndex = 0;
            this.dgvThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucDon_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Mặt hàng";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 107;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "ĐVT";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Width = 40;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 60;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToResizeColumns = false;
            this.dgvChiTietHoaDon.AllowUserToResizeRows = false;
            this.dgvChiTietHoaDon.ColumnHeadersHeight = 29;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDThucDon,
            this.TenThucDon,
            this.CTsoLuong,
            this.CTDonGia,
            this.CTThanhTien,
            this.CTdonViTinh});
            this.dgvChiTietHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(511, 139);
            this.dgvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTietHoaDon.MultiSelect = false;
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            this.dgvChiTietHoaDon.RowHeadersVisible = false;
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dgvChiTietHoaDon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(432, 453);
            this.dgvChiTietHoaDon.TabIndex = 1;
            this.dgvChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellClick);
            // 
            // IDThucDon
            // 
            this.IDThucDon.DataPropertyName = "IDThucDon";
            this.IDThucDon.HeaderText = "ID";
            this.IDThucDon.MinimumWidth = 6;
            this.IDThucDon.Name = "IDThucDon";
            this.IDThucDon.ReadOnly = true;
            this.IDThucDon.Width = 30;
            // 
            // TenThucDon
            // 
            this.TenThucDon.DataPropertyName = "TenThucDon";
            this.TenThucDon.HeaderText = "Mặt hàng";
            this.TenThucDon.MinimumWidth = 6;
            this.TenThucDon.Name = "TenThucDon";
            this.TenThucDon.ReadOnly = true;
            this.TenThucDon.Width = 115;
            // 
            // CTsoLuong
            // 
            this.CTsoLuong.DataPropertyName = "SoLuong";
            this.CTsoLuong.HeaderText = "SL";
            this.CTsoLuong.MinimumWidth = 6;
            this.CTsoLuong.Name = "CTsoLuong";
            this.CTsoLuong.ReadOnly = true;
            this.CTsoLuong.Width = 40;
            // 
            // CTDonGia
            // 
            this.CTDonGia.DataPropertyName = "DonGia";
            this.CTDonGia.HeaderText = "Đơn Giá";
            this.CTDonGia.MinimumWidth = 6;
            this.CTDonGia.Name = "CTDonGia";
            this.CTDonGia.ReadOnly = true;
            this.CTDonGia.Width = 50;
            // 
            // CTThanhTien
            // 
            this.CTThanhTien.DataPropertyName = "ThanhTien";
            this.CTThanhTien.HeaderText = "Thành Tiền";
            this.CTThanhTien.MinimumWidth = 6;
            this.CTThanhTien.Name = "CTThanhTien";
            this.CTThanhTien.ReadOnly = true;
            this.CTThanhTien.Width = 50;
            // 
            // CTdonViTinh
            // 
            this.CTdonViTinh.DataPropertyName = "DonViTinh";
            this.CTdonViTinh.HeaderText = "ĐVT";
            this.CTdonViTinh.MinimumWidth = 6;
            this.CTdonViTinh.Name = "CTdonViTinh";
            this.CTdonViTinh.ReadOnly = true;
            this.CTdonViTinh.Width = 40;
            // 
            // txtBan
            // 
            this.txtBan.BackColor = System.Drawing.Color.White;
            this.txtBan.Enabled = false;
            this.txtBan.Location = new System.Drawing.Point(564, 4);
            this.txtBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBan.Name = "txtBan";
            this.txtBan.Size = new System.Drawing.Size(100, 22);
            this.txtBan.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(817, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ngày:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.BackColor = System.Drawing.Color.White;
            this.txtSoHD.Enabled = false;
            this.txtSoHD.Location = new System.Drawing.Point(895, 55);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(108, 22);
            this.txtSoHD.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(817, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số HĐ:";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.BackColor = System.Drawing.Color.White;
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Location = new System.Drawing.Point(611, 47);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(172, 22);
            this.txtNhanVien.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(513, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhân viên:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.White;
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(611, 709);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(143, 22);
            this.txtThanhTien.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(508, 714);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thành tiền:";
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.BackColor = System.Drawing.Color.White;
            this.nmSoLuong.Location = new System.Drawing.Point(953, 251);
            this.nmSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(80, 22);
            this.nmSoLuong.TabIndex = 5;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(949, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng:";
            // 
            // dtNgay
            // 
            this.dtNgay.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(895, 7);
            this.dtNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(108, 22);
            this.dtNgay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(515, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bàn:";
            // 
            // lsvBan
            // 
            this.lsvBan.BackColor = System.Drawing.Color.White;
            this.lsvBan.BackgroundImageTiled = true;
            this.lsvBan.HideSelection = false;
            this.lsvBan.Location = new System.Drawing.Point(-3, 0);
            this.lsvBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvBan.Name = "lsvBan";
            this.lsvBan.Size = new System.Drawing.Size(496, 592);
            this.lsvBan.TabIndex = 0;
            this.lsvBan.UseCompatibleStateImageBehavior = false;
            this.lsvBan.SelectedIndexChanged += new System.EventHandler(this.lsvBan_SelectedIndexChanged);
            // 
            // trvLoaiThucDon
            // 
            this.trvLoaiThucDon.Location = new System.Drawing.Point(1057, 12);
            this.trvLoaiThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trvLoaiThucDon.Name = "trvLoaiThucDon";
            this.trvLoaiThucDon.Size = new System.Drawing.Size(431, 355);
            this.trvLoaiThucDon.TabIndex = 3;
            this.trvLoaiThucDon.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvLoaiThucDon_NodeMouseClick);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToResizeColumns = false;
            this.dgvKhachHang.AllowUserToResizeRows = false;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKH,
            this.HoTen,
            this.SDT,
            this.Email,
            this.IDHoaDon});
            this.dgvKhachHang.Location = new System.Drawing.Point(-3, 597);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(496, 179);
            this.dgvKhachHang.TabIndex = 20;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(513, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Khách hàng:";
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhachHang.FormattingEnabled = true;
            this.cbbKhachHang.Location = new System.Drawing.Point(611, 89);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(172, 24);
            this.cbbKhachHang.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(817, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tìm ID:";
            // 
            // txtIDKhachHang
            // 
            this.txtIDKhachHang.BackColor = System.Drawing.Color.White;
            this.txtIDKhachHang.Location = new System.Drawing.Point(895, 93);
            this.txtIDKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDKhachHang.Name = "txtIDKhachHang";
            this.txtIDKhachHang.Size = new System.Drawing.Size(108, 22);
            this.txtIDKhachHang.TabIndex = 24;
            // 
            // btnTim
            // 
            this.btnTim.Image = global::QuanLyCafe.Properties.Resources.document_view2;
            this.btnTim.Location = new System.Drawing.Point(952, 132);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(80, 68);
            this.btnTim.TabIndex = 25;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyCafe.Properties.Resources.edit_add;
            this.btnHuy.Location = new System.Drawing.Point(773, 600);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(122, 77);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Tạo Hóa Đơn";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyCafe.Properties.Resources.increase__1_;
            this.btnThem.Location = new System.Drawing.Point(953, 318);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 68);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm <<";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Red;
            this.btnThanhToan.Image = global::QuanLyCafe.Properties.Resources.payment;
            this.btnThanhToan.Location = new System.Drawing.Point(773, 697);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(259, 80);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::QuanLyCafe.Properties.Resources.printer_icon_simple_style_3219886;
            this.btnIn.Location = new System.Drawing.Point(916, 600);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(116, 80);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "In Hóa Đơn";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Image = global::QuanLyCafe.Properties.Resources.decrease_1_;
            this.btnGiam.Location = new System.Drawing.Point(953, 402);
            this.btnGiam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(80, 66);
            this.btnGiam.TabIndex = 7;
            this.btnGiam.Text = "Giảm >>";
            this.btnGiam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyCafe.Properties.Resources.edit_delete__1_;
            this.btnXoa.Location = new System.Drawing.Point(953, 486);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 63);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // IDKH
            // 
            this.IDKH.DataPropertyName = "ID";
            this.IDKH.HeaderText = "ID";
            this.IDKH.MinimumWidth = 6;
            this.IDKH.Name = "IDKH";
            this.IDKH.ReadOnly = true;
            this.IDKH.Width = 40;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 95;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 70;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // IDHoaDon
            // 
            this.IDHoaDon.DataPropertyName = "IDHoaDon";
            this.IDHoaDon.HeaderText = "Hóa đơn";
            this.IDHoaDon.MinimumWidth = 6;
            this.IDHoaDon.Name = "IDHoaDon";
            this.IDHoaDon.ReadOnly = true;
            this.IDHoaDon.Width = 40;
            // 
            // FrmSuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.ControlBox = false;
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtIDKhachHang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbKhachHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Controls.Add(this.lsvBan);
            this.Controls.Add(this.txtBan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trvLoaiThucDon);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvThucDon);
            this.Controls.Add(this.txtNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmSoLuong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnXoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSuDungDichVu";
            this.RightToLeftLayout = true;
            this.Text = "FrmSuDungDichVu";
            this.Load += new System.EventHandler(this.FrmSuDungDichVu_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmSuDungDichVu_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.TextBox txtBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView trvLoaiThucDon;
        private System.Windows.Forms.ListView lsvBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTsoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTdonViTinh;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDKhachHang;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHoaDon;
    }
}