using Microsoft.AspNetCore.Mvc;

namespace Core_App.ViewComponents.Dashboard
{
    public class MapVisitor:ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
