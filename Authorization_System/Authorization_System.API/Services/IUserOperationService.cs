using Authorization_System.API.Models;
using Microsoft.AspNetCore.Identity;

namespace Authorization_System.API.Services
{
    public interface IUserOperationService
    {
        List<IdentityUser> GetAll();
        IdentityUser GetById(Guid Id);
        void Remove(Guid Id);
        void Update(User user);
        

    }
}
