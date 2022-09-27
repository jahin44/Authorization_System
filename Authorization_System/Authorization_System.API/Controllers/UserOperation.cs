using Microsoft.AspNetCore.Mvc;

namespace Authorization_System.API.Controllers
{
    public class UserOperation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
