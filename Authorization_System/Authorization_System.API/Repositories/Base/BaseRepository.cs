using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Authorization_System.API.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly DbContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository( DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public void AddAsync(TEntity entity)
        {
             _dbSet.AddAsync(entity);
        }

        //public Task<TEntity> FindByNameAsync(string name)
        //{

        //    return _dbSet.FindByNameAsync(name);
            
        //}

        public IList<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> expression, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entityToDelete)
        {
            throw new NotImplementedException();
        }
    }
}
