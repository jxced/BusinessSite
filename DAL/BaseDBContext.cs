using System.Data.Entity;

namespace DAL
{
    public class BaseDBContext : DbContext
    {
        public BaseDBContext()
            : base("name=businessSiteEntities")
        {
        }
    }
}