
namespace QuanLyCafe.MyForm
{
    partial class FrmHoaDonBanHang
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
            this.grbHoaDon = new System.Windows.Forms.GroupBox();
            this.btnExportExcell = new System.Windows.Forms.Button();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.cbbBan = new System.Windows.Forms.ComboBox();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.dtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.txtIDHoaDon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDnhanVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IDban = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaThanhToan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbCTThucDon = new System.Windows.Forms.ComboBox();
            this.nmCTSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtCTIDHoaDon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChiTietBoQua = new System.Windows.Forms.Button();
            this.btnChiTietLuu = new System.Windows.Forms.Button();
            this.btnChiTietXoa = new System.Windows.Forms.Button();
            this.btnChiTietSua = new System.Windows.Forms.Button();
            this.btnChiTietThem = new System.Windows.Forms.Button();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.IDhoaDonBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDthucDon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.grbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCTSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHoaDon
            // 
            this.grbHoaDon.Controls.Add(this.btnExportExcell);
            this.grbHoaDon.Controls.Add(this.cbbNhanVien);
            this.grbHoaDon.Controls.Add(this.cbbBan);
            this.grbHoaDon.Controls.Add(this.cbbTinhTrang);
            this.grbHoaDon.Controls.Add(this.dtNgayTao);
            this.grbHoaDon.Controls.Add(this.txtIDHoaDon);
            this.grbHoaDon.Controls.Add(this.label6);
            this.grbHoaDon.Controls.Add(this.label4);
            this.grbHoaDon.Controls.Add(this.label3);
            this.grbHoaDon.Controls.Add(this.label2);
            this.grbHoaDon.Controls.Add(this.label1);
            this.grbHoaDon.Controls.Add(this.btnBoQua);
            this.grbHoaDon.Controls.Add(this.btnLuu);
            this.grbHoaDon.Controls.Add(this.btnXoa);
            this.grbHoaDon.Controls.Add(this.btnSua);
            this.grbHoaDon.Controls.Add(this.btnThem);
            this.grbHoaDon.Controls.Add(this.dgvHoaDon);
            this.grbHoaDon.Location = new System.Drawing.Point(13, 13);
            this.grbHoaDon.Name = "grbHoaDon";
            this.grbHoaDon.Size = new System.Drawing.Size(742, 784);
            this.grbHoaDon.TabIndex = 0;
            this.grbHoaDon.TabStop = false;
            this.grbHoaDon.Text = "Danh sách hóa đơn";
            // 
            // btnExportExcell
            // 
            this.btnExportExcell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcell.Image = global::QuanLyCafe.Properties.Resources.icons8_export_excel_48;
            this.btnExportExcell.Location = new System.Drawing.Point(606, 681);
            this.btnExportExcell.Name = "btnExportExcell";
            this.btnExportExcell.Size = new System.Drawing.Size(130, 61);
            this.btnExportExcell.TabIndex = 25;
            this.btnExportExcell.Text = "Xuất Excel";
            this.btnExportExcell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcell.UseVisualStyleBackColor = true;
            this.btnExportExcell.Click += new System.EventHandler(this.btnExportExcell_Click);
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(121, 94);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(138, 28);
            this.cbbNhanVien.TabIndex = 24;
            // 
            // cbbBan
            // 
            this.cbbBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBan.FormattingEnabled = true;
            this.cbbBan.Location = new System.Drawing.Point(365, 27);
            this.cbbBan.Name = "cbbBan";
            this.cbbBan.Size = new System.Drawing.Size(163, 28);
            this.cbbBan.TabIndex = 23;
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Location = new System.Drawing.Point(564, 87);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(163, 28);
            this.cbbTinhTrang.TabIndex = 22;
            // 
            // dtNgayTao
            // 
            this.dtNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTao.Location = new System.Drawing.Point(365, 92);
            this.dtNgayTao.Name = "dtNgayTao";
            this.dtNgayTao.Size = new System.Drawing.Size(137, 27);
            this.dtNgayTao.TabIndex = 21;
            // 
            // txtIDHoaDon
            // 
            this.txtIDHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDHoaDon.Location = new System.Drawing.Point(121, 35);
            this.txtIDHoaDon.Name = "txtIDHoaDon";
            this.txtIDHoaDon.Size = new System.Drawing.Size(134, 27);
            this.txtIDHoaDon.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngày tạo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bàn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tình trạng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID hóa đơn:";
            // 
            // btnBoQua
            // 
            this.btnBoQua.Image = global::QuanLyCafe.Properties.Resources.cancel;
            this.btnBoQua.Location = new System.Drawing.Point(468, 682);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(124, 61);
            this.btnBoQua.TabIndex = 10;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyCafe.Properties.Resources.save__1_;
            this.btnLuu.Location = new System.Drawing.Point(348, 682);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 61);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyCafe.Properties.Resources.edit_delete;
            this.btnXoa.Location = new System.Drawing.Point(237, 682);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 61);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyCafe.Properties.Resources.pencil;
            this.btnSua.Location = new System.Drawing.Point(121, 682);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 61);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyCafe.Properties.Resources.edit_add;
            this.btnThem.Location = new System.Drawing.Point(5, 682);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 61);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToResizeColumns = false;
            this.dgvHoaDon.AllowUserToResizeRows = false;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDnhanVien,
            this.IDban,
            this.NgayTao,
            this.DaThanhToan});
            this.dgvHoaDon.Location = new System.Drawing.Point(7, 171);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(729, 505);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID hóa đơn";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // IDnhanVien
            // 
            this.IDnhanVien.DataPropertyName = "IDnhanVien";
            this.IDnhanVien.HeaderText = "ID nhân viên";
            this.IDnhanVien.MinimumWidth = 6;
            this.IDnhanVien.Name = "IDnhanVien";
            this.IDnhanVien.ReadOnly = true;
            this.IDnhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDnhanVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IDnhanVien.Width = 125;
            // 
            // IDban
            // 
            this.IDban.DataPropertyName = "IDban";
            this.IDban.HeaderText = "ID bàn";
            this.IDban.MinimumWidth = 6;
            this.IDban.Name = "IDban";
            this.IDban.ReadOnly = true;
            this.IDban.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDban.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IDban.Width = 125;
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayTao";
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.MinimumWidth = 6;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            this.NgayTao.Width = 125;
            // 
            // DaThanhToan
            // 
            this.DaThanhToan.DataPropertyName = "DaThanhToan";
            this.DaThanhToan.HeaderText = "Tình trạng thanh toán";
            this.DaThanhToan.MinimumWidth = 6;
            this.DaThanhToan.Name = "DaThanhToan";
            this.DaThanhToan.ReadOnly = true;
            this.DaThanhToan.Width = 125;
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Controls.Add(this.button1);
            this.grbChiTiet.Controls.Add(this.cbbCTThucDon);
            this.grbChiTiet.Controls.Add(this.nmCTSoLuong);
            this.grbChiTiet.Controls.Add(this.txtCTIDHoaDon);
            this.grbChiTiet.Controls.Add(this.label9);
            this.grbChiTiet.Controls.Add(this.label8);
            this.grbChiTiet.Controls.Add(this.label7);
            this.grbChiTiet.Controls.Add(this.btnChiTietBoQua);
            this.grbChiTiet.Controls.Add(this.btnChiTietLuu);
            this.grbChiTiet.Controls.Add(this.btnChiTietXoa);
            this.grbChiTiet.Controls.Add(this.btnChiTietSua);
            this.grbChiTiet.Controls.Add(this.btnChiTietThem);
            this.grbChiTiet.Controls.Add(this.dgvChiTietHoaDon);
            this.grbChiTiet.Location = new System.Drawing.Point(761, 13);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(727, 775);
            this.grbChiTiet.TabIndex = 1;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Chi tiết hóa đơn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyCafe.Properties.Resources.icons8_export_excel_48;
            this.button1.Location = new System.Drawing.Point(604, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 61);
            this.button1.TabIndex = 26;
            this.button1.Text = "Xuất Excel";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbbCTThucDon
            // 
            this.cbbCTThucDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCTThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCTThucDon.FormattingEnabled = true;
            this.cbbCTThucDon.Location = new System.Drawing.Point(125, 87);
            this.cbbCTThucDon.Name = "cbbCTThucDon";
            this.cbbCTThucDon.Size = new System.Drawing.Size(217, 28);
            this.cbbCTThucDon.TabIndex = 24;
            // 
            // nmCTSoLuong
            // 
            this.nmCTSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCTSoLuong.Location = new System.Drawing.Point(441, 60);
            this.nmCTSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCTSoLuong.Name = "nmCTSoLuong";
            this.nmCTSoLuong.Size = new System.Drawing.Size(167, 27);
            this.nmCTSoLuong.TabIndex = 23;
            this.nmCTSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCTIDHoaDon
            // 
            this.txtCTIDHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCTIDHoaDon.Location = new System.Drawing.Point(120, 35);
            this.txtCTIDHoaDon.Name = "txtCTIDHoaDon";
            this.txtCTIDHoaDon.Size = new System.Drawing.Size(222, 27);
            this.txtCTIDHoaDon.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID hóa đơn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID thực đơn:";
            // 
            // btnChiTietBoQua
            // 
            this.btnChiTietBoQua.Image = global::QuanLyCafe.Properties.Resources.cancel;
            this.btnChiTietBoQua.Location = new System.Drawing.Point(484, 682);
            this.btnChiTietBoQua.Name = "btnChiTietBoQua";
            this.btnChiTietBoQua.Size = new System.Drawing.Size(114, 61);
            this.btnChiTietBoQua.TabIndex = 10;
            this.btnChiTietBoQua.Text = "Bỏ qua";
            this.btnChiTietBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTietBoQua.UseVisualStyleBackColor = true;
            this.btnChiTietBoQua.Click += new System.EventHandler(this.btnChiTietBoQua_Click);
            // 
            // btnChiTietLuu
            // 
            this.btnChiTietLuu.Image = global::QuanLyCafe.Properties.Resources.save__1_;
            this.btnChiTietLuu.Location = new System.Drawing.Point(362, 682);
            this.btnChiTietLuu.Name = "btnChiTietLuu";
            this.btnChiTietLuu.Size = new System.Drawing.Size(109, 61);
            this.btnChiTietLuu.TabIndex = 9;
            this.btnChiTietLuu.Text = "Lưu";
            this.btnChiTietLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTietLuu.UseVisualStyleBackColor = true;
            this.btnChiTietLuu.Click += new System.EventHandler(this.btnChiTietLuu_Click);
            // 
            // btnChiTietXoa
            // 
            this.btnChiTietXoa.Image = global::QuanLyCafe.Properties.Resources.edit_delete;
            this.btnChiTietXoa.Location = new System.Drawing.Point(241, 682);
            this.btnChiTietXoa.Name = "btnChiTietXoa";
            this.btnChiTietXoa.Size = new System.Drawing.Size(115, 61);
            this.btnChiTietXoa.TabIndex = 8;
            this.btnChiTietXoa.Text = "Xóa";
            this.btnChiTietXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTietXoa.UseVisualStyleBackColor = true;
            this.btnChiTietXoa.Click += new System.EventHandler(this.btnChiTietXoa_Click);
            // 
            // btnChiTietSua
            // 
            this.btnChiTietSua.Image = global::QuanLyCafe.Properties.Resources.pencil;
            this.btnChiTietSua.Location = new System.Drawing.Point(125, 682);
            this.btnChiTietSua.Name = "btnChiTietSua";
            this.btnChiTietSua.Size = new System.Drawing.Size(110, 61);
            this.btnChiTietSua.TabIndex = 7;
            this.btnChiTietSua.Text = "Sửa";
            this.btnChiTietSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTietSua.UseVisualStyleBackColor = true;
            this.btnChiTietSua.Click += new System.EventHandler(this.btnChiTietSua_Click);
            // 
            // btnChiTietThem
            // 
            this.btnChiTietThem.Image = global::QuanLyCafe.Properties.Resources.edit_add;
            this.btnChiTietThem.Location = new System.Drawing.Point(7, 682);
            this.btnChiTietThem.Name = "btnChiTietThem";
            this.btnChiTietThem.Size = new System.Drawing.Size(112, 61);
            this.btnChiTietThem.TabIndex = 6;
            this.btnChiTietThem.Text = "Thêm mới";
            this.btnChiTietThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTietThem.UseVisualStyleBackColor = true;
            this.btnChiTietThem.Click += new System.EventHandler(this.btnChiTietThem_Click);
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToResizeColumns = false;
            this.dgvChiTietHoaDon.AllowUserToResizeRows = false;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDhoaDonBH,
            this.IDthucDon,
            this.soLuong});
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(7, 171);
            this.dgvChiTietHoaDon.MultiSelect = false;
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            this.dgvChiTietHoaDon.RowHeadersVisible = false;
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dgvChiTietHoaDon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(714, 505);
            this.dgvChiTietHoaDon.TabIndex = 0;
            // 
            // IDhoaDonBH
            // 
            this.IDhoaDonBH.DataPropertyName = "IDhoaDonBH";
            this.IDhoaDonBH.HeaderText = "ID hóa đơn";
            this.IDhoaDonBH.MinimumWidth = 6;
            this.IDhoaDonBH.Name = "IDhoaDonBH";
            this.IDhoaDonBH.ReadOnly = true;
            this.IDhoaDonBH.Width = 125;
            // 
            // IDthucDon
            // 
            this.IDthucDon.DataPropertyName = "IDthucDon";
            this.IDthucDon.HeaderText = "ID thực đơn";
            this.IDthucDon.MinimumWidth = 6;
            this.IDthucDon.Name = "IDthucDon";
            this.IDthucDon.ReadOnly = true;
            this.IDthucDon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDthucDon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IDthucDon.Width = 250;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 125;
            // 
            // FrmHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.ControlBox = false;
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.grbHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHoaDonBanHang";
            this.Text = "FrmHoaDonBanHang";
            this.VisibleChanged += new System.EventHandler(this.FrmHoaDonBanHang_VisibleChanged);
            this.grbHoaDon.ResumeLayout(false);
            this.grbHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCTSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHoaDon;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.DateTimePicker dtNgayTao;
        private System.Windows.Forms.TextBox txtIDHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nmCTSoLuong;
        private System.Windows.Forms.TextBox txtCTIDHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChiTietBoQua;
        private System.Windows.Forms.Button btnChiTietLuu;
        private System.Windows.Forms.Button btnChiTietXoa;
        private System.Windows.Forms.Button btnChiTietSua;
        private System.Windows.Forms.Button btnChiTietThem;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.ComboBox cbbBan;
        private System.Windows.Forms.ComboBox cbbCTThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDhoaDonBH;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDthucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDnhanVien;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDban;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewComboBoxColumn DaThanhToan;
        private System.Windows.Forms.Button btnExportExcell;
        private System.Windows.Forms.Button button1;
    }
}