using Core_App.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                WriterUser writerUser = new WriterUser();
                {
                    writerUser.Name = model.Name;
                    writerUser.Surname = model.SurName;
                    writerUser.Email = model.Mail;
                    writerUser.UserName = model.UserName;
                    writerUser.ImageUrl = model.ImageUrl;
                };
                var result = await _userManager.CreateAsync(writerUser, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }


            return View(model);
        }
    }
}
