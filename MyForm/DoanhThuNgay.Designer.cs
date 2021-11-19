namespace QuanLyCafe.MyForm
{
    partial class DoanhThuNgay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv_main = new System.Windows.Forms.DataGridView();
            this.btn_switch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_back = new System.Windows.Forms.Button();
            this.Date_NgayChitiet = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dgv_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 466);
            this.panel1.TabIndex = 0;
            // 
            // Dgv_main
            // 
            this.Dgv_main.AllowUserToResizeColumns = false;
            this.Dgv_main.AllowUserToResizeRows = false;
            this.Dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_main.Location = new System.Drawing.Point(0, 0);
            this.Dgv_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_main.Name = "Dgv_main";
            this.Dgv_main.ReadOnly = true;
            this.Dgv_main.RowHeadersWidth = 51;
            this.Dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_main.Size = new System.Drawing.Size(1067, 466);
            this.Dgv_main.TabIndex = 0;
            // 
            // btn_switch
            // 
            this.btn_switch.Location = new System.Drawing.Point(951, 52);
            this.btn_switch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(100, 28);
            this.btn_switch.TabIndex = 1;
            this.btn_switch.Text = "Nhập Hàng";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.Btn_switch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(841, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đổi danh sách";
            // 
            // Btn_back
            // 
            this.Btn_back.Location = new System.Drawing.Point(16, 52);
            this.Btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(100, 28);
            this.Btn_back.TabIndex = 3;
            this.Btn_back.Text = "Trở lại";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Visible = false;
            // 
            // Date_NgayChitiet
            // 
            this.Date_NgayChitiet.Location = new System.Drawing.Point(245, 52);
            this.Date_NgayChitiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Date_NgayChitiet.Name = "Date_NgayChitiet";
            this.Date_NgayChitiet.Size = new System.Drawing.Size(265, 22);
            this.Date_NgayChitiet.TabIndex = 4;
            // 
            // DoanhThuNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Date_NgayChitiet);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_switch);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoanhThuNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoanhThuNgay";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_main;
        private System.Windows.Forms.Button btn_switch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_back;
        public System.Windows.Forms.DateTimePicker Date_NgayChitiet;
    }
}