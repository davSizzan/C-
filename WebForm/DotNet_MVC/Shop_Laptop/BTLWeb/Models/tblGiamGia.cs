namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblGiamGia")]
    public partial class tblGiamGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGiamGia()
        {
            tblSanPham = new HashSet<tblSanPham>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GiamGiaID { get; set; }

        [Required]
        [StringLength(30)]
        public string TenGiamGia { get; set; }

        [Required]
        [StringLength(30)]
        public string MoTa { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayBatDauGiamGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKetThucGiamGia { get; set; }

        public int MucGiamGia { get; set; }

        public bool HienThi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSanPham> tblSanPham { get; set; }
    }
}
