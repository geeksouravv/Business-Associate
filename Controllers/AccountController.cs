using Microsoft.AspNetCore.Mvc;

namespace Business_Associate.Controllers
{
    public class AccountController : Controller
    {
        [Route("/")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
