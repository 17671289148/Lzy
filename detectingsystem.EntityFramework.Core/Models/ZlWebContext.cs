using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace detectingsystem.EntityFramework.Core.Models
{
    public partial class ZlWebContext : DbContext
    {
        public ZlWebContext()
        {
        }

        public ZlWebContext(DbContextOptions<ZlWebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mbeam> Mbeams { get; set; }
        public virtual DbSet<MbeamFactory> MbeamFactories { get; set; }
        public virtual DbSet<Mbid> Mbids { get; set; }
        public virtual DbSet<MdeletedData> MdeletedDatas { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<Mnotice> Mnotices { get; set; }
        public virtual DbSet<Mpass> Mpasses { get; set; }
        public virtual DbSet<MrealTimeData> MrealTimeDatas { get; set; }
        public virtual DbSet<MroadSection> MroadSections { get; set; }
        public virtual DbSet<Mtemplet> Mtemplets { get; set; }
        public virtual DbSet<MtestStage> MtestStages { get; set; }
        public virtual DbSet<MuploadFile> MuploadFiles { get; set; }
        public virtual DbSet<Muser> Musers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=ZlWeb; Persist Security Info=True; User ID=saa; Password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<Mbeam>(entity =>
            {
                entity.ToTable("MBeams");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Afm).HasColumnName("AFm");

                entity.Property(e => e.Aft).HasColumnName("AFt");

                entity.Property(e => e.Bid).HasColumnName("BId");

                entity.Property(e => e.CalibrationTime).HasColumnType("datetime");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.PouringTime).HasColumnType("datetime");

                entity.Property(e => e.ProduceTime).HasColumnType("datetime");

                entity.Property(e => e.TensioningTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MbeamFactory>(entity =>
            {
                entity.ToTable("MBeamFactories");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Bid).HasColumnName("BId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Uid).HasColumnName("UId");
            });

            modelBuilder.Entity<Mbid>(entity =>
            {
                entity.ToTable("MBids");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Rid).HasColumnName("RId");

                entity.Property(e => e.Uid).HasColumnName("UId");
            });

            modelBuilder.Entity<MdeletedData>(entity =>
            {
                entity.ToTable("MDeletedDatas");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.Did).HasColumnName("DId");

                entity.Property(e => e.Uid).HasColumnName("UId");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Mnotice>(entity =>
            {
                entity.ToTable("MNotices");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Rid).HasColumnName("RId");
            });

            modelBuilder.Entity<Mpass>(entity =>
            {
                entity.ToTable("MPasses");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Bid).HasColumnName("BId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MrealTimeData>(entity =>
            {
                entity.ToTable("MRealTimeDatas");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.AbsoluteTime).HasColumnType("datetime");

                entity.Property(e => e.Pid).HasColumnName("PId");
            });

            modelBuilder.Entity<MroadSection>(entity =>
            {
                entity.ToTable("MRoadSections");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Uid).HasColumnName("UId");
            });

            modelBuilder.Entity<Mtemplet>(entity =>
            {
                entity.ToTable("MTemplets");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MtestStage>(entity =>
            {
                entity.ToTable("MTestStages");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Pid).HasColumnName("PId");
            });

            modelBuilder.Entity<MuploadFile>(entity =>
            {
                entity.ToTable("MUploadFiles");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Bid).HasColumnName("BId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Muser>(entity =>
            {
                entity.ToTable("MUsers");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnName("EMail");

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Tid).HasColumnName("TId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
