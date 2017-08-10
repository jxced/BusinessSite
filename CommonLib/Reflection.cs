using System.Reflection;

namespace CommonLib
{
    public class Reflection
    {
        public static object ReflectionObject(string spanName, string classType)
        {
            Assembly ass = Assembly.Load(spanName);
            string fullName = spanName + "." + classType;
            return ass.CreateInstance(fullName);
        }
    }
}