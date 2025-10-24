namespace Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDatPhong")]
    public partial class PhieuDatPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuDatPhong()
        {
            Phongs = new HashSet<Phong>();
        }

        [Key]
        [StringLength(10)]
        public string MaPDP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhan { get; set; }

        [StringLength(20)]
        public string TinhTrang { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
