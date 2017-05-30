namespace PROJECT
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<ADMINISTATOR> ADMINISTATORs { get; set; }
        public virtual DbSet<ALBUM> ALBUMs { get; set; }
        public virtual DbSet<BAIHAT> BAIHATs { get; set; }
        public virtual DbSet<CTDANHSACHCHOINHAC> CTDANHSACHCHOINHACs { get; set; }
        public virtual DbSet<DANHSACHCHOINHAC> DANHSACHCHOINHACs { get; set; }
        public virtual DbSet<HOPTHU> HOPTHUs { get; set; }
        public virtual DbSet<NGHESI> NGHESIs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<PHIM> PHIMs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADMINISTATOR>()
                .HasMany(e => e.HOPTHUs)
                .WithOptional(e => e.ADMINISTATOR)
                .HasForeignKey(e => e.ADMINID);

            modelBuilder.Entity<BAIHAT>()
                .HasMany(e => e.CTDANHSACHCHOINHACs)
                .WithRequired(e => e.BAIHAT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANHSACHCHOINHAC>()
                .HasMany(e => e.CTDANHSACHCHOINHACs)
                .WithRequired(e => e.DANHSACHCHOINHAC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .HasMany(e => e.DANHSACHCHOINHACs)
                .WithOptional(e => e.NGUOIDUNG)
                .HasForeignKey(e => e.MAID_NGUOIDUNG);

            modelBuilder.Entity<NGUOIDUNG>()
                .HasMany(e => e.HOPTHUs)
                .WithOptional(e => e.NGUOIDUNG)
                .HasForeignKey(e => e.NGUOIDUNGID);
        }
    }
}
