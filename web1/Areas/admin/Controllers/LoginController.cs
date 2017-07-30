using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;

namespace web.Areas.admin.Controllers
{
    public class LoginController : BaseController
    {
        // GET: admin/Login
        public ActionResult Login()
        {
           
            
            return View();
        }
    }
}