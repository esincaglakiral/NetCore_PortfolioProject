using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Dashboard
{
    public class _DefaultLastProject : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.OrderByDescending(x => x.PortfolioID).Take(4).ToList();
            return View(values);
        }
    }
}
