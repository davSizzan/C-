namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPhieuNhap")]
    public partial class tblPhieuNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPhieuNhap()
        {
            tblChiTietPhieuNhap = new HashSet<tblChiTietPhieuNhap>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhieuNhapID { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayNhap { get; set; }

        public int tblNhaCungCap_NhaCungCapID { get; set; }

        public int tblTaiKhoan_TaiKhoanID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietPhieuNhap> tblChiTietPhieuNhap { get; set; }

        public virtual tblNhaCungCap tblNhaCungCap { get; set; }

        public virtual tblTaiKhoan tblTaiKhoan { get; set; }
    }
}
