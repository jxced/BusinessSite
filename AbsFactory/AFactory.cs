using CommonLib;
using IBLL;
using System.Configuration;

namespace AbsFactory
{
    public abstract class AFactory
    {
        public static AFactory CreateBLLFactory()
        {
            string spanName = ConfigurationManager.AppSettings["BLLFactorySpanName"].ToString();
            return Reflection.ReflectionObject(spanName, "BFactory") as AFactory;
        }

        public abstract ICategoryBLL CreateCtegoryBLLInstance();

        public abstract IContentsBLL CreateContentsBLLInstance();

        public abstract IFeedbackBLL CreateFeedbackBLLInstance();

        public abstract IMenusBLL CreateMenusBLLInstance();

        public abstract INewsBLL CreateNewsBLLInstance();

        public abstract IProductsBLL CreateProductsBLLInstance();

        public abstract IUserInfoBLL CreateUserInfoBLLInstance();

        #region 泛型无法反射

        ////string fullName = spanName + ".Factory<" + typeof(TEntity) + ">";//`1[System.Int32]
        //string fullName = spanName + ".Fctory`1[" + entityType + "]";
        //Type type = Type.GetType(fullName);
        //object o = Activator.CreateInstance(type);
        ////Type[]types= ass.GetTypes();
        ////Type t=   types[0];
        ////object o=t.InvokeMember(null, BindingFlags.DeclaredOnly |
        ////    BindingFlags.Public | BindingFlags.NonPublic |
        ////    BindingFlags.Instance | BindingFlags.CreateInstance, null, null, new object[] { });
        ////object o = Activator.CreateInstance(types[0]);
        ////object o = ass.CreateInstance(fullName);

        #endregion 泛型无法反射
    }
}