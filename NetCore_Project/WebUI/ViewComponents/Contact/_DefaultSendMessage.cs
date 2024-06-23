using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Contact
{
    public class _DefaultSendMessage : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EFMessageDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }


        //[HttpPost]
        //public IViewComponentResult Invoke(Message message)
        //{
        //    message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    message.Status = true;
        //    messageManager.TAdd(message);
        //    return View();
        //}
    }
}
