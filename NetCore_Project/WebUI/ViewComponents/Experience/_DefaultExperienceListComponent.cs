using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Experience
{
    public class _DefaultExperienceListComponent : ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EFExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = experienceManager.TGetlist().OrderByDescending(x => x.Date).ToList();
            return View(values);
        }
    }
}
