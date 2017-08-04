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
            List<Menus> menus= base.MenusBLL.Where(c => c.MenusStatus == ((int)Enums.EStatus.normal == 0 ? false : true)).OrderBy(c=>c.MenusSortId).ToList();

            return PartialView(menus);
        }
        //void GetMenu(List<Menus> menu)
        //{
        //    System.Text.StringBuilder sb = new System.Text.StringBuilder();
        //    if (menu.Count>0)
        //    {
        //        foreach (var item in menu)
        //        {
        //            if (item.MenusParentId == -1)
        //            {
        //                sb.AppendLine("<li>" + "</li>");
        //            }
        //    }
        //    }
            
        //}
    }
}