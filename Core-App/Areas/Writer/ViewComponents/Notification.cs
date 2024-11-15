using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Areas.Writer.ViewComponents
{
	public class Notification : ViewComponent
	{ 
		AnnouncementManager _announcementManager=new AnnouncementManager(new EfAnnouncementDal());

		public IViewComponentResult Invoke()
		{
			var values = _announcementManager.TGetList().OrderByDescending(x=>x.ID).Take(3).ToList();
			return View(values);
		}
	}
}
