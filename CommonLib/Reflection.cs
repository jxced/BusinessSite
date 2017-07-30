using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

namespace CommonLib
{
    public class Reflection
    {
        public static object ReflectionObject(string spanName,string classType)
        {
            Assembly ass = Assembly.Load(spanName);
            string fullName = spanName +"."+ classType;
            return ass.CreateInstance(fullName);
        }
    }
}
