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
using System.IO;

namespace QuanLyCafe.MyForm
{
    public partial class BaoCao : Form
    {
        private DBaccess.DoanhThuAccess DTAc;
        private string connectionString;
        private FrmManHinhChinhAdmin frmMHC;
        private bool loaiBDDT;  //true ngay, false thang
        private int loaiTopTD;
        private int loaiTopNV;
        private int loaiTopTV;
        public BaoCao(FrmManHinhChinhAdmin frmMHC, string connectionString)
        {
            loaiTopTD = 0;
            loaiTopNV = 0;
            loaiTopTV = 0;
            loaiBDDT = true;
            this.connectionString = connectionString;
            this.frmMHC = frmMHC;
            DTAc = new DBaccess.DoanhThuAccess(connectionString);
            InitializeComponent();
            DataBindBDDT();
            DataBindTopTD();
            DataBindTopNV();
            DataBindTopKH();
        }

        public void DataBindBDDT()
        {
            try
            {
                reportViewerBDDT.RefreshReport();
                reportViewerBDDT.ProcessingMode = ProcessingMode.Local;
                reportViewerBDDT.SetDisplayMode(DisplayMode.Normal);
                reportViewerBDDT.ZoomPercent = 100;
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                if (loaiBDDT)
                {
                    reportDataSource.Value = DTAc.GetDoanhThu(date_FromBDDT.Value, date_ToBDDT.Value);
                    reportViewerBDDT.LocalReport.ReportEmbeddedResource = "QuanLyCafe.Report.ReportDoanhThuBanHang.rdlc";
                }
                else
                {
                    reportDataSource.Value = DTAc.GetDoanhThuThang(int.Parse(date_FromBDDT.Value.Month.ToString()), int.Parse(date_FromBDDT.Value.Year.ToString()), int.Parse(date_ToBDDT.Value.Month.ToString()), int.Parse(date_ToBDDT.Value.Year.ToString()));
                    reportViewerBDDT.LocalReport.ReportEmbeddedResource = "QuanLyCafe.Report.ReportDoanhThuBanHangThang.rdlc";
                }
                reportViewerBDDT.LocalReport.DataSources.Clear();
                reportViewerBDDT.LocalReport.DataSources.Add(reportDataSource);
                reportViewerBDDT.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnInBDDT_Click(object sender, EventArgs e)
        {
            string name = "BieuDoDoanhThu";
            string subject = "Báo cáo doanh thu vào lúc " + DateTime.Now.ToString();
            PrintToPrinter(reportViewerBDDT.LocalReport,name, subject);
        }

        private void btnLoai_Click(object sender, EventArgs e)
        {
            loaiBDDT = !loaiBDDT;
            if (loaiBDDT)
            {
                date_FromBDDT.Format = DateTimePickerFormat.Custom;
                // Display the date as "Mon 27 Feb 2012".  
                date_FromBDDT.CustomFormat = "dddd dd MMMM yyyy";
                date_ToBDDT.Format = DateTimePickerFormat.Custom;
                // Display the date as "Mon 27 Feb 2012".  
                date_ToBDDT.CustomFormat = "dddd dd MMMM yyyy";
                btnLoaiBDDT.Text = "Ngày";
                DataBindBDDT();
            }
            else
            {
                date_FromBDDT.Format = DateTimePickerFormat.Custom;
                // Display the date as "Mon 27 Feb 2012".  
                date_FromBDDT.CustomFormat = "MMMM yyyy";
                date_ToBDDT.Format = DateTimePickerFormat.Custom;
                // Display the date as "Mon 27 Feb 2012".  
                date_ToBDDT.CustomFormat = "MMMM yyyy";
                btnLoaiBDDT.Text = "Tháng";
                DataBindBDDT();
            }
        }

        private void date_FromBDDT_ValueChanged(object sender, EventArgs e)
        {
            DataBindBDDT();
        }

        private void date_ToBDDT_ValueChanged(object sender, EventArgs e)
        {
            DataBindBDDT();
        }

        public void PrintToPrinter(LocalReport report, string name, string subject)
        {
            //Export(report);
            try
            {
                string link = Application.StartupPath;
                link = link.Substring(0, link.Length - 10);
                string message;
                //message = "Hóa đơn bán hàng vào lúc " + DateTime.Now.ToString();
                string path = ExportReportToPDF(link + "\\EXportedReport\\", name);
                message = subject;

                Report.InputMesseageBox frmIMB = new Report.InputMesseageBox(subject, message, path);
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

            byte[] bytes = reportViewerBDDT.LocalReport.Render(format: "WORD", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);
            string filename = Path.Combine(path + reportName + "." + filenameExtension);
            using (var fs = new FileStream(filename, System.IO.FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
            return filename;

        }
    
        private void DataBindTopTD()
        {
            try
            {
                reportViewerTopTD.RefreshReport();
                reportViewerTopTD.ProcessingMode = ProcessingMode.Local;
                reportViewerTopTD.SetDisplayMode(DisplayMode.Normal
                    );
                reportViewerTopTD.ZoomPercent = 100;
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                int ngay = 0, thang = 0, nam = int.Parse(dtNgayThucDon.Value.Year.ToString());
                if (loaiTopTD < 2)
                {
                    thang = int.Parse(dtNgayThucDon.Value.Month.ToString());
                    if (loaiTopTD < 1)
                    {
                        ngay = int.Parse(dtNgayThucDon.Value.Day.ToString());
                    }
                }
                reportDataSource.Value = DTAc.GetTopThucDon(ngay, thang, nam);
                reportViewerTopTD.LocalReport.ReportEmbeddedResource = "QuanLyCafe.Report.ReportBaoCaoThucDon.rdlc";
                reportViewerTopTD.LocalReport.DataSources.Clear();
                reportViewerTopTD.LocalReport.DataSources.Add(reportDataSource);
                reportViewerTopTD.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInThucDon_Click(object sender, EventArgs e)
        {
            string name = "TopThucDon";
            string subject = "Top thực đơn bán hàng vào lúc " + DateTime.Now.ToString();
            PrintToPrinter(reportViewerTopTD.LocalReport, name, subject);
        }

        private void btnLoaiThucDon_Click(object sender, EventArgs e)
        {
            loaiTopTD++;
            if (loaiTopTD == 3)
            {
                loaiTopTD = 0;
            }
            switch (loaiTopTD)
            {
                case 0:
                    dtNgayThucDon.Format = DateTimePickerFormat.Custom;
                    // Display the date as "Mon 27 Feb 2012".  
                    dtNgayThucDon.CustomFormat = "dddd dd MMMM yyyy";
                    btnLoaiThucDon.Text = "Ngày";
                    DataBindTopTD();
                    break;
                case 1:
                    dtNgayThucDon.Format = DateTimePickerFormat.Custom;
                    // Display the date as "Mon 27 Feb 2012".  
                    dtNgayThucDon.CustomFormat = "MMMM yyyy";
                    btnLoaiThucDon.Text = "Tháng";
                    DataBindTopTD();
                    break;
                default:
                    dtNgayThucDon.Format = DateTimePickerFormat.Custom;
                    // Display the date as "Mon 27 Feb 2012".  
                    dtNgayThucDon.CustomFormat = "yyyy";
                    btnLoaiThucDon.Text = "Năm";
                    DataBindTopTD();
                    break;
            }
        }

        private void dtNgayThucDon_ValueChanged(object sender, EventArgs e)
        {
            DataBindTopTD();
        }

        private void DataBindTopNV()
        {
            try
            {
                reportViewerTopNV.RefreshReport();
                reportViewerTopNV.ProcessingMode = ProcessingMode.Local;
                reportViewerTopNV.SetDisplayMode(DisplayMode.Normal );
                reportViewerTopNV.ZoomPercent = 100;
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                int ngay = 0, thang = 0, nam = int.Parse(dtNgayNhanVien.Value.Year.ToString());
                if (loaiTopTD < 2)
                {
                    thang = int.Parse(dtNgayNhanVien.Value.Month.ToString());
                    if (loaiTopTD < 1)
                    {
                        ngay = int.Parse(dtNgayNhanVien.Value.Day.ToString());
                    }
                }
                reportDataSource.Value = DTAc.GetTopNhanVien(ngay, thang, nam);
                reportViewerTopNV.LocalReport.ReportEmbeddedResource = "QuanLyCafe.Report.ReportBaoCaoNhanVien.rdlc";
                reportViewerTopNV.LocalReport.DataSources.Clear();
                reportViewerTopNV.LocalReport.DataSources.Add(reportDataSource);
                reportViewerTopNV.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInNhanVien_Click(object sender, EventArgs e)
        {
            string name = "TopNhanVien";
            string subject = "Top nhân viên bán hàng nhiều nhất vào lúc " + DateTime.Now.ToString();
            PrintToPrinter(reportViewerTopTD.LocalReport, name, subject);
        }

        private void btnLoaiNhanVien_Click(object sender, EventArgs e)
        {
            loaiTopNV++;
            if (loaiTopNV == 3)
            {
                loaiTopNV = 0;
            }
            switch (loaiTopNV)
            {
                case 0:
                    dtNgayNhanVien.Format = DateTimePickerFormat.Custom;
                    // Display the date as "Mon 27 Feb 2012".  
                    dtNgayNhanVien.CustomFormat = "dddd dd MMMM yyyy";
                    btnLoaiNhanVien.Text = "Ngày";
                    DataBindTopNV();
                    break;
                case 1:
                    dtNgayNhanVien.Format = DateTimePickerFormat.Custom;
                    // Display the date as "Mon 27 Feb 2012".  
                    dtNgayNhanVien.CustomFormat = "MMMM yyyy";
                    btnLoaiNhanVien.Text = "Tháng";
                    DataBindTopNV();
                    break;
                default:
                    dtNgayNhanVien.Format = DateTimePickerFormat.Custom;
                    // Display the date as "Mon 27 Feb 2012".  
                    dtNgayNhanVien.CustomFormat = "yyyy";
                    btnLoaiNhanVien.Text = "Năm";
                    DataBindTopNV();
                    break;
            }
        }

        private void dtNgayNhanVien_ValueChanged(object sender, EventArgs e)
        {
            DataBindTopNV();
        }

        private void dtNgayKhachHang_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnInKH_Click(object sender, EventArgs e)
        {
            string name = "TopThanhVien";
            string subject = "Top thành viên mua hàng nhiều nhất vào lúc " + DateTime.Now.ToString();
            PrintToPrinter(reportViewerTopTD.LocalReport, name, subject);
        }

        private void btnLoaiKH_Click(object sender, EventArgs e)
        {
            loaiTopNV++;
            if (loaiTopNV == 3)
            {
                loaiTopNV = 0;
            }
            switch (loaiTopNV)
            {
                case 0:
                    dtNgayKhachHang.Format = DateTimePickerFormat.Custom;
                    // Display the date as "Mon 27 Feb 2012".  
                    dtNgayKhachHang.CustomFormat = "dddd dd MMMM yyyy";
                    btnLoaiKhachHang.Text = "Ngày";
                    DataBindTopKH();
                    break;
                case 1:
                    dtNgayKhachHang.Format = DateTimePickerFormat.Custom;
                    // Display the date as "Mon 27 Feb 2012".  
                    dtNgayKhachHang.CustomFormat = "MMMM yyyy";
                    btnLoaiKhachHang.Text = "Tháng";
                    DataBindTopKH();
                    break;
                default:
                    dtNgayKhachHang.Format = DateTimePickerFormat.Custom;
                    // Display the date as "Mon 27 Feb 2012".  
                    dtNgayKhachHang.CustomFormat = "yyyy";
                    btnLoaiKhachHang.Text = "Năm";
                    DataBindTopKH();
                    break;
            }
        }
        private void DataBindTopKH()
        {
            try
            {
                reportViewerTopKH.RefreshReport();
                reportViewerTopKH.ProcessingMode = ProcessingMode.Local;
                reportViewerTopKH.SetDisplayMode(DisplayMode.Normal);
                reportViewerTopKH.ZoomPercent = 100;
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                int ngay = 0, thang = 0, nam = int.Parse(dtNgayKhachHang.Value.Year.ToString());
                if (loaiTopTD < 2)
                {
                    thang = int.Parse(dtNgayKhachHang.Value.Month.ToString());
                    if (loaiTopTD < 1)
                    {
                        ngay = int.Parse(dtNgayKhachHang.Value.Day.ToString());
                    }
                }
                reportDataSource.Value = DTAc.GetTopThanhVien(ngay, thang, nam);
                reportViewerTopKH.LocalReport.ReportEmbeddedResource = "QuanLyCafe.Report.ReportBaoCaoThanhVien.rdlc";
                reportViewerTopKH.LocalReport.DataSources.Clear();
                reportViewerTopKH.LocalReport.DataSources.Add(reportDataSource);
                reportViewerTopKH.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
