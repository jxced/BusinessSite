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
            List<Menus> menus = base.MenusBLL.Where(c => c.MenusStatus == ((int)Enums.EStatus.normal == 0 ? false : true)).OrderBy(c => c.MenusSortId).ToList();
            return View(menus);
        }
        public ActionResult Menus()
        {
           // List<Menus> menus= base.MenusBLL.Where(c => c.MenusStatus == ((int)Enums.EStatus.normal == 0 ? false : true)).OrderBy(c=>c.MenusSortId).ToList();
            //base.MenusBLL.DbSet.Where(c => c.MenusStatus == ((int)Enums.EStatus.normal == 0 ? false : true)).OrderBy(c => c.MenusSortId).ToList();
            return PartialView();
        }
        public ActionResult Content()
        {

            return PartialView();
        }
    }
}