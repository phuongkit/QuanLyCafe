namespace QuanLyCafe.MyForm
{
    partial class FrmKhoHang
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_mathang = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.txt_donvi = new System.Windows.Forms.TextBox();
            this.lb_donvithem = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Image = global::QuanLyCafe.Properties.Resources.save__1_;
            this.btn_ok.Location = new System.Drawing.Point(456, 714);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(124, 61);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "Lưu";
            this.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = global::QuanLyCafe.Properties.Resources.edit_add;
            this.btn_sua.Location = new System.Drawing.Point(313, 714);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(124, 61);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.Btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::QuanLyCafe.Properties.Resources.edit_add;
            this.btn_them.Location = new System.Drawing.Point(13, 714);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(124, 61);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.Btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::QuanLyCafe.Properties.Resources.edit_delete;
            this.btn_xoa.Location = new System.Drawing.Point(163, 714);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(124, 61);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.Btn_xoa_Click);
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToResizeColumns = false;
            this.dgv_main.AllowUserToResizeRows = false;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten,
            this.DonViTinh,
            this.soLuong,
            this.DonGia});
            this.dgv_main.Location = new System.Drawing.Point(0, 172);
            this.dgv_main.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.RowHeadersWidth = 51;
            this.dgv_main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_main.Size = new System.Drawing.Size(1349, 521);
            this.dgv_main.TabIndex = 8;
            this.dgv_main.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_main_CellEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên nguyên liệu";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 250;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Width = 180;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 200;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 200;
            // 
            // txt_mathang
            // 
            this.txt_mathang.Enabled = false;
            this.txt_mathang.Location = new System.Drawing.Point(199, 103);
            this.txt_mathang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mathang.Name = "txt_mathang";
            this.txt_mathang.Size = new System.Drawing.Size(132, 22);
            this.txt_mathang.TabIndex = 9;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Enabled = false;
            this.txt_soluong.Location = new System.Drawing.Point(528, 53);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(132, 22);
            this.txt_soluong.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mặt Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số Lượng";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(43, 53);
            this.lb_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(21, 17);
            this.lb_id.TabIndex = 12;
            this.lb_id.Text = "ID";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Location = new System.Drawing.Point(864, 96);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(132, 22);
            this.txt_dongia.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đơn Giá";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(199, 53);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(132, 22);
            this.txt_id.TabIndex = 13;
            // 
            // btn_huy
            // 
            this.btn_huy.Image = global::QuanLyCafe.Properties.Resources.cancel;
            this.btn_huy.Location = new System.Drawing.Point(617, 714);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(124, 61);
            this.btn_huy.TabIndex = 4;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.Btn_huy_Click);
            // 
            // txt_donvi
            // 
            this.txt_donvi.Location = new System.Drawing.Point(528, 101);
            this.txt_donvi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_donvi.Name = "txt_donvi";
            this.txt_donvi.Size = new System.Drawing.Size(132, 22);
            this.txt_donvi.TabIndex = 14;
            // 
            // lb_donvithem
            // 
            this.lb_donvithem.AutoSize = true;
            this.lb_donvithem.Location = new System.Drawing.Point(443, 106);
            this.lb_donvithem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_donvithem.Name = "lb_donvithem";
            this.lb_donvithem.Size = new System.Drawing.Size(48, 17);
            this.lb_donvithem.TabIndex = 15;
            this.lb_donvithem.Text = "Đơn vị";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = global::QuanLyCafe.Properties.Resources.icons8_export_excel_48;
            this.btnExportExcel.Location = new System.Drawing.Point(778, 714);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(138, 61);
            this.btnExportExcel.TabIndex = 28;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // FrmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 985);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.lb_donvithem);
            this.Controls.Add(this.txt_donvi);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_mathang);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKhoHang";
            this.Text = "FrmKhoHang";
            this.VisibleChanged += new System.EventHandler(this.FrmKhoHang_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.TextBox txt_mathang;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.TextBox txt_donvi;
        private System.Windows.Forms.Label lb_donvithem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Button btnExportExcel;
    }
}