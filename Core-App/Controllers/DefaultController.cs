using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()  // MVC de ActionResult .core da IActionResult
        {
            return View();
        }

        // Head Tagının olduğu kısmı ayırarak partial view olarak göstermek istedik
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavBarPartial()
        {
            return PartialView();
        }
    }
}
