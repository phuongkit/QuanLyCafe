
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grbBan = new System.Windows.Forms.GroupBox();
            this.lsvBan = new System.Windows.Forms.ListView();
            this.trvLoaiThucDon = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.grbBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AllowUserToResizeColumns = false;
            this.dgvThucDon.AllowUserToResizeRows = false;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten,
            this.DonViTinh,
            this.DonGia});
            this.dgvThucDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvThucDon.Location = new System.Drawing.Point(1057, 373);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dgvChiTietHoaDon);
            this.panel1.Controls.Add(this.txtBan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSoHD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNhanVien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtThanhTien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnGiam);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.nmSoLuong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtNgay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(527, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 793);
            this.panel1.TabIndex = 1;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToResizeColumns = false;
            this.dgvChiTietHoaDon.AllowUserToResizeRows = false;
            this.dgvChiTietHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDThucDon,
            this.TenThucDon,
            this.CTsoLuong,
            this.CTDonGia,
            this.CTThanhTien,
            this.CTdonViTinh});
            this.dgvChiTietHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(0, 100);
            this.dgvChiTietHoaDon.MultiSelect = false;
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            this.dgvChiTietHoaDon.RowHeadersVisible = false;
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dgvChiTietHoaDon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(432, 556);
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
            this.txtBan.Enabled = false;
            this.txtBan.Location = new System.Drawing.Point(70, 10);
            this.txtBan.Name = "txtBan";
            this.txtBan.Size = new System.Drawing.Size(100, 22);
            this.txtBan.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ngày:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Enabled = false;
            this.txtSoHD.Location = new System.Drawing.Point(384, 56);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(108, 22);
            this.txtSoHD.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số HĐ:";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Location = new System.Drawing.Point(85, 53);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(172, 22);
            this.txtNhanVien.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhân viên:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(100, 711);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(143, 22);
            this.txtThanhTien.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 716);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thành tiền:";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyCafe.Properties.Resources.cancel__1_;
            this.btnHuy.Location = new System.Drawing.Point(390, 686);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(116, 77);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy Hóa Đơn";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Image = global::QuanLyCafe.Properties.Resources.payment;
            this.btnThanhToan.Location = new System.Drawing.Point(266, 686);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(110, 77);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyCafe.Properties.Resources.edit_delete__1_;
            this.btnXoa.Location = new System.Drawing.Point(441, 380);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 63);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "X Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Image = global::QuanLyCafe.Properties.Resources.decrease_1_;
            this.btnGiam.Location = new System.Drawing.Point(441, 297);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(80, 67);
            this.btnGiam.TabIndex = 7;
            this.btnGiam.Text = "Giảm >>";
            this.btnGiam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyCafe.Properties.Resources.increase__1_;
            this.btnThem.Location = new System.Drawing.Point(441, 213);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 68);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm <<";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(441, 163);
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
            this.label2.Location = new System.Drawing.Point(438, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng:";
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(384, 5);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(108, 22);
            this.dtNgay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bàn:";
            // 
            // grbBan
            // 
            this.grbBan.Controls.Add(this.lsvBan);
            this.grbBan.Location = new System.Drawing.Point(12, 3);
            this.grbBan.Name = "grbBan";
            this.grbBan.Size = new System.Drawing.Size(509, 793);
            this.grbBan.TabIndex = 2;
            this.grbBan.TabStop = false;
            this.grbBan.Text = "Quản Lý Bàn";
            // 
            // lsvBan
            // 
            this.lsvBan.HideSelection = false;
            this.lsvBan.Location = new System.Drawing.Point(6, 21);
            this.lsvBan.Name = "lsvBan";
            this.lsvBan.Size = new System.Drawing.Size(496, 764);
            this.lsvBan.TabIndex = 0;
            this.lsvBan.UseCompatibleStateImageBehavior = false;
            this.lsvBan.SelectedIndexChanged += new System.EventHandler(this.lsvBan_SelectedIndexChanged);
            // 
            // trvLoaiThucDon
            // 
            this.trvLoaiThucDon.Location = new System.Drawing.Point(1057, 12);
            this.trvLoaiThucDon.Name = "trvLoaiThucDon";
            this.trvLoaiThucDon.Size = new System.Drawing.Size(431, 355);
            this.trvLoaiThucDon.TabIndex = 3;
            this.trvLoaiThucDon.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvLoaiThucDon_NodeMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 80);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmSuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trvLoaiThucDon);
            this.Controls.Add(this.grbBan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvThucDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSuDungDichVu";
            this.RightToLeftLayout = true;
            this.Text = "FrmSuDungDichVu";
            this.Load += new System.EventHandler(this.FrmSuDungDichVu_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmSuDungDichVu_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.grbBan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.GroupBox grbBan;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}