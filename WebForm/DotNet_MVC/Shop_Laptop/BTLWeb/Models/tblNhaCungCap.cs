namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblNhaCungCap")]
    public partial class tblNhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNhaCungCap()
        {
            tblPhieuNhap = new HashSet<tblPhieuNhap>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NhaCungCapID { get; set; }

        [Required]
        [StringLength(255)]
        public string TenNhaCungCap { get; set; }

        [Required]
        [StringLength(255)]
        public string TenGiaoDich { get; set; }

        [Required]
        [StringLength(30)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhieuNhap> tblPhieuNhap { get; set; }
    }
}
