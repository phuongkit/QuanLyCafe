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
        DBaccess.ChiTietHoaDonNhapHangAccess CTHDNHAc;
        DBaccess.HoaDonBanHangAccess HDBHAc;
        DBaccess.HoaDonNhapHangAccess HDNHAc;
        DBaccess.NhanVienAccess NVAc;
        string connectionString = "";
        string soHD;
        string tenNhanVien;
        string tenBan;
        bool loaiHoaDon; // true: ban hang false: nhap hang
        //private static List<Stream> m_streams;
        //private static int m_currentPageIndex = 0;
        public FrmReport(string connectionString, string soHD, bool loaiHoaDon)
        {
            InitializeComponent();
            this.soHD = soHD;
            this.loaiHoaDon = loaiHoaDon;
            this.connectionString = connectionString;
            this.CTHDBHAc = new DBaccess.ChiTietHoaDonBanHangAccess(connectionString);
            this.CTHDNHAc = new DBaccess.ChiTietHoaDonNhapHangAccess(connectionString);
            this.HDBHAc = new DBaccess.HoaDonBanHangAccess(connectionString);
            this.HDNHAc = new DBaccess.HoaDonNhapHangAccess(connectionString);
            this.NVAc = new DBaccess.NhanVienAccess(connectionString);
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.RefreshReport();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.SetDisplayMode(DisplayMode.Normal);
                reportViewer1.ZoomPercent = 100;
                if (loaiHoaDon)
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCafe.Report.ReportHoaDonBanHang.rdlc";
                }
                else
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCafe.Report.ReportHoaDonNhapHang.rdlc";
                }

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                ReportParameter[] param;
                if (loaiHoaDon)
                {
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
                    param = new ReportParameter[] { pSoHD, pNhanVien, pBan, pTongGia, pNgayTao };
                }
                else
                {
                    reportDataSource.Value = HDNHAc.getChiTietHoaDonNhapHang(soHD);
                    MyDatabase.HoaDonNhapHang hd = HDNHAc.getHoaDonNhapHang(soHD);
                    tenNhanVien = NVAc.getNhanVien(hd.IDnhanVien).HoTen;
                    ReportParameter pSoHD = new ReportParameter("SoHD", soHD);
                    ReportParameter pNhanVien = new ReportParameter("NhanVien", tenNhanVien);
                    string tonggia = HDNHAc.getTienHoaDonNH(soHD).TongGia.ToString();
                    ReportParameter pTongGia = new ReportParameter("TongGia", tonggia);
                    ReportParameter pNgayTao = new ReportParameter("NgayTao", hd.NgayTao.ToString());
                    param = new ReportParameter[] { pSoHD, pNhanVien, pTongGia, pNgayTao };
                }
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
                string path, subject, message;
                if (loaiHoaDon)
                {
                    path = ExportReportToPDF(link + "\\EXportedReport\\", "HDBH-" + soHD);
                    subject = "Hóa đơn bán hàng với số HD = " + soHD + " vào lúc " + DateTime.Now.ToString();
                    message = "Hóa đơn bán hàng với số HD = " + soHD + " vào lúc " + DateTime.Now.ToString() + " do nhân viên " + tenNhanVien + " thanh toán ở bàn " + tenBan;
                }
                else
                {
                    path = ExportReportToPDF(link + "\\EXportedReport\\", "HDNH-" + soHD);
                    subject = "Hóa đơn nhập hàng với số HD = " + soHD + " vào lúc " + DateTime.Now.ToString();
                    message = "Hóa đơn nhập hàng với số HD = " + soHD + " vào lúc " + DateTime.Now.ToString() + " do nhân viên " + tenNhanVien + " thanh toán";
                }

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
            using (var fs = new FileStream(filename, System.IO.FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
            return filename;

        }

        private void FrmReport_Resize(object sender, EventArgs e)
        {
            if (!connectionString.Equals(""))
            {
                int width = this.Width, height = this.Height;
                reportViewer1.Width = width - 150;
                reportViewer1.Height = height - 10;
                reportViewer1.Location = new Point(0, 0);
                reportViewer1.Refresh();

                btnPrint.Width = 140;
                btnPrint.Height = 60;
                btnPrint.Location = new Point(width - 145, 10);
                this.Refresh();
            }
        }
    }
}
