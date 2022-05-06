
using BTLWeb.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLWeb.Controllers
{
    public class GioHangController : Controller

    {
        DBWebShop db = new DBWebShop();
        private List<GioHang> lstGioHang = new  List<GioHang>();
        
        // GET: GioHang
        public ActionResult Index()
        {
            lstGioHang = LayGioHang();
            lstGioHang = new List<GioHang>();
            GioHang gio = new GioHang(11100);
            GioHang gio1 = new GioHang(11101);
            lstGioHang.Add(gio);
            lstGioHang.Add(gio1);
            ViewBag.TongTien = lstGioHang.Sum(n => n.dThanhTien);
            return View(lstGioHang);
        }
        private  List<GioHang> LayGioHang()
        {
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang == null)
            {
                //nếu giỏ hàng chưa tồn tại thì thiết lập giỏ hàng
                lstGioHang = new List<GioHang>();
                Session["GioHang"] = lstGioHang;

            }
            return lstGioHang;
        }
        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                iTongSoLuong = lstGioHang.Sum(n => n.iSoLuong);
                
            }
            return iTongSoLuong;
        }
        
        [HttpPost]
        public ActionResult ThanhToan(List<GioHang> list)
        {
            if (lstGioHang != null)
            {
                foreach(var item in lstGioHang)
                {
                    tblChiTietDonHang tbl = new tblChiTietDonHang();
                    tbl.SoLuong = 1;
                    tbl.GiaBan = (decimal)item.dThanhTien;
                    tbl.tblSanPham_SanPhamID = item.sMaSP;
                   
                    db.tblChiTietDonHang.Add(tbl);
                    db.SaveChanges();
                }
                RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}