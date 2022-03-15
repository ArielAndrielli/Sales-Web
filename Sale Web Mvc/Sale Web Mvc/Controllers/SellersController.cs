using Microsoft.AspNetCore.Mvc;

namespace Sale_Web_Mvc.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
