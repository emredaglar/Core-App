using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class AboutController : Controller
    {
        AboutManager _aboutManager=new AboutManager(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = _aboutManager.TGetByID(3);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            _aboutManager.TUpdate(about);
            return RedirectToAction("Index");
        }
    }
}
