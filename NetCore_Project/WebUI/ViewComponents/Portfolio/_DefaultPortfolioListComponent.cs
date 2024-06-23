using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Portfolio
{
    public class _DefaultPortfolioListComponent : ViewComponent
    {
        PortfolioManager _portfoliomanager = new PortfolioManager(new EFPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = _portfoliomanager.TGetlist();
            return View(values);
        }

    }
}
