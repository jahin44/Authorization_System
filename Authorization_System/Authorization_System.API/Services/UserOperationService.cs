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
                                     ,IApplicationUserService applicationUserService)
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
            return _userRepository.GetById( Id);

        }

        public void Remove(Guid Id)
        {

           _userRepository.Remove( _userRepository.GetById(Id));
        }

        public void Update(User user)
        {
            var OldUser =_userRepository.GetById(user.Id);
            OldUser.Email = user.Email;
            OldUser.EmailConfirmed=user.EmailConfirmed;
            OldUser.PhoneNumber = user.PhoneNumber;
            OldUser.UserName = user.UserName;
            OldUser.PasswordHash = user.Password;
            _userRepository.Update(OldUser);
        }
    }
}
