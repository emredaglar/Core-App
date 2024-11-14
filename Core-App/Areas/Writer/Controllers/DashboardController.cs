using DataAccessLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Core_App.Areas.Writer.Controllers
{
	[Area("Writer")]
	public class DashboardController : Controller
	{
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> DashboardIndex()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.v = values.Name + " " + values.Surname;
            //Weather Api
            string api = "3b53c407e37904ff6a9a7fffed8f8b50";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=ankara&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //Statistic
            Context c=new Context();
			ViewBag.v1 = 1;
			ViewBag.v2 = c.Announcements.Count();
			ViewBag.v3 = 3;
			ViewBag.v4 = c.Skills.Count();
			return View();
		}
	}
}
