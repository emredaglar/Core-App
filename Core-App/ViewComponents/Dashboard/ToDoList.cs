using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.ViewComponents.Dashboard
{
    public class ToDoList:ViewComponent
    {
        ToDoListManager _toDoListManager=new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = _toDoListManager.TGetList();
            return View(values);
        }
    }
}
