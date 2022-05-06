namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPhieuXuat")]
    public partial class tblPhieuXuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPhieuXuat()
        {
            tblChiTietPhieuXuat = new HashSet<tblChiTietPhieuXuat>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhieuXuatID { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayXuat { get; set; }

        public int tblTaiKhoan_TaiKhoanID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietPhieuXuat> tblChiTietPhieuXuat { get; set; }

        public virtual tblTaiKhoan tblTaiKhoan { get; set; }
    }
}
