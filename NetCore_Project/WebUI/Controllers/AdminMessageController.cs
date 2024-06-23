using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EFWriterMessageDal());
        string admin = "admin@gmail.com";
        public IActionResult ReceiverMessageList()
        {

            var values = writerMessageManager.GetListReceiverMessage(admin);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {

            var values = writerMessageManager.GetListSenderMessage(admin);
            return View(values);
        }

        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            return View(values);
        }


        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            Context c = new Context(); //contextten bir nesne türetiriz
            var values = c.Users.Where(x => x.Email == p.Receiver).Select(y => ($"{y.Name} {y.Surname}")).FirstOrDefault();
            p.ReceiverName = values;
            p.Sender = admin;
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }

        public IActionResult AdminMessageDelete(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            writerMessageManager.TDelete(values);
            return RedirectToAction("ReceiverMessageList");
        }

    }
}
