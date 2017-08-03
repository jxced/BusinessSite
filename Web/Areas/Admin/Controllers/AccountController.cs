using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommonLib;
using Entity;
using Entity.ModelViews;

namespace Web.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
       public ActionResult Login()
        {
            ViewBag.name ="用户名";
            //AutoEntityMap<UserInfo,UserInfoView>.EntityMap()
            return View();
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection form)
        {
            if (ModelState.IsValid)
            {

            }
            
            return View();
        }
        public ActionResult LoginOut()
        {
            return View();
        }
    }
}