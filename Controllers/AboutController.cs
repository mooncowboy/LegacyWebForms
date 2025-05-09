using Microsoft.AspNetCore.Mvc;

namespace LegacyWebForms.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}