
namespace QuanLyCafe
{
    partial class FrmManHinhChinhNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManHinhChinhNhanVien));
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.grbCongCu = new System.Windows.Forms.GroupBox();
            this.btnThanhVien = new System.Windows.Forms.Button();
            this.btnSuDungDichVu = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTaiKhoanCuaToi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbCongCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbChucNang
            // 
            this.grbChucNang.Location = new System.Drawing.Point(167, 1);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(1500, 800);
            this.grbChucNang.TabIndex = 12;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Nhóm chức năng";
            // 
            // grbCongCu
            // 
            this.grbCongCu.Controls.Add(this.btnThanhVien);
            this.grbCongCu.Controls.Add(this.btnSuDungDichVu);
            this.grbCongCu.Controls.Add(this.btnNhapHang);
            this.grbCongCu.Controls.Add(this.btnExit);
            this.grbCongCu.Controls.Add(this.btnTaiKhoanCuaToi);
            this.grbCongCu.Controls.Add(this.pictureBox1);
            this.grbCongCu.Location = new System.Drawing.Point(4, 1);
            this.grbCongCu.Name = "grbCongCu";
            this.grbCongCu.Size = new System.Drawing.Size(157, 800);
            this.grbCongCu.TabIndex = 11;
            this.grbCongCu.TabStop = false;
            this.grbCongCu.Text = "Nhóm công cụ";
            // 
            // btnThanhVien
            // 
            this.btnThanhVien.BackColor = System.Drawing.Color.White;
            this.btnThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhVien.Location = new System.Drawing.Point(2, 234);
            this.btnThanhVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhVien.Name = "btnThanhVien";
            this.btnThanhVien.Size = new System.Drawing.Size(155, 49);
            this.btnThanhVien.TabIndex = 13;
            this.btnThanhVien.Text = "Khách hàng";
            this.btnThanhVien.UseVisualStyleBackColor = false;
            this.btnThanhVien.Click += new System.EventHandler(this.btnThanhVien_Click);
            // 
            // btnSuDungDichVu
            // 
            this.btnSuDungDichVu.BackColor = System.Drawing.Color.White;
            this.btnSuDungDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuDungDichVu.Location = new System.Drawing.Point(0, 291);
            this.btnSuDungDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuDungDichVu.Name = "btnSuDungDichVu";
            this.btnSuDungDichVu.Size = new System.Drawing.Size(155, 49);
            this.btnSuDungDichVu.TabIndex = 12;
            this.btnSuDungDichVu.Text = "Sử dụng dịch vụ";
            this.btnSuDungDichVu.UseVisualStyleBackColor = false;
            this.btnSuDungDichVu.Click += new System.EventHandler(this.btnSuDungDichVu_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.White;
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.Location = new System.Drawing.Point(0, 348);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(155, 49);
            this.btnNhapHang.TabIndex = 11;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Blue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1, 744);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTaiKhoanCuaToi
            // 
            this.btnTaiKhoanCuaToi.BackColor = System.Drawing.Color.White;
            this.btnTaiKhoanCuaToi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoanCuaToi.Location = new System.Drawing.Point(1, 177);
            this.btnTaiKhoanCuaToi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaiKhoanCuaToi.Name = "btnTaiKhoanCuaToi";
            this.btnTaiKhoanCuaToi.Size = new System.Drawing.Size(155, 49);
            this.btnTaiKhoanCuaToi.TabIndex = 6;
            this.btnTaiKhoanCuaToi.Text = "Tài khoản của tôi";
            this.btnTaiKhoanCuaToi.UseVisualStyleBackColor = false;
            this.btnTaiKhoanCuaToi.Click += new System.EventHandler(this.btnTaiKhoanCuaToi_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 143);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmManHinhChinhNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1671, 803);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbCongCu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmManHinhChinhNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê (Nhân viên)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManHinhChinhNhanVien_FormClosing);
            this.grbCongCu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.GroupBox grbCongCu;
        private System.Windows.Forms.Button btnTaiKhoanCuaToi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSuDungDichVu;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnThanhVien;
    }
}

