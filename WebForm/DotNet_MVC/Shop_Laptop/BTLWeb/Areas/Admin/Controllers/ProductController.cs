using BTLWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLWeb.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        // GET: Admin/Product
        DBWebShop db = new DBWebShop();
        public ActionResult Index()
        {

            IEnumerable<tblSanPham> sanpham = db.tblSanPham.OrderBy(n => n.SanPhamID).ToList();

            return View(sanpham);
        }
        public ActionResult DangSanPham()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangSanPham(tblSanPham sanPham)
        {
            if (db.tblSanPham.OrderBy(n => n.SanPhamID).Where(n => n.SanPhamID == sanPham.SanPhamID) == null)
            {
                db.tblSanPham.Add(sanPham);
                db.SaveChanges();
                Redirect("Index");
            }
            
            return View();
        }
        public ActionResult thongke()
        {
            return View();
        }
    }
}