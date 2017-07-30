using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using AbsFactory;
using IBLL;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            AFactory aFactory = AFactory.CreateBLLFactory();
            IUserInfoBLL users = aFactory.CreateUserInfoBLLInstance();
            UserInfo user= users.Where(c => c.UserName == "admin").FirstOrDefault();
            return View(user);
        }
    }
}