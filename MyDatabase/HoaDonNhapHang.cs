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
    
    public partial class HoaDonNhapHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDonNhapHang()
        {
            this.ChiTietHoaDonNhapHangs = new HashSet<ChiTietHoaDonNhapHang>();
        }
    
        public string ID { get; set; }
        public string IDnhanVien { get; set; }
        public System.DateTime NgayTao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDonNhapHang> ChiTietHoaDonNhapHangs { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
