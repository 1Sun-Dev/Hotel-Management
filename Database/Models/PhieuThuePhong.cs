namespace Database.Models
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
            PhieuDVs = new HashSet<PhieuDV>();
            Phongs = new HashSet<Phong>();
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

        public virtual KhachHang KhachHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDV> PhieuDVs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
