using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using AbsFactory;
using IBLL;
using System.Data.Entity;

namespace Web.Areas.Admin.Controllers
{
    public class BaseController:Controller
    {
        AFactory aFactory = AFactory.CreateBLLFactory();

        public BaseController(/*ICategoryBLL categoryBLL, IContentsBLL contentsBLL, IFeedbackBLL feedbackBLL, IMenusBLL menusBLL, INewsBLL newsBLL, IProductsBLL productsBLL, IUserInfoBLL userInfoBLL*/)
        {
            CategoryBLL = aFactory.CreateCtegoryBLLInstance();
            ContentsBLL =aFactory.CreateContentsBLLInstance();
            FeedbackBLL = aFactory.CreateFeedbackBLLInstance();
            MenusBLL = aFactory.CreateMenusBLLInstance();
            NewsBLL = aFactory.CreateNewsBLLInstance();
            ProductsBLL = aFactory.CreateProductsBLLInstance();
            UserInfoBLL = aFactory.CreateUserInfoBLLInstance();
        }

        public ICategoryBLL CategoryBLL { get; set; }
        public IContentsBLL ContentsBLL { get; set; }
        public IFeedbackBLL FeedbackBLL { get; set; }
        public IMenusBLL MenusBLL { get; set; }
        public INewsBLL NewsBLL { get; set; }
        public IProductsBLL ProductsBLL { get; set; }
        public IUserInfoBLL UserInfoBLL { get; set; }

    }
}