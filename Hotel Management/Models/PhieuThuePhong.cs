namespace Hotel_Management.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuThuePhong")]
    public partial class PhieuThuePhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuThuePhong()
        {
            CT_HoaDon = new HashSet<CT_HoaDon>();
            CT_HoaDon1 = new HashSet<CT_HoaDon>();
            CT_ThuePhong = new HashSet<CT_ThuePhong>();
            CT_ThuePhong1 = new HashSet<CT_ThuePhong>();
            PhieuDVs = new HashSet<PhieuDV>();
            PhieuDVs1 = new HashSet<PhieuDV>();
        }

        [Key]
        [StringLength(10)]
        public string MaPTP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HoaDon> CT_HoaDon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HoaDon> CT_HoaDon1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_ThuePhong> CT_ThuePhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_ThuePhong> CT_ThuePhong1 { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual KhachHang KhachHang1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDV> PhieuDVs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDV> PhieuDVs1 { get; set; }
    }
}
