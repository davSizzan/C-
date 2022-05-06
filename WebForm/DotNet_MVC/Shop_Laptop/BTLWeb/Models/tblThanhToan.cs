namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblThanhToan")]
    public partial class tblThanhToan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ThanhToanID { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayThanhToan { get; set; }

        public decimal SoTien { get; set; }

        public int tblTaiKhoan_TaiKhoanID { get; set; }

        public bool TrangThai { get; set; }

        public int tblDonHang_DonHangID { get; set; }

        public virtual tblDonHang tblDonHang { get; set; }

        public virtual tblTaiKhoan tblTaiKhoan { get; set; }
    }
}
