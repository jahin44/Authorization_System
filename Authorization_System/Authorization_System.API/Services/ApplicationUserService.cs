using Authorization_System.API.Models;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Authorization_System.API.Repositories;

namespace Authorization_System.API.Services
{
    public class ApplicationUserService : IApplicationUserService
    { 
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IApplicationUserRepository _userRepository;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ApplicationUserService(  UserManager<IdentityUser> userManager,
                                       IApplicationUserRepository userRepository,
                                       RoleManager<IdentityRole> roleManager)
        {
             _userManager = userManager;
            _roleManager = roleManager;
            _userRepository = userRepository;
            
        }
        public async Task<List<Claim>>  Login(LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
                return authClaims;
            }
            else
            {
                return null;
            }

            
        }

        public async Task<string> Register(RegisterModel model)
        {
            if (model != null)
            {
                var userExists = await _userManager.FindByNameAsync(model.Username);
                if (userExists != null)
                    return "Already exists";
                IdentityUser user = new()
                {
                    Email = model.Email,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = model.Username
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return "Success";
                }

            }

            return "Error";
        }
        

    }
}
