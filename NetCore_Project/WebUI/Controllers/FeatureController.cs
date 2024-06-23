using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;

namespace WebUI.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager feature = new FeatureManager(new EFFeatureDal());
        public IActionResult Index()
        {
            var values = feature.TGetlist();
            return View(values);
        }

		[HttpGet]
		public IActionResult AddFeature()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddFeature(Feature p)
		{
			feature.TAdd(p);
			return RedirectToAction("Index");
		}

        public IActionResult DeleteFeature(int id)
        {
            var values = feature.TGetByID(id);
            feature.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var values = feature.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature p)
        {
            feature.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
