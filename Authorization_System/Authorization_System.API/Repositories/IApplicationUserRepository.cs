using Authorization_System.API.Models;
using Authorization_System.API.Repositories.Base;
using Microsoft.AspNetCore.Identity;

namespace Authorization_System.API.Repositories
{
    public interface IApplicationUserRepository : IBaseRepository<UserManager<IdentityUser>>
    {

    }
}
