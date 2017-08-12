﻿using Entity;
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
            List<CategoryView> categoryList = AutoEntityMap<Category, CategoryView>.EntityMap(base.CategoryBLL.Where().ToList());
            return PartialView(categoryList);
        }
        public ActionResult Category_Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Category_Create(CategoryView entity)
        {
            return View();
        }
    }
}