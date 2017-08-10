using DALFactory;
using IBLL;
using IDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace BLL
{
    public class BaseBLL<TEntity> : IBaseBLL<TEntity> where TEntity : class
    {
        protected IBaseDAL<TEntity> dal = DFactory<TEntity>.Create();
        public DbSet<TEntity> DbSet { get => dal.DbSet; }

        /// <summary>
        /// 查询表所有数据
        /// </summary>
        /// <returns></returns>
        public List<TEntity> Where()
        {
            return dal.Where();
        }

        /// <summary>
        /// 查询指定条件predicate的表数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return dal.Where(predicate);
        }

        /// <summary>
        /// 联表查询，查询指定条件predicate的表数据
        /// </summary>
        /// <param name="predicate">查询条件参数，以lambda方式</param>
        /// <param name="Tables">联表参数</param>
        /// <returns></returns>
        public List<TEntity> Where(Expression<Func<TEntity, bool>> predicate, string[] Tables)
        {
            return dal.Where(predicate, Tables);
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        public void Add(TEntity entity)
        {
            dal.Add(entity);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity">要修改的实体</param>
        /// <param name="fields">要修改的字段</param>
        /// <returns></returns>
        public int Update(TEntity entity, string[] fields)
        {
            return dal.Update(entity, fields);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isInContext"></param>
        public void Del(TEntity entity, bool isInContext)
        {
            dal.Del(entity, isInContext);
        }

        /// <summary>
        /// 保存EF容器操作
        /// </summary>
        /// <returns></returns>
        public int SaveChanges()
        {
            return dal.SaveChanges();
        }
    }
}