using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WebUI.Areas.Writer.Controllers
{
	[Area("Writer")]
	public class DashboardWriterController : Controller
	{
		private readonly UserManager<WriterUser> _userManager;

		public DashboardWriterController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.user = ($"{values.Name} {values.Surname}");

			//Weather APi
			string city = "istanbul";
			string api = "67db534b921c0d3eaffb2aefa96c322e";
			string api2 = "60b618984024156d0a007238e4396f6d";

			try
			{
				string connection = ($"http://api.openweathermap.org/data/2.5/weather?q={city}&mode=xml&lang=tr&units=metric&appid={api}");
				XDocument document = XDocument.Load(connection);
				ViewBag.weather = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
			}
			catch (Exception)
			{

				string connection = ($"http://api.openweathermap.org/data/2.5/weather?q={city}&mode=xml&lang=tr&units=metric&appid={api2}");
				XDocument document = XDocument.Load(connection);
				ViewBag.weather = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
			}

			//statistics
			Context c = new Context();
			ViewBag.message = c.WriterMessages.Where(x => x.Receiver == values.Email).Count();
			ViewBag.announcements = c.Announcements.Count();
			ViewBag.totalUser = c.Users.Count();
			ViewBag.skills = c.Skills.Count();
			return View();
		}
	}
}
