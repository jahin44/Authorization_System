using Authorization_System.API.Models;
using Microsoft.AspNetCore.Identity;

namespace Authorization_System.API.Services
{
    public interface IUserOperationService
    {
        List<User> GetAll();
        IdentityUser GetById(Guid Id);
        List<User> GetUserById(string Id);
        void Remove(Guid Id);
        Task<string> Update(User user);
        

    }
}
