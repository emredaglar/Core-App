using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageMenager _writerMessageMenager = new WriterMessageMenager(new EfWriterMessageDal());

        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "a";
            var values = _writerMessageMenager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p;
            p = "a";
            var values = _writerMessageMenager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var values = _writerMessageMenager.TGetByID(id);
            return View(values);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var values = _writerMessageMenager.TGetByID(id);
            _writerMessageMenager.TDelete(values);
            if (values.Receiver == "a")
            { return RedirectToAction("ReceiverMessageList"); }
            else
            { return RedirectToAction("SenderMessageList"); }
        }
        [HttpGet]
        public IActionResult AdminMessageAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageAdd(WriterMessage writerMessage)
        {
            writerMessage.Sender = "a";
            writerMessage.SenderName = "Admin";
            writerMessage.Date =Convert.ToDateTime(DateTime.Now.ToShortDateString());
            Context ca = new Context();
            var usernamesurname = ca.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessage.ReceiverName = usernamesurname;
            _writerMessageMenager.TAdd(writerMessage);
            return RedirectToAction("SenderMessageList");
        }
    }
}
