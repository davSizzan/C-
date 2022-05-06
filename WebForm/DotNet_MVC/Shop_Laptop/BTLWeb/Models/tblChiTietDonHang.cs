namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChiTietDonHang")]
    public partial class tblChiTietDonHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Id")]
        public int ChiTietDonHangID { get; set; }
        [Display(Name = "Số lượng")]
        public int SoLuong { get; set; }
        [Display(Name = "Giá bán")]
        public decimal GiaBan { get; set; }
        
        public int tblDonHang_DonHangID { get; set; }

        public int tblSanPham_SanPhamID { get; set; }
        [Display(Name = "Đơn hàng")]
        public virtual tblDonHang tblDonHang { get; set; }
        [Display(Name = "Sản phẩm")]
        public virtual tblSanPham tblSanPham { get; set; }
    }
}
