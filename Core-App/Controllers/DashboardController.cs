using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
