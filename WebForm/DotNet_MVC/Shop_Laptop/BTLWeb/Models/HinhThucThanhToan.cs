namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HinhThucThanhToan")]
    public partial class HinhThucThanhToan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HinhThucThanhToan()
        {
            tblDonHang = new HashSet<tblDonHang>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Id")]
        public int HinhThucThanhToanID { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Tên hình thức")]
        public string TenHinhThuc { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }

        [Display(Name = "Hiển thị")]
        public bool HienThi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDonHang> tblDonHang { get; set; }
    }
}
