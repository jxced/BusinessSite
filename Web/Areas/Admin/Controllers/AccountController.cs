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
            
            //AutoEntityMap<UserInfo,UserInfoView>.EntityMap()
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserInfoView entityView)
        {
            if (ModelState.IsValid)
            {
               UserInfo entity= AutoEntityMap<UserInfoView, UserInfo>.EntityMap(entityView);
                string pwd= Kits.GetMD5(entity.UserPwd);
                bool b= UserInfoBLL.Where(c =>c.UserName== entity.UserName && c.UserPwd == pwd).Any();
                if (b)
                {
                    return RedirectToAction("Index", "Dashboar");
                }
            }
            
            return View();
        }
        public ActionResult LoginOut()
        {
            return View();
        }
    }
}