using AutoMapper;
using System.Collections.Generic;

namespace CommonLib
{
    public static class AutoEntityMap<TEntity, TEntityView>
    {
        public static TEntityView EntityMap(TEntity entity)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddConditionalObjectMapper();
                // Configuration code
            });
            return Mapper.Map<TEntityView>(entity);
        }

        public static TEntity EntityMap(TEntityView entityView)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddConditionalObjectMapper();
                // Configuration code
            });
            return Mapper.Map<TEntity>(entityView);
        }

        public static  List<TEntityView> EntityMap(List<TEntity>entity)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddConditionalObjectMapper();
                // Configuration code
            });
            return Mapper.Map<List<TEntityView>>(entity);
        }

        public static List<TEntity> EntityMap(List<TEntityView> entityView)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddConditionalObjectMapper();
                // Configuration code
            });
            return Mapper.Map<List<TEntity>>(entityView);
        }
    }
    
}