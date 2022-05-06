using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTLWeb.Models
{
    public partial class DBWebShop : DbContext
    {
        public DBWebShop()
            : base("name=DBWebShop")
        {
        }

        public virtual DbSet<HinhThucThanhToan> HinhThucThanhToan { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblChiTietDonHang> tblChiTietDonHang { get; set; }
        public virtual DbSet<tblChiTietPhieuNhap> tblChiTietPhieuNhap { get; set; }
        public virtual DbSet<tblChiTietPhieuXuat> tblChiTietPhieuXuat { get; set; }
        public virtual DbSet<tblDanhMuc> tblDanhMuc { get; set; }
        public virtual DbSet<tblDonHang> tblDonHang { get; set; }
        public virtual DbSet<tblGiamGia> tblGiamGia { get; set; }
        public virtual DbSet<tblImage> tblImage { get; set; }
        public virtual DbSet<tblKhachHang> tblKhachHang { get; set; }
        public virtual DbSet<tblKhoHang> tblKhoHang { get; set; }
        public virtual DbSet<tblNhaCungCap> tblNhaCungCap { get; set; }
        public virtual DbSet<tblNhomSp> tblNhomSp { get; set; }
        public virtual DbSet<tblPhanQuyen> tblPhanQuyen { get; set; }
        public virtual DbSet<tblPhieuNhap> tblPhieuNhap { get; set; }
        public virtual DbSet<tblPhieuXuat> tblPhieuXuat { get; set; }
        public virtual DbSet<tblSanPham> tblSanPham { get; set; }
        public virtual DbSet<tblTaiKhoan> tblTaiKhoan { get; set; }
        public virtual DbSet<tblTaiKhoanQuyen> tblTaiKhoanQuyen { get; set; }
        public virtual DbSet<tblThanhToan> tblThanhToan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HinhThucThanhToan>()
                .HasMany(e => e.tblDonHang)
                .WithRequired(e => e.HinhThucThanhToan)
                .HasForeignKey(e => e.HinhThucThanhToan_HinhThucThanhToanID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblChiTietDonHang>()
                .Property(e => e.GiaBan)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tblChiTietPhieuXuat>()
                .Property(e => e.GiaBan)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tblDanhMuc>()
                .HasMany(e => e.tblSanPham)
                .WithRequired(e => e.tblDanhMuc)
                .HasForeignKey(e => e.FK_DanhMucID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblDonHang>()
                .HasMany(e => e.tblChiTietDonHang)
                .WithRequired(e => e.tblDonHang)
                .HasForeignKey(e => e.tblDonHang_DonHangID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblDonHang>()
                .HasMany(e => e.tblChiTietPhieuXuat)
                .WithRequired(e => e.tblDonHang)
                .HasForeignKey(e => e.tblDonHang_DonHangID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblDonHang>()
                .HasMany(e => e.tblThanhToan)
                .WithRequired(e => e.tblDonHang)
                .HasForeignKey(e => e.tblDonHang_DonHangID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblGiamGia>()
                .HasMany(e => e.tblSanPham)
                .WithRequired(e => e.tblGiamGia)
                .HasForeignKey(e => e.FK_GiamGiaID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblImage>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<tblKhachHang>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<tblKhachHang>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<tblKhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblKhachHang>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<tblKhachHang>()
                .HasMany(e => e.tblDonHang)
                .WithRequired(e => e.tblKhachHang)
                .HasForeignKey(e => e.tblKhachHang_KhachHangID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblKhoHang>()
                .HasMany(e => e.tblSanPham)
                .WithRequired(e => e.tblKhoHang)
                .HasForeignKey(e => e.FK_KhoHangID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblNhaCungCap>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhaCungCap>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhaCungCap>()
                .HasMany(e => e.tblPhieuNhap)
                .WithRequired(e => e.tblNhaCungCap)
                .HasForeignKey(e => e.tblNhaCungCap_NhaCungCapID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblNhomSp>()
                .HasMany(e => e.tblDanhMuc)
                .WithRequired(e => e.tblNhomSp)
                .HasForeignKey(e => e.tblNhomSp_NhomSpID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPhanQuyen>()
                .HasMany(e => e.tblTaiKhoanQuyen)
                .WithRequired(e => e.tblPhanQuyen)
                .HasForeignKey(e => e.tblPhanQuyen_PhanQuyenID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPhieuNhap>()
                .HasMany(e => e.tblChiTietPhieuNhap)
                .WithRequired(e => e.tblPhieuNhap)
                .HasForeignKey(e => e.tblPhieuNhap_PhieuNhapID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPhieuXuat>()
                .HasMany(e => e.tblChiTietPhieuXuat)
                .WithRequired(e => e.tblPhieuXuat)
                .HasForeignKey(e => e.tblPhieuXuat_PhieuXuatID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSanPham>()
                .Property(e => e.GiaBan)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tblSanPham>()
                .HasMany(e => e.tblChiTietDonHang)
                .WithRequired(e => e.tblSanPham)
                .HasForeignKey(e => e.tblSanPham_SanPhamID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSanPham>()
                .HasMany(e => e.tblChiTietPhieuNhap)
                .WithRequired(e => e.tblSanPham)
                .HasForeignKey(e => e.tblSanPham_SanPhamID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSanPham>()
                .HasMany(e => e.tblChiTietPhieuXuat)
                .WithRequired(e => e.tblSanPham)
                .HasForeignKey(e => e.tblSanPham_SanPhamID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSanPham>()
                .HasMany(e => e.tblImage)
                .WithRequired(e => e.tblSanPham)
                .HasForeignKey(e => e.tblSanPham_SanPhamID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTaiKhoan>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<tblTaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<tblTaiKhoan>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblTaiKhoan>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<tblTaiKhoan>()
                .HasMany(e => e.tblPhieuNhap)
                .WithRequired(e => e.tblTaiKhoan)
                .HasForeignKey(e => e.tblTaiKhoan_TaiKhoanID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTaiKhoan>()
                .HasMany(e => e.tblPhieuXuat)
                .WithRequired(e => e.tblTaiKhoan)
                .HasForeignKey(e => e.tblTaiKhoan_TaiKhoanID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTaiKhoan>()
                .HasMany(e => e.tblTaiKhoanQuyen)
                .WithRequired(e => e.tblTaiKhoan)
                .HasForeignKey(e => e.tblTaiKhoan_TaiKhoanID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTaiKhoan>()
                .HasMany(e => e.tblThanhToan)
                .WithRequired(e => e.tblTaiKhoan)
                .HasForeignKey(e => e.tblTaiKhoan_TaiKhoanID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblThanhToan>()
                .Property(e => e.SoTien)
                .HasPrecision(10, 2);
        }
    }
}
