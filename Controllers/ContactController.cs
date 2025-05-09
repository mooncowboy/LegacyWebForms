using Microsoft.AspNetCore.Mvc;

namespace LegacyWebForms.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}