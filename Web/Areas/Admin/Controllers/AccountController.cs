using CommonLib;
using Entity;
using Entity.ModelViews;
using System.Linq;
using System.Web.Mvc;

namespace Web.Areas.Admin.Controllers
{
    public class AccountController : CheckLoginController
    {
        /// <summary>
        /// 登陆
        /// </summary>
        /// <returns></returns>
        [HttpGet,SkipLogin]
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
        [HttpPost,SkipLogin]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserInfoView entityView)
        {
            if (ModelState.IsValid)
            {
                UserInfo entity = AutoEntityMap<UserInfoView, UserInfo>.EntityMap(entityView);
                string pwd = Kits.GetMD5(entity.UserPwd);
                bool b = UserInfoBLL.Where(c => c.UserName == entity.UserName && c.UserPwd == pwd).Any();
                if (b)
                {
                    Session[Keys.SessionKey] = entity.UserName;
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
        [SkipLogin]
        public ActionResult LoginOut()
        {
            Session[Keys.SessionKey] = null;
            return Redirect("/Admin/Account/Login");
        }
    }
}