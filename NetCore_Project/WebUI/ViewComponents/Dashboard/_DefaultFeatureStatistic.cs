using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Dashboard
{
    public class _DefaultFeatureStatistic : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Where(x => x.Status == false).Count();
            ViewBag.v3 = context.Messages.Where(x => x.Status == true).Count();
            ViewBag.v4 = context.Portfolios.Count();

            return View();
        }
    }
}
