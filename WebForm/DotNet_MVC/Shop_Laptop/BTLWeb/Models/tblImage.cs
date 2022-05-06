namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblImage")]
    public partial class tblImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ImageID { get; set; }

        [Required]
        [StringLength(100)]
        public string Image { get; set; }

        public bool HienThi { get; set; }

        public int tblSanPham_SanPhamID { get; set; }

        public virtual tblSanPham tblSanPham { get; set; }
    }
}
