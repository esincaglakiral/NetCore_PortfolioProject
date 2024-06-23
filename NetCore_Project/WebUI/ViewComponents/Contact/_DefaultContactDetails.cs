using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Contact
{
    public class _DefaultContactDetails : ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EFContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetlist();
            return View(values);
        }
    }
}
