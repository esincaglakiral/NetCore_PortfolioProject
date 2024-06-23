using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Writer.Controllers
{
    [Area("Writer")] //Hangi area olduğu belirtiyoruz
                     // [Authorize]
    public class DefaultController : Controller
	{
        AnnouncementManager announcementManager = new AnnouncementManager(new EFAnnouncementDal());

        public IActionResult Index()
		{
            var values = announcementManager.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            Announcement announcement = announcementManager.TGetByID(id);
            return View(announcement);
        }
    }
}
