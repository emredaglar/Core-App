using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
	[AllowAnonymous]
	public class AdminLoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
