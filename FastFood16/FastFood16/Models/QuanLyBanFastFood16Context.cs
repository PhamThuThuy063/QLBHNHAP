﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FastFood16.Models
{
    public partial class QuanLyBanFastFood16Context : DbContext
    {
        public QuanLyBanFastFood16Context()
        {
        }

        public QuanLyBanFastFood16Context(DbContextOptions<QuanLyBanFastFood16Context> options)
            : base(options)
        {
        }

        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<HoaDonDatHang> HoaDonDatHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSp> LoaiSps { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQL_SERVER_TH;Initial Catalog=QuanLyBanFastFood16;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.HasKey(e => e.MaDh)
                    .HasName("PK__DonHang__272586614D41F5A3");

                entity.ToTable("DonHang");

                entity.Property(e => e.MaDh).HasColumnName("MaDH");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.NgayDat).HasColumnType("datetime");

                entity.Property(e => e.NgayGiao).HasColumnType("datetime");

                entity.Property(e => e.Omessage).HasColumnName("OMessage");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK__DonHang__MaKH__3B75D760");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__DonHang__MaNV__3C69FB99");
            });

            modelBuilder.Entity<HoaDonDatHang>(entity =>
            {
                entity.HasKey(e => new { e.MaDh, e.MaSp })
                    .HasName("PK__HoaDonDa__F557D6E04F938A92");

                entity.ToTable("HoaDonDatHang");

                entity.Property(e => e.MaDh).HasColumnName("MaDH");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.HasOne(d => d.MaDhNavigation)
                    .WithMany(p => p.HoaDonDatHangs)
                    .HasForeignKey(d => d.MaDh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonDatH__MaDH__46E78A0C");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.HoaDonDatHangs)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonDatH__MaSP__47DBAE45");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1E43DFD79E");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoKh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HoKH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<LoaiSp>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__LoaiSP__730A5759E7161675");

                entity.ToTable("LoaiSP");

                entity.Property(e => e.Discription).HasColumnType("ntext");

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.MaNcc)
                    .HasName("PK__NhaCungC__3A185DEB9165DC30");

                entity.ToTable("NhaCungCap");

                entity.Property(e => e.MaNcc).HasColumnName("MaNCC");

                entity.Property(e => e.DiaChi).HasMaxLength(60);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(24)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenNcc)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("TenNCC");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__NhanVien__2725D70AA440E314");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasColumnType("ntext");

                entity.Property(e => e.HoNv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("HoNV");

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.NgayVaoLam).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenNV");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SanPham__2725081C27190046");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.MaNcc).HasColumnName("MaNCC");

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("TenSP");

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK__SanPham__MaLoai__4316F928");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaNcc)
                    .HasConstraintName("FK__SanPham__MaNCC__440B1D61");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaTk)
                    .HasName("PK__TaiKhoan__27250070E4822E85");

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.MaTk).HasColumnName("MaTK");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDangNhap)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK__TaiKhoan__MaKH__4AB81AF0");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__TaiKhoan__MaNV__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
