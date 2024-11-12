using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.ViewComponents.Dashboard
{

    public class SlideList:ViewComponent
    {
        PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values= _portfolioManager.TGetList();
            return View(values);
        }
    }
}
