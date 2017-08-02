using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;

namespace Web.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Menus()
        {
            
            base.MenusBLL.Where(c => c.MenusStatus == ((int)Enums.EStatus.normal == 0 ? false : true));
            return PartialView();
        }
    }
}