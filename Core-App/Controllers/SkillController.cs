using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager=new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var value=skillManager.TGetList();
            return View(value);
        }
    }
}
