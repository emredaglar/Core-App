using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.ViewComponents.Dashboard
{
	public class MessageList:ViewComponent
	{
		UserMessageManager messageManager = new UserMessageManager(new EfUserMessageDal());

		public IViewComponentResult Invoke()
		{
			var values = messageManager.GetUserMessagesWithUserService();
			return View(values);
		}
	}
}
