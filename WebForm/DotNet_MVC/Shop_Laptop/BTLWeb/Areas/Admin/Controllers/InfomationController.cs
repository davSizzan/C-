using BTLWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLWeb.Areas.Admin.Controllers
{
    public class InfomationController : BaseController
    {
        DBWebShop db = new DBWebShop();
        public ActionResult Index()
        {
            string user = (string)Session["namead"];
            tblTaiKhoan tk = db.tblTaiKhoan.SingleOrDefault(n => n.TenDangNhap == user);
            return View(tk);
        }
    }
}