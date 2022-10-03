using Authorization_System.API.Models;
using Authorization_System.API.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using Serilog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Authorization_System.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationController : Controller
    {
        private readonly IUserOperationService _userOperationService;
        private readonly UserManager<IdentityUser> _userManager;

        public UserOperationController(IUserOperationService userOperationService
                                     , UserManager<IdentityUser> userManager)
        {
            _userOperationService = userOperationService;
            _userManager = userManager;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                var userId = HttpContext.User.FindFirstValue("UserId");
                var role = HttpContext.User.IsInRole("Admin");
                
                if (role)
                {
                    return _userOperationService.GetAll();
                }
                else
                {
                     
                    return _userOperationService.GetUserById(userId);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                throw;
            }

        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("RemoveUser")]
        public IActionResult RemoveUser(string id)
        {
            if (id == null)
            {         
                throw new FileNotFoundException("User not found ");

            }

            var Id = new Guid(id);
            try
            {
                if (Id != Guid.Empty)
                {
                    _userOperationService.Remove(Id);
                    return Ok(new Response { Status = "Success", Message = "User created successfully!" });
                }
                else
                {
                    return BadRequest(new Response { Status = "Error", Message = "Error!" });
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                throw;
            }

            
        }

        [HttpPost]
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            try
            {
                if (user != null)
                {
                     var result =await _userOperationService.Update(user);
                    return Ok(new Response { Status = result });
                }
                else
                {
                    return BadRequest(new Response { Status = "Error", Message = "Error!" });
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                throw;
            }

        }


    }
}
