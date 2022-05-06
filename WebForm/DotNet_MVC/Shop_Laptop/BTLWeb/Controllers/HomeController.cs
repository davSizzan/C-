using BTLWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
namespace BaiTapLon.Controllers
{
    public class HomeController : Controller
    {
        DBWebShop db = new DBWebShop();
        public ActionResult Index(int? page)
        {
            int pagesize = 20;//số sản phẩm trên một trang
            int pagenum = (page ?? 1);
            IEnumerable<tblSanPham> list = db.tblSanPham.OrderBy(n => n.SanPhamID).ToList();
            /*IEnumerable<tblSanPham> list = db.tblSanPham.OrderBy(n => n.SanPhamID).Where(n => n.FK_DanhMucID == 1113).ToList();*/
            if (list == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(list.ToPagedList(pagenum, pagesize));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}