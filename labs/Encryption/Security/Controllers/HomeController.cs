using Microsoft.AspNetCore.Mvc;

namespace Security.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hashing()
        {
            return View();
        }

        public IActionResult Encryption()
        {
            return View();
        }
    }
}
