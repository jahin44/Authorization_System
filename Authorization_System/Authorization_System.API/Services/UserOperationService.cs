using Authorization_System.API.Models;
using Authorization_System.API.Repositories;
using Microsoft.AspNetCore.Identity;

namespace Authorization_System.API.Services
{
    public class UserOperationService : IUserOperationService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IApplicationUserRepository _userRepository;
        private readonly IApplicationUserService _applicationUserService;
        public UserOperationService(UserManager<IdentityUser> userManager, IApplicationUserRepository userRepository
                                     , IApplicationUserService applicationUserService)
        {
            _userRepository = userRepository;
            _userManager = userManager;
            _applicationUserService = applicationUserService;
        }


        public List<IdentityUser> GetAll()
        {

            return (List<IdentityUser>)_userRepository.GetAll();
        }

        public IdentityUser GetById(Guid Id)
        {
            if (Id == Guid.Empty)
            {
                throw new FileNotFoundException("User not found with the user id");
            }

            return _userRepository.GetById(Id);
        }

        public void Remove(Guid Id)
        {
            if (Id == Guid.Empty)
            {
                throw new FileNotFoundException("User not found with the user id");
            }
            _userRepository.Remove(_userRepository.GetById(Id));

        }

        public async Task<string> Update(User user)
        {
            if (user == null)
            {
                throw new FileNotFoundException("User not found ");
            }

            var userExists =await _userManager.FindByNameAsync(user.UserName);
            if (userExists == null)
            {
                var OldUser = _userRepository.GetById(user.Id);
                OldUser.Email = user.Email;
                OldUser.EmailConfirmed = user.EmailConfirmed;
                OldUser.PhoneNumber = user.PhoneNumber;
                OldUser.UserName = user.UserName;

                _userRepository.Update(OldUser);
                return "success";
            }
            else
            {
                return "User Name Already Exists";
            }
        }
    }
}
