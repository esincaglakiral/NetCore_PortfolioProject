using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
	public class ContactController : Controller
	{
		MessageManager messageManager = new MessageManager(new EFMessageDal());
		public IActionResult Index()
		{
			var values = messageManager.TGetlist();
			return View(values);
		}


		public IActionResult ContactDetails(int id)
		{
			var values = messageManager.TGetByID(id);
			return View(values);
		}

		public IActionResult DeleteContact(int id)
		{
			var values = messageManager.TGetByID(id);
			values.Status = false;
			messageManager.TUpdate(values);
			return RedirectToAction("Index");
		}

	}
}
