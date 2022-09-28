using Authorization_System.API.Context;
using Authorization_System.API.Models;
using Authorization_System.API.Repositories.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Authorization_System.API.Repositories
{
    public class ApplicationUserRepository : BaseRepository<IdentityUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IdentityUser GetById(Guid Id)
        {
            var user = new IdentityUser();
            user.Id = Id.ToString();
            return _dbSet.Find(user.Id);
        }
    }
}
