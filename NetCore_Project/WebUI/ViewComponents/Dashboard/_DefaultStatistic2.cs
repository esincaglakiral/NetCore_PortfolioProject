using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Dashboard
{
    public class _DefaultStatistic2 : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Experiences.Count();
            ViewBag.v2 = context.Services.Count();
            ViewBag.v3 = context.Messages.Count();
            return View();
        }
    }
}
