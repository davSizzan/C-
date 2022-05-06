namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDanhMuc")]
    public partial class tblDanhMuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDanhMuc()
        {
            tblSanPham = new HashSet<tblSanPham>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DanhMucID { get; set; }

        [Required]
        [StringLength(30)]
        public string TenDanhMuc { get; set; }

        public int tblNhomSp_NhomSpID { get; set; }

        public virtual tblNhomSp tblNhomSp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSanPham> tblSanPham { get; set; }
    }
}
