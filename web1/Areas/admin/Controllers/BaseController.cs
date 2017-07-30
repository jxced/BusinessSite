using AbsFactory;
using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.Areas.admin.Controllers
{
    public class BaseController : Controller
    {
        // GET: admin/Base
        AFactory aFactory = AFactory.CreateBLLFactory();
          private ICategoryBLL categoryBLL;
          private IContentsBLL contentsBLL;
          private IFeedbackBLL feedbackBLL;
          private IMenusBLL menusBLL;
          private INewsBLL newsBLL;
          private IProductsBLL productsBLL;
          private IUserInfoBLL userInfoBLL;

        public BaseController()
        {
            this.categoryBLL = aFactory.CreateCtegoryBLLInstance();
            this.contentsBLL = aFactory.CreateContentsBLLInstance();
            this.feedbackBLL = aFactory.CreateFeedbackBLLInstance();
            this.menusBLL = aFactory.CreateMenusBLLInstance();
            this.newsBLL = aFactory.CreateNewsBLLInstance();
            this.productsBLL = aFactory.CreateProductsBLLInstance();
            this.userInfoBLL = aFactory.CreateUserInfoBLLInstance();
        }

        public ICategoryBLL CategoryBLL { get => categoryBLL; set => categoryBLL = value; }
        public IContentsBLL ContentsBLL { get => contentsBLL; set => contentsBLL = value; }
        public IFeedbackBLL FeedbackBLL { get => feedbackBLL; set => feedbackBLL = value; }
        public IMenusBLL MenusBLL { get => menusBLL; set => menusBLL = value; }
        public INewsBLL NewsBLL { get => newsBLL; set => newsBLL = value; }
        public IProductsBLL ProductsBLL { get => productsBLL; set => productsBLL = value; }
        public IUserInfoBLL UserInfoBLL { get => userInfoBLL; set => userInfoBLL = value; }
    }
}