using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.ViewComponents.Dashboard
{
	public class _DefaultAdminNavbarMessageList : ViewComponent
	{
		private readonly UserManager<WriterUser> _userManager;
		WriterMessageManager message = new WriterMessageManager(new EFWriterMessageDal());

		public _DefaultAdminNavbarMessageList(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}


		public async Task<IViewComponentResult> InvokeAsync()
		{
			string p = "admin@gmail.com";
			Context c = new Context();

			var values = (from w in c.WriterMessages
						  join a in c.Users
						  on w.SenderName equals a.Name + " " + a.Surname
						  where w.Receiver == "admin@gmail.com"
						  orderby w.WriterMessageID descending
						  select new UserImageMessageModel
						  {
							  ImageUrl = a.ImageUrl,
							  ID = w.WriterMessageID,
							  SenderName = w.SenderName,
							  Date = w.Date
						  })
			  .Take(3)
			  .ToList();

			return View(values);


		}

	}
}
