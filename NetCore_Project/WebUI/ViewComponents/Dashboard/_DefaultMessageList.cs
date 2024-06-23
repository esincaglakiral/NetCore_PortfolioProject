using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.ViewComponents.Dashboard
{
	public class _DefaultMessageList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			Context ca = new Context();
			var values = (from x in ca.Users.Where(x => !x.Name.Contains("Admin"))
						  select new UserList
						  {
							  Email = x.Email,
							  ID = x.Id,
							  Name = x.Name,
							  Surname = x.Surname,
							  ImageUrl = x.ImageUrl

						  }).ToList();

			return View(values);
		}
	}
}
