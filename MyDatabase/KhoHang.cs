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
    
    public partial class KhoHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhoHang()
        {
            this.ChiTietHoaDonNhapHangs = new HashSet<ChiTietHoaDonNhapHang>();
        }
    
        public string ID { get; set; }
        public string Ten { get; set; }
        public string DonViTinh { get; set; }
        public int soLuong { get; set; }
        public float DonGia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDonNhapHang> ChiTietHoaDonNhapHangs { get; set; }
    }
}
