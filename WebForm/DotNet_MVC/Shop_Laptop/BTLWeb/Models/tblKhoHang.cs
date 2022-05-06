namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblKhoHang")]
    public partial class tblKhoHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKhoHang()
        {
            tblSanPham = new HashSet<tblSanPham>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KhoHangID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKho { get; set; }

        [Required]
        [StringLength(30)]
        public string TenViTriKho { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaChiKho { get; set; }

        public int SoLuongMax { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSanPham> tblSanPham { get; set; }
    }
}
