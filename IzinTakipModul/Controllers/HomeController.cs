using Microsoft.AspNetCore.Mvc;

namespace IzinTakipModul.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
