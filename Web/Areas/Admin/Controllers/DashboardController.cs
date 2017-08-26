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
            try
            {
                if (ModelState.IsValid)
                {
                    base.CategoryBLL.Add(AutoEntityMap<CategoryView, Category>.EntityMap(entity));
                    base.CategoryBLL.SaveChanges();
                    return RedirectToAction("Category");
                }
                return PartialView();
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return PartialView();
            }
            
        }

        /// <summary>
        /// 新闻列表
        /// </summary>
        /// <returns></returns>
        public ActionResult News()
        {
           List<Category>categoryList=base.CategoryBLL.Where().ToList();
            ViewBag.list= categoryList.Select(c => new { id = c.CategoryId, name = c.CategroyTitle });
            List<NewsView>newsList= AutoEntityMap<News,NewsView>.EntityMap(base.NewsBLL.Where().ToList());
            return View(newsList);
        }

        public ActionResult News_Edit(int id)
        {
            var  entity = AutoEntityMap<News, NewsView>.EntityMap(base.NewsBLL.Where(c => c.Id == id).FirstOrDefault());
            GetIist();
            return View(entity);
        }

        private void GetIist()
        {
            List<Category> categoryList = base.CategoryBLL.Where().ToList();
            ViewBag.list = categoryList.Select(c => new { id = c.CategoryId, name = c.CategroyTitle });
        }

        [HttpPost,ValidateAntiForgeryToken,ValidateInput(false)]
        public  ActionResult News_Edit(int id, NewsView entity)
        {
            try
            {
                ModelState.Remove("IsLock");
                if (ModelState.IsValid)
                {
                    var model = base.NewsBLL.Where(c => c.Id == entity.Id).FirstOrDefault();
                    model.Author = entity.Author;
                    model.CategoryId = entity.CategoryId;
                    model.IsLock = entity.IsLock;
                    base.NewsBLL.SaveChanges();
                    GetIist();
                    return RedirectToAction("News");
                }
                GetIist();
                return View();
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                GetIist();
                return View();
            }
        }

        public ActionResult Products()
        {
            var list= AutoEntityMap<Products,ProductsView>.EntityMap(base.ProductsBLL.Where().ToList());
            return View(list);
        }
    }
}