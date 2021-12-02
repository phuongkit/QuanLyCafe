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
    public partial class BaoCaoThucDon : Form
    {
        private DBaccess.DoanhThuAccess DTAc;
        private string connectionString;
        private FrmManHinhChinhAdmin frmMHC;
        private int loai;  //true ngay, false thang
        public BaoCaoThucDon(string connectionString, FrmManHinhChinhAdmin frmMHC)
        {
            loai = 0;
            this.connectionString = connectionString;
            this.frmMHC = frmMHC;
            DTAc = new DBaccess.DoanhThuAccess(connectionString);
            InitializeComponent();
            DataBind();
        }
        private void DataBind()
        {
            try
            {
                reportViewer1.RefreshReport();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.SetDisplayMode(DisplayMode.Normal
                    );
                reportViewer1.ZoomPercent = 100;
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                int ngay = 0, thang = 0, nam = int.Parse(Date_from.Value.Year.ToString());
                if (loai < 2)
                {
                    thang = int.Parse(Date_from.Value.Month.ToString());
                    if (loai < 1)
                    {
                        ngay = int.Parse(Date_from.Value.Day.ToString());
                    }
                }
                reportDataSource.Value = DTAc.GetTopThucDon(ngay, thang, nam);
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCafe.Report.ReportBaoCaoThucDon.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BaoCaoThucDon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void Date_from_ValueChanged(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            MyForm.DoanhThu frmDT = new MyForm.DoanhThu(frmMHC, connectionString);
            frmMHC.ShowForm(frmDT);
        }

        private void btnIn_Click(object sender, EventArgs e)
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
                path = ExportReportToPDF(link + "\\EXportedReport\\", "BieuDoDoanhThu");
                subject = "Top thực đơn bán hàng vào lúc " + DateTime.Now.ToString();
                //message = "Hóa đơn bán hàng vào lúc " + DateTime.Now.ToString();
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

            byte[] bytes = reportViewer1.LocalReport.Render(format: "WORD", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);
            string filename = Path.Combine(path + reportName + "." + filenameExtension);
            using (var fs = new FileStream(filename, System.IO.FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
            return filename;

        }

        private void btnLoai_Click(object sender, EventArgs e)
        {
            loai++;
            if (loai == 3)
            {
                loai = 0;
            }
            switch (loai)
            {
                case 0:
                    Date_from.Format = DateTimePickerFormat.Custom;
                    // Display the date as "Mon 27 Feb 2012".  
                    Date_from.CustomFormat = "dddd dd MMMM yyyy";
                    btnLoai.Text = "Ngày";
                    DataBind();
                    break;
                case 1:
                    Date_from.Format = DateTimePickerFormat.Custom;
                    // Display the date as "Mon 27 Feb 2012".  
                    Date_from.CustomFormat = "MMMM yyyy";
                    btnLoai.Text = "Tháng";
                    DataBind();
                    break;
                default:
                    Date_from.Format = DateTimePickerFormat.Custom;
                    // Display the date as "Mon 27 Feb 2012".  
                    Date_from.CustomFormat = "yyyy";
                    btnLoai.Text = "Năm";
                    DataBind();
                    break;
            }
        }
    }
}
