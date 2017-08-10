using IDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace DAL
{
    public class BaseDAL<TEntity> : IBaseDAL<TEntity> where TEntity : class
    {
        private BaseDBContext db = new BaseDBContext();
        private DbSet<TEntity> _dbSet;

        public BaseDAL()
        {
            _dbSet = db.Set<TEntity>();
        }

        public DbSet<TEntity> DbSet { get => _dbSet; }

        /// <summary>
        /// 查询表所有数据
        /// </summary>
        /// <returns></returns>
        public List<TEntity> Where()
        {
            return _dbSet.ToList();
        }

        /// <summary>
        /// 查询指定条件predicate的表数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        /// <summary>
        /// 联表查询，查询指定条件predicate的表数据
        /// </summary>
        /// <param name="predicate">查询条件参数，以lambda方式</param>
        /// <param name="Tables">联表参数</param>
        /// <returns></returns>
        public List<TEntity> Where(Expression<Func<TEntity, bool>> predicate, string[] Tables)
        {
            DbQuery<TEntity> results = _dbSet;
            if (Tables != null && Tables.Length > 0)
            {
                foreach (string table in Tables)
                {
                    results = results.Include(table);
                }
            }
            return results.Where(predicate).ToList();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity">要修改的实体</param>
        /// <param name="fields">要修改的字段</param>
        /// <returns></returns>
        public int Update(TEntity entity, string[] fields)
        {
            if (fields.Length == 0 && fields == null)
            {
                return 0;
            }
            db.Configuration.ValidateOnSaveEnabled = false;
            DbEntityEntry obj = db.Entry(entity);
            obj.State = EntityState.Unchanged;

            foreach (string field in fields)
            {
                obj.Property(field).IsModified = true;
            }
            return 1;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isInContext"></param>
        public void Del(TEntity entity, bool isInContext)
        {
            if (isInContext == false)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        /// <summary>
        /// 保存EF容器操作
        /// </summary>
        /// <returns></returns>
        public int SaveChanges()
        {
            return db.SaveChanges();
        }
    }
}