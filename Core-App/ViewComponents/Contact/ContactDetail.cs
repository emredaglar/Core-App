using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.ViewComponents.Contact
{
	public class ContactDetail:ViewComponent
	{
		ContactManager contactManager=new ContactManager(new EfContactDal());

		public IViewComponentResult Invoke()
		{
			var values=contactManager.TGetList();
			return View(values);
		}
	}
}
