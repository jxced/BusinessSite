using DAL;
using IDAL;

namespace DALFactory
{
    public class DFactory<TEntity> where TEntity : class
    {
        public static IBaseDAL<TEntity> Create()
        {
            return new BaseDAL<TEntity>();
        }
    }
}