using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{

    public class ExperienceController : Controller
    {
        ExperienceManager experiences = new ExperienceManager(new EFExperienceDal());
        public IActionResult Index()
        {
            var values = experiences.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experiences.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = experiences.TGetByID(id);
            experiences.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var values = experiences.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience p)
        {
            experiences.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
