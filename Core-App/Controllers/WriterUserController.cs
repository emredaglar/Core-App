using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class WriterUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
