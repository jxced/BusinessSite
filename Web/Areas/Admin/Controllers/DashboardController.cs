using Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CommonLib;
using Entity.ModelViews;

namespace Web.Areas.Admin.Controllers
{
    public class DashboardController :CheckLoginController
    {
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
           List<Category>categoryList = base.CategoryBLL.Where().ToList();
           ViewData["category"]=AutoEntityMap<Category, CategoryView>.EntityMap(categoryList);
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
        public ActionResult Category()
        {
            return PartialView();
        }
    }
}