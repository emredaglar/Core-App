using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager _skillManager = new SkillManager(new EfSkillDal());

        public IViewComponentResult Invoke()
        {
            var values = _skillManager.TGetList();
            return View(values);
        }
    }
}