using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
	public class ErrorPageController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Error404()
		{
			return View();
		}
	}
}
