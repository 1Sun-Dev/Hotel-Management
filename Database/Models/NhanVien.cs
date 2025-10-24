namespace Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            BaoCaos = new HashSet<BaoCao>();
            Phongs = new HashSet<Phong>();
        }

        [Key]
        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(30)]
        public string ChucVu { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
        public string GioTinh { get; set; }
        public DateTime? NgaySinh { get; set; } 
        public string SDT { get; set; }
        public string ChucVu { get; set; }
        public double? Luong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoCao> BaoCaos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
