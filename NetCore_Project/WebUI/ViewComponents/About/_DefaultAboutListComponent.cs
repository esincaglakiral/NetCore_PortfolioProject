using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.About
{
	public class _DefaultAboutListComponent : ViewComponent
	{
		AboutManager aboutManager = new AboutManager(new EFAboutDal());
		public IViewComponentResult Invoke()
		{
			var values = aboutManager.TGetlist();
			return View(values);
		}
	}
}
