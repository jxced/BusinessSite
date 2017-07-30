using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Areas.Admin.Controllers
{
    public class LoginController : BaseController
    {
        // GET: Admin/Login

       [HttpPost]
        public ActionResult Login()
        {
            base.UserInfoBLL.Where();
            return View();
        }
    }
}