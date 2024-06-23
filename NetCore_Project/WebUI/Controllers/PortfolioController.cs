using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolio = new PortfolioManager(new EFPortfolioDal());
        public IActionResult Index()
        {
            var values = portfolio.TGetlist();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio ptf)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(ptf);

            if (result.IsValid)
            {
                portfolio.TAdd(ptf);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();  
      
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolio.TGetByID(id);
            portfolio.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = portfolio.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio ptf)
        {

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(ptf);

            if (result.IsValid)
            {
                portfolio.TUpdate(ptf);
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

    }
}
