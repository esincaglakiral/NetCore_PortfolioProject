using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Dashboard
{
	public class _DefaultSlideList : ViewComponent
	{
		PortfolioManager portfolioManager = new PortfolioManager(new EFPortfolioDal());
		public IViewComponentResult Invoke()
		{
			var values = portfolioManager.TGetlist();
			return View(values);
		}
	}
}
