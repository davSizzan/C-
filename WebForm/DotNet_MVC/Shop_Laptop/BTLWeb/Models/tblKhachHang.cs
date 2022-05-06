namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblKhachHang")]
    public partial class tblKhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKhachHang()
        {
            tblDonHang = new HashSet<tblDonHang>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KhachHangID { get; set; }

        [Required]
        [StringLength(30)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(30)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string CauHoiBiMat { get; set; }

        [Required]
        [StringLength(255)]
        public string CauTraLoiBiMat { get; set; }

        [Required]
        [StringLength(30)]
        public string HoTen { get; set; }

        public int NamSinh { get; set; }

        [Required]
        [StringLength(30)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(30)]
        public string SoDienThoai { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDangKi { get; set; }

        public bool QuyenDangNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDonHang> tblDonHang { get; set; }
    }
}
