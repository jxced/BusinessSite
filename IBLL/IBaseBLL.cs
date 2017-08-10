using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace IBLL
{
    public interface IBaseBLL<TEntity> where TEntity : class
    {
        DbSet<TEntity> DbSet { get; }

        /// <summary>
        /// 查询表所有数据
        /// </summary>
        /// <returns></returns>
        List<TEntity> Where();

        /// <summary>
        /// 查询指定条件predicate的表数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        List<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 联表查询，查询指定条件predicate的表数据
        /// </summary>
        /// <param name="predicate">查询条件参数，以lambda方式</param>
        /// <param name="Tables">联表参数</param>
        /// <returns></returns>
        List<TEntity> Where(Expression<Func<TEntity, bool>> predicate, string[] Tables);

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity">要修改的实体</param>
        /// <param name="fields">要修改的字段</param>
        /// <returns></returns>
        int Update(TEntity entity, string[] fields);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isInContext"></param>
        void Del(TEntity entity, bool isInContext);

        /// <summary>
        /// 保存EF容器操作
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
    }
}