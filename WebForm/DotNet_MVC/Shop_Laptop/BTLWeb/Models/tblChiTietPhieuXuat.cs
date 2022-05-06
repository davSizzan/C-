namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChiTietPhieuXuat")]
    public partial class tblChiTietPhieuXuat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChiTietPhieuXuatID { get; set; }

        public int SoLuongXuat { get; set; }

        public decimal GiaBan { get; set; }

        public int tblPhieuXuat_PhieuXuatID { get; set; }

        public int tblDonHang_DonHangID { get; set; }

        public int tblSanPham_SanPhamID { get; set; }

        public virtual tblDonHang tblDonHang { get; set; }

        public virtual tblPhieuXuat tblPhieuXuat { get; set; }

        public virtual tblSanPham tblSanPham { get; set; }
    }
}
