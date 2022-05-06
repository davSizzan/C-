namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDonHang")]
    public partial class tblDonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDonHang()
        {
            tblChiTietDonHang = new HashSet<tblChiTietDonHang>();
            tblChiTietPhieuXuat = new HashSet<tblChiTietPhieuXuat>();
            tblThanhToan = new HashSet<tblThanhToan>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DonHangID { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày đặt hàng")]
        public DateTime NgayDatHang { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Địa chỉ giao hàng")]
        public string DiaChiGiaoHang { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày giao hàng")]
        public DateTime NgayGiaoHang { get; set; }

        [StringLength(50)]
        [Display(Name = "ghi chú")]
        public string GhiChu { get; set; }
        [Display(Name = "Trạng thái thanh toán")]
        public bool TrangThaiThanhToan { get; set; }
        [Display(Name = "Trạng thái giao hàng")]
        public bool TrangThaiGiaoHang { get; set; }

        public int HinhThucThanhToan_HinhThucThanhToanID { get; set; }

        public int tblKhachHang_KhachHangID { get; set; }
        [Display(Name = "Hình thức thanh toán")]
        public virtual HinhThucThanhToan HinhThucThanhToan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietDonHang> tblChiTietDonHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietPhieuXuat> tblChiTietPhieuXuat { get; set; }
        [Display(Name = "Khách hàng")]
        public virtual tblKhachHang tblKhachHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblThanhToan> tblThanhToan { get; set; }
    }
}
