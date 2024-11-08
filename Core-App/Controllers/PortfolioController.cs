using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            var values = _portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            PortfolioValidator portfolioValidator = new PortfolioValidator();
            ValidationResult result = portfolioValidator.Validate(portfolio);
            if (result.IsValid)
            {
                _portfolioManager.TAdd(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = _portfolioManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            _portfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = _portfolioManager.TGetByID(id);
            _portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
