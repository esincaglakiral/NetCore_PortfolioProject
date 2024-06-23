using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{

	public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDal());
        public IActionResult Index()
        {
            var values = aboutManager.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            AboutValidator validations = new AboutValidator();
            ValidationResult result = validations.Validate(about);

            if (result.IsValid)
            {
                aboutManager.TAdd(about);
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



        public IActionResult DeleteAbout(int id)
        {
            var values = aboutManager.TGetByID(id);
            aboutManager.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var values = aboutManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditAbout(About p)
        {
            aboutManager.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
