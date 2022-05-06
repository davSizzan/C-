using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTLWeb.Models;
namespace BTLWeb.Areas.Admin.Controllers
{
    public class OrderController : BaseController
    {
        // GET: Admin/Order
        DBWebShop db = new DBWebShop();
        public ActionResult Index()
        {
            return View(db.tblDonHang.ToList());
        }
    }
}