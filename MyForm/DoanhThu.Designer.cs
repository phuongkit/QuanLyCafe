namespace QuanLyCafe.MyForm
{
    partial class DoanhThu
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
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.Date_from = new System.Windows.Forms.DateTimePicker();
            this.Date_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToResizeColumns = false;
            this.dgv_main.AllowUserToResizeRows = false;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(0, 172);
            this.dgv_main.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.RowHeadersWidth = 51;
            this.dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_main.Size = new System.Drawing.Size(1387, 480);
            this.dgv_main.TabIndex = 8;
            this.dgv_main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_main_CellDoubleClick);
            this.dgv_main.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_main_CellEnter);
            // 
            // Date_from
            // 
            this.Date_from.Location = new System.Drawing.Point(115, 90);
            this.Date_from.Margin = new System.Windows.Forms.Padding(4);
            this.Date_from.Name = "Date_from";
            this.Date_from.Size = new System.Drawing.Size(265, 22);
            this.Date_from.TabIndex = 9;
            this.Date_from.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // Date_to
            // 
            this.Date_to.Location = new System.Drawing.Point(115, 122);
            this.Date_to.Margin = new System.Windows.Forms.Padding(4);
            this.Date_to.Name = "Date_to";
            this.Date_to.Size = new System.Drawing.Size(265, 22);
            this.Date_to.TabIndex = 9;
            this.Date_to.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đến Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lọc";
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Image = global::QuanLyCafe.Properties.Resources.view_details_1_;
            this.btnXemChiTiet.Location = new System.Drawing.Point(426, 71);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(138, 75);
            this.btnXemChiTiet.TabIndex = 12;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::QuanLyCafe.Properties.Resources.printer_icon_simple_style_3219886;
            this.btnIn.Location = new System.Drawing.Point(595, 71);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(121, 73);
            this.btnIn.TabIndex = 20;
            this.btnIn.Text = "In Báo Cáo";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 654);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_to);
            this.Controls.Add(this.Date_from);
            this.Controls.Add(this.dgv_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoanhThu";
            this.Text = "KhoHang";
            this.VisibleChanged += new System.EventHandler(this.DoanhThu_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.DateTimePicker Date_from;
        private System.Windows.Forms.DateTimePicker Date_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnIn;
    }
}