using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.ViewComponents.Dashboard
{
	public class AdminNatificationNavbarList:ViewComponent
    {
		AnnouncementManager c = new AnnouncementManager(new EfAnnouncementDal());

		public IViewComponentResult Invoke()
		{
			var values = c.TGetList();
			ViewBag.count = c.TGetList().Count();
			return View(values);
		}
	}
}
