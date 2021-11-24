using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyCafe.Report
{
    public partial class FrmReport : Form
    {
        DBaccess.ChiTietHoaDonBanHangAccess CTHDBHAc;
        DBaccess.HoaDonBanHangAccess HDBHAc;
        DBaccess.HoaDonNhapHangAccess HDNHAc;
        string connectionString;
        string soHD;
        public FrmReport(string connectionString, string soHD)
        {
            this.soHD = soHD;
            this.connectionString = connectionString;
            this.CTHDBHAc = new DBaccess.ChiTietHoaDonBanHangAccess(connectionString);
            this.HDBHAc = new DBaccess.HoaDonBanHangAccess(connectionString);
            this.HDNHAc = new DBaccess.HoaDonNhapHangAccess(connectionString);
            InitializeComponent();
            //reportViewer1.Show();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.RefreshReport();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCafe.Report.ReportHoaDonBanHang.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = HDBHAc.getChiTietHoaDonBanHang(soHD);
                MyDatabase.HoaDonBanHang hd = HDBHAc.getHoaDonBanHang(soHD);
                ReportParameter pSoHD = new ReportParameter("SoHD", soHD);
                ReportParameter pNhanVien = new ReportParameter("NhanVien", hd.IDnhanVien);
                ReportParameter pBan = new ReportParameter("Ban", hd.IDban);
                string tonggia = HDBHAc.getTienHoaDonBH(soHD).TongGia.ToString();
                ReportParameter pTongGia = new ReportParameter("TongGia", tonggia);
                ReportParameter pNgayTao = new ReportParameter("NgayTao", hd.Ngaytao.ToString());
                ReportParameter[] param = { pSoHD, pNhanVien, pBan, pTongGia, pNgayTao };
                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                //reportViewer1.Show();
                reportViewer1.RefreshReport();
                //reportViewer1.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
