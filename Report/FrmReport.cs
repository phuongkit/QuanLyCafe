using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Drawing.Imaging;
//using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace QuanLyCafe.Report
{
    public partial class FrmReport : Form
    {
        DBaccess.ChiTietHoaDonBanHangAccess CTHDBHAc;
        DBaccess.HoaDonBanHangAccess HDBHAc;
        DBaccess.HoaDonNhapHangAccess HDNHAc;
        DBaccess.NhanVienAccess NVAc;
        string connectionString;
        string soHD;
        string tenNhanVien;
        string tenBan;
        //private static List<Stream> m_streams;
        //private static int m_currentPageIndex = 0;
        public FrmReport(string connectionString, string soHD)
        {
            this.soHD = soHD;
            this.connectionString = connectionString;
            this.CTHDBHAc = new DBaccess.ChiTietHoaDonBanHangAccess(connectionString);
            this.HDBHAc = new DBaccess.HoaDonBanHangAccess(connectionString);
            this.HDNHAc = new DBaccess.HoaDonNhapHangAccess(connectionString);
            this.NVAc = new DBaccess.NhanVienAccess(connectionString);
            InitializeComponent();
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
                tenNhanVien = NVAc.getNhanVien(hd.IDnhanVien).HoTen;
                tenBan = hd.IDban;
                ReportParameter pSoHD = new ReportParameter("SoHD", soHD);
                ReportParameter pNhanVien = new ReportParameter("NhanVien", tenNhanVien);
                ReportParameter pBan = new ReportParameter("Ban", tenBan);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintToPrinter(reportViewer1.LocalReport);
        }
        public void PrintToPrinter(LocalReport report)
        {
            //Export(report);
            try
            {
                string link = Application.StartupPath;
                link = link.Substring(0, link.Length - 10);
                string path = ExportReportToPDF(link + "\\EXportedReport\\", "HDBH-" + soHD);
                string subject = "Hóa đơn bán hàng với số HD = " + soHD + " vào lúc " + DateTime.Now.ToString();
                string message = "Hóa đơn bán hàng với số HD = " + soHD + " vào lúc " + DateTime.Now.ToString() + " do nhân viên " + tenNhanVien + " thanh toán ở bàn " + tenBan;

                InputMesseageBox frmIMB = new InputMesseageBox(subject, message, path);
                frmIMB.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Generate repord in a path
        private string ExportReportToPDF(string path, string reportName)
        {
            string mimeType = "";
            string encoding = "";
            string filenameExtension = "";
            string[] streamids = null;
            Warning[] warnings = null;

            byte[] bytes = reportViewer1.LocalReport.Render(format: "WORD", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);
            string filename = Path.Combine(path + reportName + "." + filenameExtension);
            using (var fs = new System.IO.FileStream(filename, System.IO.FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
            return filename;

        }
    }
}
