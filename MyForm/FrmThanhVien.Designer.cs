
namespace QuanLyCafe.MyForm
{
    partial class FrmThanhVien
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhatThanhVien = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtIDNhanVien = new System.Windows.Forms.TextBox();
            this.dtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTaoThanhVien = new System.Windows.Forms.Button();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.grThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDNhanVien = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.grThongTinKhachHang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyCafe.Properties.Resources.edit_delete;
            this.btnXoa.Location = new System.Drawing.Point(494, 644);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 87);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhatThanhVien
            // 
            this.btnCapNhatThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatThanhVien.Image = global::QuanLyCafe.Properties.Resources.pencil;
            this.btnCapNhatThanhVien.Location = new System.Drawing.Point(125, 644);
            this.btnCapNhatThanhVien.Name = "btnCapNhatThanhVien";
            this.btnCapNhatThanhVien.Size = new System.Drawing.Size(127, 87);
            this.btnCapNhatThanhVien.TabIndex = 13;
            this.btnCapNhatThanhVien.Text = "Cập nhật";
            this.btnCapNhatThanhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhatThanhVien.UseVisualStyleBackColor = true;
            this.btnCapNhatThanhVien.Click += new System.EventHandler(this.btnCapNhatThanhVien_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(201, 218);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(187, 26);
            this.txtSDT.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(201, 142);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(205, 26);
            this.txtHoTen.TabIndex = 9;
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNhanVien.Location = new System.Drawing.Point(201, 50);
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.Size = new System.Drawing.Size(127, 26);
            this.txtIDNhanVien.TabIndex = 8;
            // 
            // dtNgayTao
            // 
            this.dtNgayTao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayTao.Location = new System.Drawing.Point(201, 522);
            this.dtNgayTao.Name = "dtNgayTao";
            this.dtNgayTao.Size = new System.Drawing.Size(275, 22);
            this.dtNgayTao.TabIndex = 5;
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.Location = new System.Drawing.Point(29, 298);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(56, 20);
            this.lblQuyen.TabIndex = 4;
            this.lblQuyen.Text = "Email:";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToResizeColumns = false;
            this.dgvKhachHang.AllowUserToResizeRows = false;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HoTen,
            this.SDT,
            this.Email,
            this.CMND,
            this.DiaChi,
            this.NgayTao});
            this.dgvKhachHang.Location = new System.Drawing.Point(24, 36);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(710, 717);
            this.dgvKhachHang.TabIndex = 32;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
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
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 90;
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
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            this.CMND.Width = 70;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 125;
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayTao";
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.MinimumWidth = 6;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            this.NgayTao.Width = 70;
            // 
            // btnTaoThanhVien
            // 
            this.btnTaoThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoThanhVien.Image = global::QuanLyCafe.Properties.Resources.edit_add;
            this.btnTaoThanhVien.Location = new System.Drawing.Point(6, 644);
            this.btnTaoThanhVien.Name = "btnTaoThanhVien";
            this.btnTaoThanhVien.Size = new System.Drawing.Size(113, 87);
            this.btnTaoThanhVien.TabIndex = 11;
            this.btnTaoThanhVien.Text = "Thêm";
            this.btnTaoThanhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoThanhVien.UseVisualStyleBackColor = true;
            this.btnTaoThanhVien.Click += new System.EventHandler(this.btnTaoThanhVien_Click);
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTao.Location = new System.Drawing.Point(29, 522);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(80, 20);
            this.lblNgayTao.TabIndex = 3;
            this.lblNgayTao.Text = "Ngày tạo:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(29, 218);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Số điện thoại:";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginName.Location = new System.Drawing.Point(29, 145);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(86, 20);
            this.lblLoginName.TabIndex = 0;
            this.lblLoginName.Text = "Họ và tên:";
            // 
            // grThongTinKhachHang
            // 
            this.grThongTinKhachHang.Controls.Add(this.btnBoQua);
            this.grThongTinKhachHang.Controls.Add(this.btnLuu);
            this.grThongTinKhachHang.Controls.Add(this.txtEmail);
            this.grThongTinKhachHang.Controls.Add(this.txtDiaChi);
            this.grThongTinKhachHang.Controls.Add(this.txtCMND);
            this.grThongTinKhachHang.Controls.Add(this.label2);
            this.grThongTinKhachHang.Controls.Add(this.label1);
            this.grThongTinKhachHang.Controls.Add(this.btnXoa);
            this.grThongTinKhachHang.Controls.Add(this.btnCapNhatThanhVien);
            this.grThongTinKhachHang.Controls.Add(this.btnTaoThanhVien);
            this.grThongTinKhachHang.Controls.Add(this.txtSDT);
            this.grThongTinKhachHang.Controls.Add(this.txtHoTen);
            this.grThongTinKhachHang.Controls.Add(this.txtIDNhanVien);
            this.grThongTinKhachHang.Controls.Add(this.dtNgayTao);
            this.grThongTinKhachHang.Controls.Add(this.lblQuyen);
            this.grThongTinKhachHang.Controls.Add(this.lblNgayTao);
            this.grThongTinKhachHang.Controls.Add(this.lblPassword);
            this.grThongTinKhachHang.Controls.Add(this.lblDNhanVien);
            this.grThongTinKhachHang.Controls.Add(this.lblLoginName);
            this.grThongTinKhachHang.Location = new System.Drawing.Point(785, 12);
            this.grThongTinKhachHang.Name = "grThongTinKhachHang";
            this.grThongTinKhachHang.Size = new System.Drawing.Size(703, 776);
            this.grThongTinKhachHang.TabIndex = 4;
            this.grThongTinKhachHang.TabStop = false;
            this.grThongTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyCafe.Properties.Resources.save;
            this.btnLuu.Location = new System.Drawing.Point(258, 644);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 87);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(201, 298);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(303, 26);
            this.txtEmail.TabIndex = 23;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(201, 444);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(422, 26);
            this.txtDiaChi.TabIndex = 22;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(201, 371);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(187, 26);
            this.txtCMND.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "CMND:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Địa chỉ:";
            // 
            // lblDNhanVien
            // 
            this.lblDNhanVien.AutoSize = true;
            this.lblDNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNhanVien.Location = new System.Drawing.Point(29, 56);
            this.lblDNhanVien.Name = "lblDNhanVien";
            this.lblDNhanVien.Size = new System.Drawing.Size(31, 20);
            this.lblDNhanVien.TabIndex = 1;
            this.lblDNhanVien.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvKhachHang);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 776);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 776);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Image = global::QuanLyCafe.Properties.Resources.pencil;
            this.btnBoQua.Location = new System.Drawing.Point(373, 644);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(115, 87);
            this.btnBoQua.TabIndex = 25;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // FrmThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.ControlBox = false;
            this.Controls.Add(this.grThongTinKhachHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThanhVien";
            this.Text = "FrmThanhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.grThongTinKhachHang.ResumeLayout(false);
            this.grThongTinKhachHang.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhatThanhVien;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtIDNhanVien;
        private System.Windows.Forms.DateTimePicker dtNgayTao;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.Button btnTaoThanhVien;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.GroupBox grThongTinKhachHang;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoQua;
    }
}