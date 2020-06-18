using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace news.DAL.Models
{
    public partial class NewsContext : DbContext
    {
        public NewsContext()
        {
        }

        public NewsContext(DbContextOptions<NewsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DemId> DemId { get; set; }
        public virtual DbSet<LoaiTin> LoaiTin { get; set; }
        public virtual DbSet<TheLoai> TheLoai { get; set; }
        public virtual DbSet<TinTuc> TinTuc { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=News;Persist Security Info=True;User ID=sa;Password=1;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DemId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DemID");

                entity.Property(e => e.CountId).HasColumnName("countID");
            });

            modelBuilder.Entity<LoaiTin>(entity =>
            {
                entity.HasKey(e => e.Idloaitin);

                entity.Property(e => e.Idloaitin)
                    .HasColumnName("IDloaitin")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnhienLt).HasColumnName("anhienLT");

                entity.Property(e => e.Idtheloai).HasColumnName("IDtheloai");

                entity.Property(e => e.TenLt)
                    .HasColumnName("tenLT")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.ThutuLt).HasColumnName("thutuLT");
            });

            modelBuilder.Entity<TheLoai>(entity =>
            {
                entity.HasKey(e => e.Idtheloai);

                entity.Property(e => e.Idtheloai)
                    .HasColumnName("IDtheloai")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnhienTl).HasColumnName("anhienTL");

                entity.Property(e => e.TenTl)
                    .HasColumnName("tenTL")
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.ThutuTl).HasColumnName("thutuTL");
            });

            modelBuilder.Entity<TinTuc>(entity =>
            {
                entity.HasKey(e => e.Idtintuc);

                entity.Property(e => e.Idtintuc)
                    .HasColumnName("IDtintuc")
                    .ValueGeneratedNever();

                entity.Property(e => e.Anhientin).HasColumnName("anhientin");

                entity.Property(e => e.Idloaitin).HasColumnName("IDloaitin");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasMaxLength(200);

                entity.Property(e => e.Ngaydang)
                    .HasColumnName("ngaydang")
                    .HasColumnType("date");

                entity.Property(e => e.Noidung).HasColumnName("noidung");

                entity.Property(e => e.Solanxem).HasColumnName("solanxem");

                entity.Property(e => e.Tieude)
                    .HasColumnName("tieude")
                    .HasMaxLength(250);

                entity.Property(e => e.Tinnoibat).HasColumnName("tinnoibat");

                entity.Property(e => e.Tomtat)
                    .HasColumnName("tomtat")
                    .HasMaxLength(250);

                entity.Property(e => e.UrlHinh)
                    .HasColumnName("urlHinh")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Iduser);

                entity.Property(e => e.Iduser)
                    .HasColumnName("IDuser")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250);

                entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");

                entity.Property(e => e.Hoten)
                    .HasColumnName("hoten")
                    .HasMaxLength(150);

                entity.Property(e => e.Idgroup).HasColumnName("IDgroup");

                entity.Property(e => e.Ngaydangky)
                    .HasColumnName("ngaydangky")
                    .HasColumnType("date");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("ngaysinh")
                    .HasColumnType("date");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
