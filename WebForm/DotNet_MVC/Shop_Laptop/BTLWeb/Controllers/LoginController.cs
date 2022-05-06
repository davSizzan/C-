using BaiTapLon.Areas.Admin.Code;
using BaiTapLon.Models;
using BTLWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTapLon.Controllers
{
    public class LoginController : Controller
    {
        DBWebShop db = new DBWebShop();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            Session.RemoveAll();
            return View();
        }
        [HttpPost]

        public ActionResult Index(LoginModel model, FormCollection field)
        {
            tblKhachHang account = db.tblKhachHang.FirstOrDefault(n => n.TenDangNhap.Contains(model.userName));
            string username = field["username"];
            string pass = field["password"];
            if (account != null)
            {
                if (account.TenDangNhap == username && account.MatKhau == pass)
                {
                    SessionHelper.SetSession(new UserSession() { username = model.userName });
                    Session["nameuser"] = account.HoTen;
                    return RedirectToAction("Index", "Home");
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
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(FormCollection form)
        {
            tblKhachHang tbl = new tblKhachHang();
            tbl.TenDangNhap = form["ussername"];
            tbl.MatKhau = form["password"];
            tbl.HoTen = form["truename"];
            tbl.Email = form["email"];
            tbl.DiaChi = form["diachi"];
            tbl.SoDienThoai = form["phone"];
            tbl.GioiTinh = form["check"];
            db.tblKhachHang.Add(tbl);
            return View();
        }
    }
    
}