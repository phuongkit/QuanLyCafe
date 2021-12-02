
namespace QuanLyCafe.MyForm
{
    partial class BaoCao
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
            this.tabBieuDoDoanhThu = new System.Windows.Forms.TabPage();
            this.btnLoaiBDDT = new System.Windows.Forms.Button();
            this.btnInBDDT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date_ToBDDT = new System.Windows.Forms.DateTimePicker();
            this.date_FromBDDT = new System.Windows.Forms.DateTimePicker();
            this.reportViewerBDDT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.btnLoaiKhachHang = new System.Windows.Forms.Button();
            this.btnInKH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtNgayKhachHang = new System.Windows.Forms.DateTimePicker();
            this.reportViewerTopKH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabTopNhanVien = new System.Windows.Forms.TabPage();
            this.btnLoaiNhanVien = new System.Windows.Forms.Button();
            this.btnInNhanVien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayNhanVien = new System.Windows.Forms.DateTimePicker();
            this.reportViewerTopNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabTopThucDon = new System.Windows.Forms.TabPage();
            this.btnLoaiThucDon = new System.Windows.Forms.Button();
            this.btnInThucDon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNgayThucDon = new System.Windows.Forms.DateTimePicker();
            this.reportViewerTopTD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabBaoCao = new System.Windows.Forms.TabControl();
            this.tabBieuDoDoanhThu.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            this.tabTopNhanVien.SuspendLayout();
            this.tabTopThucDon.SuspendLayout();
            this.tabBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBieuDoDoanhThu
            // 
            this.tabBieuDoDoanhThu.Controls.Add(this.btnLoaiBDDT);
            this.tabBieuDoDoanhThu.Controls.Add(this.btnInBDDT);
            this.tabBieuDoDoanhThu.Controls.Add(this.label4);
            this.tabBieuDoDoanhThu.Controls.Add(this.label5);
            this.tabBieuDoDoanhThu.Controls.Add(this.label6);
            this.tabBieuDoDoanhThu.Controls.Add(this.date_ToBDDT);
            this.tabBieuDoDoanhThu.Controls.Add(this.date_FromBDDT);
            this.tabBieuDoDoanhThu.Controls.Add(this.reportViewerBDDT);
            this.tabBieuDoDoanhThu.Location = new System.Drawing.Point(4, 25);
            this.tabBieuDoDoanhThu.Name = "tabBieuDoDoanhThu";
            this.tabBieuDoDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabBieuDoDoanhThu.Size = new System.Drawing.Size(1467, 746);
            this.tabBieuDoDoanhThu.TabIndex = 1;
            this.tabBieuDoDoanhThu.Text = "Biểu đồ doanh thu";
            this.tabBieuDoDoanhThu.UseVisualStyleBackColor = true;
            // 
            // btnLoaiBDDT
            // 
            this.btnLoaiBDDT.Location = new System.Drawing.Point(619, 23);
            this.btnLoaiBDDT.Name = "btnLoaiBDDT";
            this.btnLoaiBDDT.Size = new System.Drawing.Size(119, 73);
            this.btnLoaiBDDT.TabIndex = 32;
            this.btnLoaiBDDT.Text = "Ngày";
            this.btnLoaiBDDT.UseVisualStyleBackColor = true;
            this.btnLoaiBDDT.Click += new System.EventHandler(this.btnLoai_Click);
            // 
            // btnInBDDT
            // 
            this.btnInBDDT.Image = global::QuanLyCafe.Properties.Resources.printer_icon_simple_style_3219886;
            this.btnInBDDT.Location = new System.Drawing.Point(438, 21);
            this.btnInBDDT.Name = "btnInBDDT";
            this.btnInBDDT.Size = new System.Drawing.Size(137, 73);
            this.btnInBDDT.TabIndex = 31;
            this.btnInBDDT.Text = "In Báo Cáo";
            this.btnInBDDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInBDDT.UseVisualStyleBackColor = true;
            this.btnInBDDT.Click += new System.EventHandler(this.btnInBDDT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Lọc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Đến Ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Từ Ngày";
            // 
            // date_ToBDDT
            // 
            this.date_ToBDDT.Location = new System.Drawing.Point(118, 72);
            this.date_ToBDDT.Margin = new System.Windows.Forms.Padding(4);
            this.date_ToBDDT.Name = "date_ToBDDT";
            this.date_ToBDDT.Size = new System.Drawing.Size(265, 22);
            this.date_ToBDDT.TabIndex = 25;
            this.date_ToBDDT.ValueChanged += new System.EventHandler(this.date_ToBDDT_ValueChanged);
            // 
            // date_FromBDDT
            // 
            this.date_FromBDDT.Location = new System.Drawing.Point(118, 40);
            this.date_FromBDDT.Margin = new System.Windows.Forms.Padding(4);
            this.date_FromBDDT.Name = "date_FromBDDT";
            this.date_FromBDDT.Size = new System.Drawing.Size(265, 22);
            this.date_FromBDDT.TabIndex = 26;
            this.date_FromBDDT.ValueChanged += new System.EventHandler(this.date_FromBDDT_ValueChanged);
            // 
            // reportViewerBDDT
            // 
            this.reportViewerBDDT.Location = new System.Drawing.Point(18, 118);
            this.reportViewerBDDT.Name = "reportViewerBDDT";
            this.reportViewerBDDT.ServerReport.BearerToken = null;
            this.reportViewerBDDT.Size = new System.Drawing.Size(1340, 611);
            this.reportViewerBDDT.TabIndex = 24;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.btnLoaiKhachHang);
            this.tabKhachHang.Controls.Add(this.btnInKH);
            this.tabKhachHang.Controls.Add(this.label3);
            this.tabKhachHang.Controls.Add(this.label9);
            this.tabKhachHang.Controls.Add(this.dtNgayKhachHang);
            this.tabKhachHang.Controls.Add(this.reportViewerTopKH);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 25);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhachHang.Size = new System.Drawing.Size(1467, 746);
            this.tabKhachHang.TabIndex = 5;
            this.tabKhachHang.Text = "Top khách hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnLoaiKhachHang
            // 
            this.btnLoaiKhachHang.Location = new System.Drawing.Point(682, 2);
            this.btnLoaiKhachHang.Name = "btnLoaiKhachHang";
            this.btnLoaiKhachHang.Size = new System.Drawing.Size(119, 73);
            this.btnLoaiKhachHang.TabIndex = 36;
            this.btnLoaiKhachHang.Text = "Ngày";
            this.btnLoaiKhachHang.UseVisualStyleBackColor = true;
            this.btnLoaiKhachHang.Click += new System.EventHandler(this.btnLoaiKH_Click);
            // 
            // btnInKH
            // 
            this.btnInKH.Image = global::QuanLyCafe.Properties.Resources.printer_icon_simple_style_3219886;
            this.btnInKH.Location = new System.Drawing.Point(525, 2);
            this.btnInKH.Name = "btnInKH";
            this.btnInKH.Size = new System.Drawing.Size(137, 73);
            this.btnInKH.TabIndex = 35;
            this.btnInKH.Text = "In Báo Cáo";
            this.btnInKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInKH.UseVisualStyleBackColor = true;
            this.btnInKH.Click += new System.EventHandler(this.btnInKH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Lọc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Ngày:";
            // 
            // dtNgayKhachHang
            // 
            this.dtNgayKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKhachHang.Location = new System.Drawing.Point(100, 42);
            this.dtNgayKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayKhachHang.Name = "dtNgayKhachHang";
            this.dtNgayKhachHang.Size = new System.Drawing.Size(369, 27);
            this.dtNgayKhachHang.TabIndex = 32;
            this.dtNgayKhachHang.ValueChanged += new System.EventHandler(this.dtNgayKhachHang_ValueChanged);
            // 
            // reportViewerTopKH
            // 
            this.reportViewerTopKH.Location = new System.Drawing.Point(6, 103);
            this.reportViewerTopKH.Name = "reportViewerTopKH";
            this.reportViewerTopKH.ServerReport.BearerToken = null;
            this.reportViewerTopKH.Size = new System.Drawing.Size(1340, 637);
            this.reportViewerTopKH.TabIndex = 31;
            // 
            // tabTopNhanVien
            // 
            this.tabTopNhanVien.Controls.Add(this.btnLoaiNhanVien);
            this.tabTopNhanVien.Controls.Add(this.btnInNhanVien);
            this.tabTopNhanVien.Controls.Add(this.label1);
            this.tabTopNhanVien.Controls.Add(this.label2);
            this.tabTopNhanVien.Controls.Add(this.dtNgayNhanVien);
            this.tabTopNhanVien.Controls.Add(this.reportViewerTopNV);
            this.tabTopNhanVien.Location = new System.Drawing.Point(4, 25);
            this.tabTopNhanVien.Name = "tabTopNhanVien";
            this.tabTopNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabTopNhanVien.Size = new System.Drawing.Size(1467, 746);
            this.tabTopNhanVien.TabIndex = 4;
            this.tabTopNhanVien.Text = "Top nhân viên";
            this.tabTopNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnLoaiNhanVien
            // 
            this.btnLoaiNhanVien.Location = new System.Drawing.Point(693, 12);
            this.btnLoaiNhanVien.Name = "btnLoaiNhanVien";
            this.btnLoaiNhanVien.Size = new System.Drawing.Size(119, 73);
            this.btnLoaiNhanVien.TabIndex = 36;
            this.btnLoaiNhanVien.Text = "Ngày";
            this.btnLoaiNhanVien.UseVisualStyleBackColor = true;
            this.btnLoaiNhanVien.Click += new System.EventHandler(this.btnLoaiNhanVien_Click);
            // 
            // btnInNhanVien
            // 
            this.btnInNhanVien.Image = global::QuanLyCafe.Properties.Resources.printer_icon_simple_style_3219886;
            this.btnInNhanVien.Location = new System.Drawing.Point(536, 12);
            this.btnInNhanVien.Name = "btnInNhanVien";
            this.btnInNhanVien.Size = new System.Drawing.Size(137, 73);
            this.btnInNhanVien.TabIndex = 35;
            this.btnInNhanVien.Text = "In Báo Cáo";
            this.btnInNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInNhanVien.UseVisualStyleBackColor = true;
            this.btnInNhanVien.Click += new System.EventHandler(this.btnInNhanVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Lọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ngày:";
            // 
            // dtNgayNhanVien
            // 
            this.dtNgayNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayNhanVien.Location = new System.Drawing.Point(111, 52);
            this.dtNgayNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayNhanVien.Name = "dtNgayNhanVien";
            this.dtNgayNhanVien.Size = new System.Drawing.Size(369, 27);
            this.dtNgayNhanVien.TabIndex = 32;
            this.dtNgayNhanVien.ValueChanged += new System.EventHandler(this.dtNgayNhanVien_ValueChanged);
            // 
            // reportViewerTopNV
            // 
            this.reportViewerTopNV.Location = new System.Drawing.Point(17, 113);
            this.reportViewerTopNV.Name = "reportViewerTopNV";
            this.reportViewerTopNV.ServerReport.BearerToken = null;
            this.reportViewerTopNV.Size = new System.Drawing.Size(1340, 637);
            this.reportViewerTopNV.TabIndex = 31;
            // 
            // tabTopThucDon
            // 
            this.tabTopThucDon.Controls.Add(this.btnLoaiThucDon);
            this.tabTopThucDon.Controls.Add(this.btnInThucDon);
            this.tabTopThucDon.Controls.Add(this.label7);
            this.tabTopThucDon.Controls.Add(this.label8);
            this.tabTopThucDon.Controls.Add(this.dtNgayThucDon);
            this.tabTopThucDon.Controls.Add(this.reportViewerTopTD);
            this.tabTopThucDon.Location = new System.Drawing.Point(4, 25);
            this.tabTopThucDon.Name = "tabTopThucDon";
            this.tabTopThucDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabTopThucDon.Size = new System.Drawing.Size(1467, 746);
            this.tabTopThucDon.TabIndex = 3;
            this.tabTopThucDon.Text = "Top thực đơn";
            this.tabTopThucDon.UseVisualStyleBackColor = true;
            // 
            // btnLoaiThucDon
            // 
            this.btnLoaiThucDon.Location = new System.Drawing.Point(682, 8);
            this.btnLoaiThucDon.Name = "btnLoaiThucDon";
            this.btnLoaiThucDon.Size = new System.Drawing.Size(119, 73);
            this.btnLoaiThucDon.TabIndex = 30;
            this.btnLoaiThucDon.Text = "Ngày";
            this.btnLoaiThucDon.UseVisualStyleBackColor = true;
            this.btnLoaiThucDon.Click += new System.EventHandler(this.btnLoaiThucDon_Click);
            // 
            // btnInThucDon
            // 
            this.btnInThucDon.Image = global::QuanLyCafe.Properties.Resources.printer_icon_simple_style_3219886;
            this.btnInThucDon.Location = new System.Drawing.Point(525, 8);
            this.btnInThucDon.Name = "btnInThucDon";
            this.btnInThucDon.Size = new System.Drawing.Size(137, 73);
            this.btnInThucDon.TabIndex = 29;
            this.btnInThucDon.Text = "In Báo Cáo";
            this.btnInThucDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInThucDon.UseVisualStyleBackColor = true;
            this.btnInThucDon.Click += new System.EventHandler(this.btnInThucDon_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Lọc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ngày:";
            // 
            // dtNgayThucDon
            // 
            this.dtNgayThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThucDon.Location = new System.Drawing.Point(100, 48);
            this.dtNgayThucDon.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayThucDon.Name = "dtNgayThucDon";
            this.dtNgayThucDon.Size = new System.Drawing.Size(369, 27);
            this.dtNgayThucDon.TabIndex = 25;
            this.dtNgayThucDon.ValueChanged += new System.EventHandler(this.dtNgayThucDon_ValueChanged);
            // 
            // reportViewerTopTD
            // 
            this.reportViewerTopTD.Location = new System.Drawing.Point(6, 109);
            this.reportViewerTopTD.Name = "reportViewerTopTD";
            this.reportViewerTopTD.ServerReport.BearerToken = null;
            this.reportViewerTopTD.Size = new System.Drawing.Size(1340, 637);
            this.reportViewerTopTD.TabIndex = 24;
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Controls.Add(this.tabBieuDoDoanhThu);
            this.tabBaoCao.Controls.Add(this.tabTopThucDon);
            this.tabBaoCao.Controls.Add(this.tabTopNhanVien);
            this.tabBaoCao.Controls.Add(this.tabKhachHang);
            this.tabBaoCao.Location = new System.Drawing.Point(13, 13);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.SelectedIndex = 0;
            this.tabBaoCao.Size = new System.Drawing.Size(1475, 775);
            this.tabBaoCao.TabIndex = 0;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.tabBaoCao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaoCao";
            this.Text = "BaoCao";
            this.tabBieuDoDoanhThu.ResumeLayout(false);
            this.tabBieuDoDoanhThu.PerformLayout();
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            this.tabTopNhanVien.ResumeLayout(false);
            this.tabTopNhanVien.PerformLayout();
            this.tabTopThucDon.ResumeLayout(false);
            this.tabTopThucDon.PerformLayout();
            this.tabBaoCao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabBieuDoDoanhThu;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.TabPage tabTopNhanVien;
        private System.Windows.Forms.TabPage tabTopThucDon;
        private System.Windows.Forms.TabControl tabBaoCao;
        private System.Windows.Forms.Button btnLoaiBDDT;
        private System.Windows.Forms.Button btnInBDDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_ToBDDT;
        private System.Windows.Forms.DateTimePicker date_FromBDDT;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBDDT;
        private System.Windows.Forms.Button btnLoaiThucDon;
        private System.Windows.Forms.Button btnInThucDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtNgayThucDon;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTopTD;
        private System.Windows.Forms.Button btnLoaiKhachHang;
        private System.Windows.Forms.Button btnInKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtNgayKhachHang;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTopKH;
        private System.Windows.Forms.Button btnLoaiNhanVien;
        private System.Windows.Forms.Button btnInNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayNhanVien;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTopNV;
    }
}