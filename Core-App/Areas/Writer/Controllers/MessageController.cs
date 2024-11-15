using Microsoft.AspNetCore.Mvc;

namespace Core_App.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        public IActionResult MessageIndex()
        {
            return View();
        }
    }
}
