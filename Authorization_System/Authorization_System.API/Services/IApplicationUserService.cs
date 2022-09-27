using Authorization_System.API.Models;
using System.Security.Claims;

namespace Authorization_System.API.Services
{
    public interface IApplicationUserService
    {
        Task<List<Claim>> Login(LoginModel model);
        Task<string> Register(RegisterModel model);
    }
}
