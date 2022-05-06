namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPhanQuyen")]
    public partial class tblPhanQuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPhanQuyen()
        {
            tblTaiKhoanQuyen = new HashSet<tblTaiKhoanQuyen>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhanQuyenID { get; set; }

        [Required]
        [StringLength(30)]
        public string TenQuyen { get; set; }

        [Required]
        [StringLength(30)]
        public string LoaiQuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTaiKhoanQuyen> tblTaiKhoanQuyen { get; set; }
    }
}
