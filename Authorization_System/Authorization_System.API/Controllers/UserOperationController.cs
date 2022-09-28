using Authorization_System.API.Models;
using Authorization_System.API.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Serilog;

namespace Authorization_System.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationController : Controller
    {
        private readonly IUserOperationService _userOperationService;
 
        public UserOperationController(IUserOperationService userOperationService )
        {
            _userOperationService = userOperationService;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public IEnumerable<IdentityUser> GetAllUsers()
        {
            try
            {
                return _userOperationService.GetAll();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                throw;
            }

        }

        [HttpPost]
        [Route("RemoveUser")]
        public IActionResult RemoveUser(Guid Id)
        {
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
