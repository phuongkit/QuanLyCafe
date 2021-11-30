
namespace QuanLyCafe.MyForm
{
    partial class BaoCaoBieuDoDoanhThu
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Date_to = new System.Windows.Forms.DateTimePicker();
            this.Date_from = new System.Windows.Forms.DateTimePicker();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 112);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1458, 629);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Lọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Đến Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Từ Ngày";
            // 
            // Date_to
            // 
            this.Date_to.Location = new System.Drawing.Point(112, 66);
            this.Date_to.Margin = new System.Windows.Forms.Padding(4);
            this.Date_to.Name = "Date_to";
            this.Date_to.Size = new System.Drawing.Size(265, 22);
            this.Date_to.TabIndex = 12;
            this.Date_to.ValueChanged += new System.EventHandler(this.Date_to_ValueChanged);
            // 
            // Date_from
            // 
            this.Date_from.Location = new System.Drawing.Point(112, 34);
            this.Date_from.Margin = new System.Windows.Forms.Padding(4);
            this.Date_from.Name = "Date_from";
            this.Date_from.Size = new System.Drawing.Size(265, 22);
            this.Date_from.TabIndex = 13;
            this.Date_from.ValueChanged += new System.EventHandler(this.Date_from_ValueChanged);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::QuanLyCafe.Properties.Resources.printer_icon_simple_style_3219886;
            this.btnIn.Location = new System.Drawing.Point(580, 15);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(137, 73);
            this.btnIn.TabIndex = 22;
            this.btnIn.Text = "In Báo Cáo";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Image = global::QuanLyCafe.Properties.Resources.view_details_1_;
            this.btnXemChiTiet.Location = new System.Drawing.Point(411, 15);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(138, 75);
            this.btnXemChiTiet.TabIndex = 21;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // BaoCaoBieuDoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_to);
            this.Controls.Add(this.Date_from);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BaoCaoBieuDoDoanhThu";
            this.Text = "BaoCaoBieuDoDoanhThu";
            this.Load += new System.EventHandler(this.BaoCaoBieuDoDoanhThu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Date_to;
        private System.Windows.Forms.DateTimePicker Date_from;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXemChiTiet;
    }
}