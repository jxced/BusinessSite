using AbsFactory;
using CommonLib;
using IBLL;
using System.Configuration;

namespace BLLFactory
{
    public class BFactory : AFactory
    {
        //public static IBaseBLL<TEntity> Create()
        //{
        //    return new BaseBLL<TEntity>();
        //}
        private string spanName = ConfigurationManager.AppSettings["BLLSpanName"].ToString();

        public override ICategoryBLL CreateCtegoryBLLInstance()
        {
            return Reflection.ReflectionObject(spanName, "CategoryBLL") as ICategoryBLL;
        }

        public override IContentsBLL CreateContentsBLLInstance()
        {
            return Reflection.ReflectionObject(spanName, "ContentsBLL") as IContentsBLL;
        }

        public override IFeedbackBLL CreateFeedbackBLLInstance()
        {
            return Reflection.ReflectionObject(spanName, "FeedbackBLL") as IFeedbackBLL;
        }

        public override IMenusBLL CreateMenusBLLInstance()
        {
            return Reflection.ReflectionObject(spanName, "MenusBLL") as IMenusBLL;
        }

        public override INewsBLL CreateNewsBLLInstance()
        {
            return Reflection.ReflectionObject(spanName, "NewsBLL") as INewsBLL;
        }

        public override IProductsBLL CreateProductsBLLInstance()
        {
            return Reflection.ReflectionObject(spanName, "ProductsBLL") as IProductsBLL;
        }

        public override IUserInfoBLL CreateUserInfoBLLInstance()
        {
            return Reflection.ReflectionObject(spanName, "UserInfoBLL") as IUserInfoBLL;
        }
    }
}