namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;

    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

        public virtual DbSet<BANGLUONG> BANGLUONGs { get; set; }
        public virtual DbSet<BUOIHOC> BUOIHOCs { get; set; }
        public virtual DbSet<CONGNO> CONGNOes { get; set; }
        public virtual DbSet<CT_BUOIHOC> CT_BUOIHOC { get; set; }
        public virtual DbSet<CT_CONGNO> CT_CONGNO { get; set; }
        public virtual DbSet<CT_HOADON> CT_HOADON { get; set; }
        public virtual DbSet<CT_HOADON_NGOAIGIO> CT_HOADON_NGOAIGIO { get; set; }
        public virtual DbSet<CT_LOPHOC> CT_LOPHOC { get; set; }
        public virtual DbSet<DANHGIACUOITHANG> DANHGIACUOITHANGs { get; set; }
        public virtual DbSet<GIAOVIEN> GIAOVIENs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<HOCPHI> HOCPHIs { get; set; }
        public virtual DbSet<HOCSINH> HOCSINHs { get; set; }
        public virtual DbSet<KHOI> KHOIs { get; set; }
        public virtual DbSet<LOPHOC> LOPHOCs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<NGOAIGIO> NGOAIGIOs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<TAILIEU> TAILIEUx { get; set; }
        public virtual DbSet<THOIKHOABIEU> THOIKHOABIEUx { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BUOIHOC>()
                .HasMany(e => e.CT_BUOIHOC)
                .WithRequired(e => e.BUOIHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BUOIHOC>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.BUOIHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONGNO>()
                .HasMany(e => e.CT_CONGNO)
                .WithRequired(e => e.CONGNO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_LOPHOC>()
                .HasMany(e => e.CT_BUOIHOC)
                .WithRequired(e => e.CT_LOPHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.SDTGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CT_HOADON_NGOAIGIO)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.SDTPH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHOI>()
                .HasMany(e => e.MONHOCs)
                .WithRequired(e => e.KHOI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOPHOC>()
                .HasMany(e => e.CT_CONGNO)
                .WithRequired(e => e.LOPHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOPHOC>()
                .HasMany(e => e.THOIKHOABIEUx)
                .WithRequired(e => e.LOPHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.HOCPHIs)
                .WithOptional(e => e.MONHOC)
                .HasForeignKey(e => e.MaMon);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.TAILIEUx)
                .WithOptional(e => e.MONHOC)
                .HasForeignKey(e => e.MaMon);

            modelBuilder.Entity<NGOAIGIO>()
                .HasMany(e => e.CT_HOADON_NGOAIGIO)
                .WithRequired(e => e.NGOAIGIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDTNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.Phai)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
