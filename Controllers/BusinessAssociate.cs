using Microsoft.AspNetCore.Mvc;

namespace Business_Associate.Controllers
{
    public class BusinessAssociate : Controller
    {
        public IActionResult BusinessAssociateList()
        {
            return View();
        }
        public IActionResult BusinessAssociateRegister()
        {
            return View();
        }
        public IActionResult BusinessAssociateDataDownload()
        {
            return View();
        }
    }
}
