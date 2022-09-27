using Authorization_System.API.Context;
using Authorization_System.API.Repositories.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Authorization_System.API.Repositories
{
    public class ApplicationUserRepository : BaseRepository<UserManager<IdentityUser>>, IApplicationUserRepository
    {
        public ApplicationUserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
