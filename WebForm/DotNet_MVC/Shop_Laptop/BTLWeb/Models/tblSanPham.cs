namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSanPham")]
    public partial class tblSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSanPham()
        {
            tblChiTietDonHang = new HashSet<tblChiTietDonHang>();
            tblChiTietPhieuNhap = new HashSet<tblChiTietPhieuNhap>();
            tblChiTietPhieuXuat = new HashSet<tblChiTietPhieuXuat>();
            tblImage = new HashSet<tblImage>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "ID")]
        public int SanPhamID { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Tên sản phẩm")]
        public string TenSanPham { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Xuất xứ")]

        public string XuatXu { get; set; }

        [Display(Name = "Mô tả")]
        [Required]
        [StringLength(255)]
        public string MoTa { get; set; }
        [Display(Name = "Giá bán")]
        public decimal GiaBan { get; set; }
        [Display(Name = "Số lượng")]
        public int SoLuongTonTon { get; set; }
        [Display(Name = "Số lượt xem")]
        public int SoLuotXem { get; set; }
        [Display(Name = "Còn hàng")]
        public bool ConHang { get; set; }
        [Display(Name = "Bán chạy")]
        public bool BanChay { get; set; }

        public bool HienThi { get; set; }

        public int FK_GiamGiaID { get; set; }

        public int FK_DanhMucID { get; set; }

        public int FK_KhoHangID { get; set; }
        public string Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietDonHang> tblChiTietDonHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietPhieuNhap> tblChiTietPhieuNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietPhieuXuat> tblChiTietPhieuXuat { get; set; }

        public virtual tblDanhMuc tblDanhMuc { get; set; }

        public virtual tblGiamGia tblGiamGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblImage> tblImage { get; set; }

        public virtual tblKhoHang tblKhoHang { get; set; }
    }
}
