using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class ContactController : Controller
    {
        MessageManager _messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = _messageManager.TGetList();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var value = _messageManager.TGetByID(id);
            _messageManager.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult ContactDetails(int id)
        {
            var values= _messageManager.TGetByID(id);
            return View(values);
        }
    }
}
