namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChiTietPhieuNhap")]
    public partial class tblChiTietPhieuNhap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Id")]
        public int ChiTietPhieuNhapID { get; set; }
        [Display(Name = "Số lượng nhập")]
        public int SoLuongNhap { get; set; }
        [Display(Name = "Đơn giá")]
        public int DonGia { get; set; }

        public int tblSanPham_SanPhamID { get; set; }

        public int tblPhieuNhap_PhieuNhapID { get; set; }
        [Display(Name = "Phiếu nhập")]
        public virtual tblPhieuNhap tblPhieuNhap { get; set; }
        [Display(Name = "Sản phẩm")]
        public virtual tblSanPham tblSanPham { get; set; }
    }
}
