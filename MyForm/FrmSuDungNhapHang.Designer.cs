
namespace QuanLyCafe.MyForm
{
    partial class FrmSuDungNhapHang
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
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.dtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvChiTietNhapHang = new System.Windows.Forms.DataGridView();
            this.CTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbKhoHang = new System.Windows.Forms.GroupBox();
            this.dgvKhoHang = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIn = new System.Windows.Forms.Button();
            this.grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapHang)).BeginInit();
            this.grbKhoHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).BeginInit();
            this.SuspendLayout();
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnIn);
            this.grbChucNang.Controls.Add(this.dtNgayTao);
            this.grbChucNang.Controls.Add(this.txtSoHD);
            this.grbChucNang.Controls.Add(this.txtNhanVien);
            this.grbChucNang.Controls.Add(this.txtThanhTien);
            this.grbChucNang.Controls.Add(this.label5);
            this.grbChucNang.Controls.Add(this.btnHuy);
            this.grbChucNang.Controls.Add(this.btnTaoHoaDon);
            this.grbChucNang.Controls.Add(this.label4);
            this.grbChucNang.Controls.Add(this.label3);
            this.grbChucNang.Controls.Add(this.label2);
            this.grbChucNang.Controls.Add(this.label1);
            this.grbChucNang.Controls.Add(this.nmSoLuong);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnGiam);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Controls.Add(this.dgvChiTietNhapHang);
            this.grbChucNang.Location = new System.Drawing.Point(12, 12);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(880, 776);
            this.grbChucNang.TabIndex = 1;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Nhóm chức năng";
            // 
            // dtNgayTao
            // 
            this.dtNgayTao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayTao.Location = new System.Drawing.Point(141, 120);
            this.dtNgayTao.Name = "dtNgayTao";
            this.dtNgayTao.Size = new System.Drawing.Size(235, 22);
            this.dtNgayTao.TabIndex = 16;
            // 
            // txtSoHD
            // 
            this.txtSoHD.Enabled = false;
            this.txtSoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHD.Location = new System.Drawing.Point(623, 70);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(143, 27);
            this.txtSoHD.TabIndex = 15;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(151, 50);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(143, 27);
            this.txtNhanVien.TabIndex = 14;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(141, 671);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(143, 27);
            this.txtThanhTien.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 671);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thành tiền:";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyCafe.Properties.Resources.cancel;
            this.btnHuy.Location = new System.Drawing.Point(560, 661);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(129, 80);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy hóa đơn";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Image = global::QuanLyCafe.Properties.Resources.payment__1_;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(393, 661);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(129, 81);
            this.btnTaoHoaDon.TabIndex = 9;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(730, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số lượng";
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmSoLuong.Location = new System.Drawing.Point(730, 246);
            this.nmSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(120, 30);
            this.nmSoLuong.TabIndex = 4;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyCafe.Properties.Resources.edit_delete;
            this.btnXoa.Location = new System.Drawing.Point(730, 543);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 71);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Image = global::QuanLyCafe.Properties.Resources.decrease;
            this.btnGiam.Location = new System.Drawing.Point(730, 430);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(129, 71);
            this.btnGiam.TabIndex = 2;
            this.btnGiam.Text = "Giảm >>";
            this.btnGiam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyCafe.Properties.Resources.increase;
            this.btnThem.Location = new System.Drawing.Point(730, 314);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 71);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm <<";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvChiTietNhapHang
            // 
            this.dgvChiTietNhapHang.AllowUserToResizeColumns = false;
            this.dgvChiTietNhapHang.AllowUserToResizeRows = false;
            this.dgvChiTietNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CTID,
            this.CTTenHang,
            this.CTSoLuong,
            this.CTDonGia,
            this.CTThanhTien,
            this.CTDVT});
            this.dgvChiTietNhapHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvChiTietNhapHang.Location = new System.Drawing.Point(21, 200);
            this.dgvChiTietNhapHang.MultiSelect = false;
            this.dgvChiTietNhapHang.Name = "dgvChiTietNhapHang";
            this.dgvChiTietNhapHang.ReadOnly = true;
            this.dgvChiTietNhapHang.RowHeadersVisible = false;
            this.dgvChiTietNhapHang.RowHeadersWidth = 51;
            this.dgvChiTietNhapHang.RowTemplate.Height = 24;
            this.dgvChiTietNhapHang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChiTietNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietNhapHang.Size = new System.Drawing.Size(686, 414);
            this.dgvChiTietNhapHang.TabIndex = 0;
            this.dgvChiTietNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietNhapHang_CellClick);
            this.dgvChiTietNhapHang.VisibleChanged += new System.EventHandler(this.dgvChiTietNhapHang_VisibleChanged);
            // 
            // CTID
            // 
            this.CTID.DataPropertyName = "IDHang";
            this.CTID.HeaderText = "ID";
            this.CTID.MinimumWidth = 6;
            this.CTID.Name = "CTID";
            this.CTID.ReadOnly = true;
            this.CTID.Width = 50;
            // 
            // CTTenHang
            // 
            this.CTTenHang.DataPropertyName = "TenHang";
            this.CTTenHang.HeaderText = "Tên nguyên liệu";
            this.CTTenHang.MinimumWidth = 6;
            this.CTTenHang.Name = "CTTenHang";
            this.CTTenHang.ReadOnly = true;
            this.CTTenHang.Width = 150;
            // 
            // CTSoLuong
            // 
            this.CTSoLuong.DataPropertyName = "SoLuong";
            this.CTSoLuong.HeaderText = "SL";
            this.CTSoLuong.MinimumWidth = 6;
            this.CTSoLuong.Name = "CTSoLuong";
            this.CTSoLuong.ReadOnly = true;
            this.CTSoLuong.Width = 70;
            // 
            // CTDonGia
            // 
            this.CTDonGia.DataPropertyName = "DonGia";
            this.CTDonGia.HeaderText = "Đơn giá";
            this.CTDonGia.MinimumWidth = 6;
            this.CTDonGia.Name = "CTDonGia";
            this.CTDonGia.ReadOnly = true;
            this.CTDonGia.Width = 80;
            // 
            // CTThanhTien
            // 
            this.CTThanhTien.DataPropertyName = "ThanhTien";
            this.CTThanhTien.HeaderText = "Thành tiền";
            this.CTThanhTien.MinimumWidth = 6;
            this.CTThanhTien.Name = "CTThanhTien";
            this.CTThanhTien.ReadOnly = true;
            this.CTThanhTien.Width = 80;
            // 
            // CTDVT
            // 
            this.CTDVT.DataPropertyName = "DonViTinh";
            this.CTDVT.HeaderText = "ĐVT";
            this.CTDVT.MinimumWidth = 6;
            this.CTDVT.Name = "CTDVT";
            this.CTDVT.ReadOnly = true;
            this.CTDVT.Width = 90;
            // 
            // grbKhoHang
            // 
            this.grbKhoHang.Controls.Add(this.dgvKhoHang);
            this.grbKhoHang.Location = new System.Drawing.Point(898, 12);
            this.grbKhoHang.Name = "grbKhoHang";
            this.grbKhoHang.Size = new System.Drawing.Size(590, 776);
            this.grbKhoHang.TabIndex = 2;
            this.grbKhoHang.TabStop = false;
            this.grbKhoHang.Text = "Nhóm kho hàng";
            // 
            // dgvKhoHang
            // 
            this.dgvKhoHang.AllowUserToResizeColumns = false;
            this.dgvKhoHang.AllowUserToResizeRows = false;
            this.dgvKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten,
            this.DonViTinh,
            this.soLuong,
            this.DonGia});
            this.dgvKhoHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvKhoHang.Location = new System.Drawing.Point(7, 22);
            this.dgvKhoHang.MultiSelect = false;
            this.dgvKhoHang.Name = "dgvKhoHang";
            this.dgvKhoHang.ReadOnly = true;
            this.dgvKhoHang.RowHeadersVisible = false;
            this.dgvKhoHang.RowHeadersWidth = 51;
            this.dgvKhoHang.RowTemplate.Height = 24;
            this.dgvKhoHang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKhoHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoHang.Size = new System.Drawing.Size(577, 748);
            this.dgvKhoHang.TabIndex = 0;
            this.dgvKhoHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoHang_CellClick);
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
            this.Ten.HeaderText = "Tên nguyên liệu";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 125;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "ĐVT";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Width = 80;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "SL";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 50;
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
            // btnIn
            // 
            this.btnIn.Image = global::QuanLyCafe.Properties.Resources.printer_icon_simple_style_3219886;
            this.btnIn.Location = new System.Drawing.Point(730, 661);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(129, 80);
            this.btnIn.TabIndex = 20;
            this.btnIn.Text = "In Hóa Đơn";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // FrmSuDungNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.ControlBox = false;
            this.Controls.Add(this.grbKhoHang);
            this.Controls.Add(this.grbChucNang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSuDungNhapHang";
            this.RightToLeftLayout = true;
            this.Text = "FrmSuDungNhapHang";
            this.Load += new System.EventHandler(this.FrmSuDungNhapHang_Load);
            this.grbChucNang.ResumeLayout(false);
            this.grbChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapHang)).EndInit();
            this.grbKhoHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.GroupBox grbKhoHang;
        private System.Windows.Forms.DataGridView dgvKhoHang;
        private System.Windows.Forms.DataGridView dgvChiTietNhapHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTDVT;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayTao;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Button btnIn;
    }
}