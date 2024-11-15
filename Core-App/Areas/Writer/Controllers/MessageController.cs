using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        WriterMessageMenager writerMessageMenager=new WriterMessageMenager(new EfWriterMessageDal());
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageMenager.GetListReceiverMessage(p);
            return View(messageList);
        }
		public async Task<IActionResult> SenderMessage(string p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p = values.Email;
			var messageList = writerMessageMenager.GetListSenderMessage(p);
			return View(messageList);
		}
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage=writerMessageMenager.TGetByID(id);
            return View(writerMessage);
        }
        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageMenager.TGetByID(id);
            return View(writerMessage);
        }
        [HttpGet]
        public IActionResult AddMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddMessage(WriterMessage writerMessage)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name=values.Name+" "+values.Surname;
            writerMessage.Date =Convert.ToDateTime(DateTime.Now.ToShortDateString());
            writerMessage.Sender = mail;
            writerMessage.SenderName = name;
            Context ca = new Context();
			var usernamesurname = ca.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
			if (usernamesurname == null)
			{
				ModelState.AddModelError("", "Sistemde Kayıtlı Mail Adresi Bulunamadı");
			}
			else
			{
				writerMessage.ReceiverName = usernamesurname;
				writerMessageMenager.TAdd(writerMessage);
				return RedirectToAction("SenderMessage");
			}
			writerMessageMenager.TAdd(writerMessage);
            return RedirectToAction("SenderMessage");
        }
    }
}
