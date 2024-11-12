using Microsoft.AspNetCore.Mvc;

namespace Core_App.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string t)
        {
            return View();
        }
    }
}
