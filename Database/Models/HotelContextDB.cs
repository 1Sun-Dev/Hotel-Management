using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Database.Models
{
    public partial class HotelContextDB : DbContext
    {
        public HotelContextDB()
            : base("name=HotelContextDB")
        {
        }

        public virtual DbSet<BaoCao> BaoCaos { get; set; }
        public virtual DbSet<CT_HoaDon> CT_HoaDon { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiDV> LoaiDVs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<LOGIN> LOGINs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuDatPhong> PhieuDatPhongs { get; set; }
        public virtual DbSet<PhieuDV> PhieuDVs { get; set; }
        public virtual DbSet<PhieuThuePhong> PhieuThuePhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoCao>()
                .Property(e => e.MaBC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BaoCao>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HoaDon>()
                .Property(e => e.MaPTP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.MaDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.MaLDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CT_HoaDon)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiDV>()
                .Property(e => e.MaLDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.MaLP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.TaiKhoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.MatKhau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatPhong>()
                .Property(e => e.MaPDP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatPhong>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatPhong>()
                .HasMany(e => e.Phongs)
                .WithMany(e => e.PhieuDatPhongs)
                .Map(m => m.ToTable("CT_DatPhong").MapLeftKey("MaPDP").MapRightKey("MaPhong"));

            modelBuilder.Entity<PhieuDV>()
                .Property(e => e.MaPDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDV>()
                .Property(e => e.MaPTP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDV>()
                .Property(e => e.MaDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuThuePhong>()
                .Property(e => e.MaPTP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuThuePhong>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuThuePhong>()
                .HasMany(e => e.CT_HoaDon)
                .WithRequired(e => e.PhieuThuePhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaLP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.PhieuThuePhongs)
                .WithMany(e => e.Phongs)
                .Map(m => m.ToTable("CT_ThuePhong").MapLeftKey("MaPhong").MapRightKey("MaPTP"));
        }
    }
}
