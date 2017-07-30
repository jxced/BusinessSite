using AbsFactory;
using CommonLib;
using Entity;
using Entity.ModelViews;
using IBLL;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;


namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            AFactory af = AFactory.CreateBLLFactory();
            IUserInfoBLL ib = af.CreateUserInfoBLLInstance();
            UserInfo u = ib.Where().FirstOrDefault();
            Console.Write("用户ID:{0},用户名：{1}", u.UserId, u.UserName);
            Console.ReadKey();
        }
        


    }

}
