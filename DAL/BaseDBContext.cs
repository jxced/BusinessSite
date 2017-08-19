using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Entity;

namespace DAL
{
    public class BaseDBContext : DbContext
    {
        public BaseDBContext()
            : base("name=businessSiteEntities")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Contents> Contents { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
    }
}