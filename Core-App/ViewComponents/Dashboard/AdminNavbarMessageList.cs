using BusinessLayer.Concrete;
using Core_App.Models;
using DataAccessLayer;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core_App.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList:ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;
        WriterMessageMenager _writerMessageMenager=new WriterMessageMenager(new EfWriterMessageDal());
        public AdminNavbarMessageList(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string p = "a";
            Context c = new Context();

            var values = (from w in c.writerMessages
                          join a in c.Users
                          on w.SenderName equals a.Name + " " + a.Surname
                          where w.Receiver == "a"
                          orderby w.WriterMessageID descending
                          select new UserImageMessageModel
                          {
                              ImageUrl = a.ImageUrl,
                              ID = w.WriterMessageID,
                              SenderName = w.SenderName,
                              Date = w.Date
                          })
              .Take(3)
              .ToList();

            return View(values);
        }
    }
}
