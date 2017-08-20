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
            TempData["total"] = base.CategoryBLL.Where().Count();
            ViewData["total"]= base.CategoryBLL.Where().Count();
            return View();
        }

        public ActionResult Menus()
        {
            List<Menus> menus = base.MenusBLL.Where(c => c.MenusStatus == ((int)Enums.EStatus.normal == 0 ? false : true)).OrderBy(c => c.MenusSortId).ToList();
            // List<Menus> menus= base.MenusBLL.Where(c => c.MenusStatus == ((int)Enums.EStatus.normal == 0 ? false : true)).OrderBy(c=>c.MenusSortId).ToList();
            //base.MenusBLL.DbSet.Where(c => c.MenusStatus == ((int)Enums.EStatus.normal == 0 ? false : true)).OrderBy(c => c.MenusSortId).ToList();
            return PartialView(menus);
        }

        public ActionResult Content()
        {
            return PartialView();
        }
        public ActionResult Category()
        {
            int currentpager= Request.QueryString["currentpager"]==null?1: int.Parse(Request.QueryString["currentpager"]);
            int count =Request.QueryString["pagerSize"]==null?2: int.Parse(Request.QueryString["pagerSize"]);
            //ViewBag.total = base.CategoryBLL.Where().Count();
            TempData["total"] = base.CategoryBLL.Where().Count();
            int skipsize = (currentpager - 1) * count;
            List<CategoryView> categoryList = AutoEntityMap<Category, CategoryView>.EntityMap(base.CategoryBLL.Where().Skip(skipsize).Take(count).ToList());
            return PartialView(categoryList);
        }
        public ActionResult Category_Create()
        {
            return PartialView();
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Category_Create(CategoryView entity)
        {
            if (ModelState.IsValid)
            {
                base.CategoryBLL.Add(AutoEntityMap<CategoryView, Category>.EntityMap(entity));
                base.CategoryBLL.SaveChanges();
                return RedirectToAction("Category");
            }
            return PartialView();
        }

        public ActionResult News()
        {
            return View();
        }
    }
}