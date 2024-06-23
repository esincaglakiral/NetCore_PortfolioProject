using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Dashboard
{
	public class _DefaultVisitorMap : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
