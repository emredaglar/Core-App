using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.ViewComponents.SocialMedia
{
    public class SocailMediaList:ViewComponent
    {
        SocailMediaManager _socailMediaManager=new SocailMediaManager(new EfSocailMediaDal());

        public IViewComponentResult Invoke()
        {
            var values = _socailMediaManager.TGetList();
            return View(values);
        }
    }
}
