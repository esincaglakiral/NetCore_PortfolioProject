using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Dashboard
{
    public class _DefaultEndProject : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var varlues = context.Portfolios.OrderByDescending(x => x.PortfolioID).Take(5).ToList();
            return View(varlues);
        }
    }
}
