using BaiTapLon.Areas.Admin.Code;
using BaiTapLon.Models;
using BTLWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLWeb.Areas.Admin.Controllers
{
    public class LoginAdminController : Controller
    {
        DBWebShop db = new DBWebShop();
        // GET: Admin/LoginAdmin
        public ActionResult Index()
        {
            Session.RemoveAll();
            return View();
        }
        [HttpPost]

        public ActionResult Index(LoginModel model, FormCollection field)
        {
            tblTaiKhoan account = db.tblTaiKhoan.FirstOrDefault(n => n.TenDangNhap.Contains(model.userName));
            string username = field["username"];
            string pass = field["password"];
            if (account != null)
            {
                if (account.TenDangNhap == username && account.MatKhau == pass)
                {
                    SessionHelper.SetSession(new UserSession() { username = model.userName });
                    Session["nameAd"] = account.HoTen;
                    Session["namead"] = model.userName;
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
            else
            {
                ModelState.AddModelError("", "Tài khoản không tồn tại");
            }
            return View(model);
        }
    }
}