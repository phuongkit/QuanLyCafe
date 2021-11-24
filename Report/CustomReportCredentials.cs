//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.Reporting.WinForms;

//namespace QuanLyCafe.Report
//{
//    class CustomReportCredentials : IReportServerCredentials
//    {
//        private string _SoHD;
//        private string _NhanVienThanhToan;
//        private string _Ban;
//        private string _TongGia;
//        private string _NgayTao;

//        public CustomReportCredentials(string _SoHD, string _NhanVienThanhToan, string _Ban, string _TongGia, string _NgayTao)
//        {
//            this._SoHD = _SoHD;
//            this._NhanVienThanhToan = _NhanVienThanhToan;
//            this._Ban = _Ban;
//            this._TongGia = _TongGia;
//            this._NgayTao = _NgayTao;
//        }

//        public System.Security.Principal.WindowsIdentity ImpersonationUser
//        {
//            get { return null; }
//        }

//        public ICredentials NetworkCredentials
//        {
//            get { return new NetworkCredential(_SoHD, _NhanVienThanhToan, _Ban, _TongGia, _NgayTao); }
//        }

//        public bool GetFormsCredentials(out Cookie authCookie, out string user,
//         out string password, out string authority)
//        {
//            authCookie = null;
//            user = password = authority = null;
//            return false;
//        }
//    }
//}
