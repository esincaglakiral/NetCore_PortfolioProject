using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Services
{
    public class _DefaultServiceListComponent : ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EFServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceManager.TGetlist();
            return View(values);
        }
    }
}
