using System.Linq.Expressions;

namespace Authorization_System.API.Repositories.Base
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        void AddAsync(TEntity entity);
        void Remove(TEntity entityToDelete);
        IList<TEntity> Get(Expression<Func<TEntity, bool>> expression, string includeProperties = "");
        IList<TEntity> GetAll();
        //Task<TEntity> FindByNameAsync(string name);
        TEntity GetById(Guid Id);

    }
}
