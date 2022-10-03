using System.Linq.Expressions;

namespace Authorization_System.API.Repositories.Base
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        void Remove(TEntity entityToDelete);
        IList<TEntity> GetAll();
        //Task<TEntity> FindByNameAsync(string name);
        TEntity GetById(Guid Id); 
        void Update(TEntity entity);
 
    }
}
