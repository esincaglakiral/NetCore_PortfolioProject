using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Route("Writer/WriterMessage")]
   // [Route("Writer/{controller}/{action}/{id?}")]  //böyle de yapılabilir
	public class WriterMessageController : Controller
	{
		WriterMessageManager writerMessageManager = new WriterMessageManager(new EFWriterMessageDal());

		private readonly UserManager<WriterUser> _userManager;

		public WriterMessageController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		[Route("")]
		[Route("ReceiverMessage")]
		public async Task<IActionResult> ReceiverMessage(string p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p = values.Email;

			var messageList = writerMessageManager.GetListReceiverMessage(p);
			return View(messageList);
		}



		[Route("")]
		[Route("SenderMessage")]
		public async Task<IActionResult> SenderMessage(string p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p = values.Email;

			var messageList = writerMessageManager.GetListSenderMessage(p);
			return View(messageList);
		}



		[Route("MessageDetails/{id}")]
		[HttpGet]
		public IActionResult MessageDetails(int id)
		{
			WriterMessage message = writerMessageManager.TGetByID(id);
			return View(message);
		}


		[Route("ReceiverMessageDetails/{id}")]
		[HttpGet]
		public IActionResult ReceiverMessageDetails(int id)
		{
			WriterMessage message = writerMessageManager.TGetByID(id);
			return View(message);
		}


		[HttpGet]
		[Route("")]
		[Route("SendMessage")]
		public IActionResult SendMessage()
		{
			return View();
		}


		[HttpPost]
		[Route("")]
		[Route("SendMessage")]
		public async Task<IActionResult> SendMessage(WriterMessage p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			string mail = values.Email;
            string name = values.Name + " " + values.Surname;

            //string name = ($"{values.Name} {values.Surname}");
			p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			p.Sender = mail;
			p.SenderName = name;
			Context ca = new Context();
			var usernamesurname = ca.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
			if (usernamesurname == null)
			{
				ModelState.AddModelError("", "Sistemde Kayıtlı Mail Adresi Bulunamadı");
			}
			else
			{
				p.ReceiverName = usernamesurname;
				writerMessageManager.TAdd(p);
				return RedirectToAction("SenderMessage");
			}
			return View();
		}


	}
}
