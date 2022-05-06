using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTLWeb.Models
{
    public class GioHang
    {
        private DBWebShop db = new DBWebShop();
        public int sMaSP { get; set; }
        public string sTenSP { get; set; }
        public string sHinhAnh { get; set; }
        public double dDonGia { get; set; }
        public int iSoLuong { get; set; }
        public double dThanhTien
        {
            get { return iSoLuong * dDonGia; }
        }
        public GioHang(int MaSP)
        {
            sMaSP = MaSP;
            tblSanPham sanpham = db.tblSanPham.Single(n => n.SanPhamID == sMaSP);
            sTenSP = sanpham.TenSanPham;
            sHinhAnh = sanpham.Image;
            dDonGia = double.Parse(sanpham.GiaBan.ToString());

            iSoLuong = 1;
        }
    }
}