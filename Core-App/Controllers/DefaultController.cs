using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

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
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            
            MessageManager _messageManager = new MessageManager(new EfMessageDal());
            message.Date =Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _messageManager.TAdd(message);

            return RedirectToAction("Index", "Default");
        }
    }
}
