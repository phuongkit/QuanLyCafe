//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCafe.MyDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHoaDonBanHang
    {
        public string IDhoaDonBH { get; set; }
        public string IDthucDon { get; set; }
        public int soLuong { get; set; }
    
        public virtual HoaDonBanHang HoaDonBanHang { get; set; }
        public virtual ThucDon ThucDon { get; set; }
    }
}
