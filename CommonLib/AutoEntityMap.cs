using AutoMapper;

namespace CommonLib
{
    public static class AutoEntityMap<TEntity,TEntityView>
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
    }
}
