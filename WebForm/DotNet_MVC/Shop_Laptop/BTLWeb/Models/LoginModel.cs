using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    public class LoginModel
    {
        [Required]
        public string userName { set; get; }
        public string passWord { set; get; }
        public bool rememberMe { set; get; }
    }
}