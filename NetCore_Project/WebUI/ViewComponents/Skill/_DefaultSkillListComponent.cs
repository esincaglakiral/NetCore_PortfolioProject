using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Skill
{
    public class _DefaultSkillListComponent : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EFSkillDal());

        public IViewComponentResult Invoke()
        {
            var values = skillManager.TGetlist();
            return View(values);
        }
    }
}
