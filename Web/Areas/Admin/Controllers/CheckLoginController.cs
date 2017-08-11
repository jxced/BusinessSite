using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommonLib;

namespace Web.Areas.Admin.Controllers
{
    public class CheckLoginController:BaseController
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Type skipLoginT = typeof(SkipLogin);
            bool IsSkip= filterContext.ActionDescriptor.IsDefined(skipLoginT,false);
            if (!IsSkip)
            {
                if (Session[Keys.SessionKey] == null)
                {
                    //filterContext.Result = new RedirectResult("/Admin/Account/Login");
                }
                
            }
            base.OnActionExecuting(filterContext);
        }
    }
}