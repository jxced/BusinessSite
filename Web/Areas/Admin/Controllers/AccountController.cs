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
        /// <summary>
        /// 登陆
        /// </summary>
        /// <returns></returns>
       public ActionResult Login()
        {
            
            //AutoEntityMap<UserInfo,UserInfoView>.EntityMap()
            return View();
        }

        /// <summary>
        /// 登陆验证
        /// </summary>
        /// <param name="entityView">用户信息实体视图</param>
        /// <returns></returns>
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
                    return RedirectToAction("Index", "Dashboard");
                }
            }
            ModelState.AddModelError("", "用户名或密码错误");
            return View();
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        public ActionResult LoginOut()
        {
            return View();
        }
    }
}