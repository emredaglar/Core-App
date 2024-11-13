using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Areas.Writer.Controllers
{
    public class DefaultController : Controller
    {
        [Area("Writer")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
