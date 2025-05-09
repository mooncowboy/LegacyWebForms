using Microsoft.AspNetCore.Mvc;

namespace LegacyWebForms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}