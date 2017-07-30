using DAL;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALFactory
{
    public class DFactory<TEntity>where TEntity:class
    {
        public static IBaseDAL<TEntity> Create()
        {
            return new BaseDAL<TEntity>();
        }
    }
}
