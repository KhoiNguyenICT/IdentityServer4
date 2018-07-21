using Microsoft.AspNetCore.Mvc;

namespace Google.Application.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}