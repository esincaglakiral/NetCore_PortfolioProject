using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace WebUI.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skill = new SkillManager(new EFSkillDal());

        public IActionResult Index()
        {
            var values = skill.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            skill.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = skill.TGetByID(id);
            skill.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = skill.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill p)
        {
            skill.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
