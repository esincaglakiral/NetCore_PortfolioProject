using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Dashboard
{
	public class _DefaultAdminNotificationNavBarList : ViewComponent
	{
		AnnouncementManager c = new AnnouncementManager(new EFAnnouncementDal());

		public IViewComponentResult Invoke()
		{
			var values = c.TGetlist();
			ViewBag.count = c.TGetlist().Count();
			return View(values);
		}
	}
}
