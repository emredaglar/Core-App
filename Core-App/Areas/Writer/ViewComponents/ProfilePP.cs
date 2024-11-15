using DataAccessLayer.Migrations;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Areas.Writer.ViewComponents
{
	public class ProfilePP:ViewComponent
	{
		private readonly UserManager<WriterUser> _userManager;

		public ProfilePP(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.v = values.ImageUrl;
			return View();
		}
	}
}
