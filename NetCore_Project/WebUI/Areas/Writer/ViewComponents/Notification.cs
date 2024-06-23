using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Writer.ViewComponents
{
	public class Notification : ViewComponent
	{
		AnnouncementManager announcement = new AnnouncementManager(new EFAnnouncementDal());
		public IViewComponentResult Invoke()
		{
			var values = announcement.TGetlist().OrderByDescending(x => x.ID).Take(3).ToList();
			return View(values);
		}
	}
}
