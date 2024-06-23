using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace WebUI.ViewComponents.Testimonial
{
    public class _DefaultTestimonialListComponent : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonalDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetlist();
            return View(values);
        }
    }
}
