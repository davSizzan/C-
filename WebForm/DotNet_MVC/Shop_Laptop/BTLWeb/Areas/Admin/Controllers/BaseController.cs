using BaiTapLon.Areas.Admin.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLWeb.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // GET: Admin/Base
        public BaseController()
        {
            if (SessionHelper.GetSession() == null)
            {
                System.Web.HttpContext.Current.Response.Redirect("~/Admin/LoginAdmin");
            }
            //Bấy lỗi đăng nhập
        }
    }
}