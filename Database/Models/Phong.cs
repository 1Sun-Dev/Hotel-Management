namespace Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            PhieuDatPhongs = new HashSet<PhieuDatPhong>();
            PhieuThuePhongs = new HashSet<PhieuThuePhong>();
        }

        [Key]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [StringLength(10)]
        public string SoPhong { get; set; }

        [StringLength(10)]
        public string MaLP { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDatPhong> PhieuDatPhongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuThuePhong> PhieuThuePhongs { get; set; }
    }
}
