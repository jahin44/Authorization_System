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


        public List<User> GetAll()
        {

            var allIdentity = (List<IdentityUser>)_userRepository.GetAll();
            List<User> allUser = new List<User>();

            foreach (var i in allIdentity)
            {
                var user = new User();
                user.Id = Guid.Parse(i.Id);
                user.UserName = i.UserName;
                user.Email = i.Email;
                user.PhoneNumber = i.PhoneNumber;
                user.EmailConfirmed = i.EmailConfirmed;
                allUser.Add(user);

            }

            return allUser;
        }

        public IdentityUser GetById(Guid Id)
        {
            if (Id == Guid.Empty)
            {
                throw new FileNotFoundException("User not found with the user id");
            }

            return _userRepository.GetById(Id);
        }
        public User GetByName(string userName)
        {

            if (userName == null)
            {
                throw new FileNotFoundException("User not found with the user id");
            }
            var allUser = GetAll();
            var user = new User();
            foreach (var i in allUser)
            {
                if (i.UserName == userName)
                {

                    user.Id = i.Id;
                    user.UserName = i.UserName;
                    user.Email = i.Email;
                    user.PhoneNumber = i.PhoneNumber;
                    user.EmailConfirmed = i.EmailConfirmed;

                }

            }

            return user;
        }

        public List<User> GetUserById(string Id)
        {
             var allIdentity =GetById(new Guid(Id));
            List<User> allUser = new List<User>();

                var user = new User();
                user.Id = Guid.Parse(allIdentity.Id);
                user.UserName = allIdentity.UserName;
                user.Email = allIdentity.Email;
                user.PhoneNumber = allIdentity.PhoneNumber;
                user.EmailConfirmed = allIdentity.EmailConfirmed;
                allUser.Add(user);

                return allUser;
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

            var userExists = await _userManager.FindByNameAsync(user.UserName);
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
