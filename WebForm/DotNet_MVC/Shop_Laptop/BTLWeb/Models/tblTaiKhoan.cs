namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTaiKhoan")]
    public partial class tblTaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTaiKhoan()
        {
            tblPhieuNhap = new HashSet<tblPhieuNhap>();
            tblPhieuXuat = new HashSet<tblPhieuXuat>();
            tblTaiKhoanQuyen = new HashSet<tblTaiKhoanQuyen>();
            tblThanhToan = new HashSet<tblThanhToan>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaiKhoanID { get; set; }

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
        public string ChucVu { get; set; }

        [Required]
        [StringLength(30)]
        public string HoTen { get; set; }

        public int NamSinh { get; set; }

        [Required]
        [StringLength(30)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }

        public bool QuyenDangNhap { get; set; }

        [Required]
        [StringLength(30)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDangKi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhieuNhap> tblPhieuNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhieuXuat> tblPhieuXuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTaiKhoanQuyen> tblTaiKhoanQuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblThanhToan> tblThanhToan { get; set; }
    }
}
