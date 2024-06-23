﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebUI.Controllers
{
	public class ExperienceAjaxController : Controller
	{
		ExperienceManager experienceManager = new ExperienceManager(new EFExperienceDal());
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult ListExperience()
		{
			var values = JsonConvert.SerializeObject(experienceManager.TGetlist());
			return Json(values);
		}

		[HttpPost]
		public IActionResult AddExperience(Experience p)
		{
            experienceManager.TAdd(p);
			var values = JsonConvert.SerializeObject(p);
			return Json(values);
		}


		public IActionResult GetById(int ExperienceID)
		{
			var v = experienceManager.TGetByID(ExperienceID);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);

        }


		public IActionResult DeleteExperience(int id)
		{
            var v = experienceManager.TGetByID(id);
			experienceManager.TDelete(v);
			return NoContent();

        }


        [HttpPost]
        public IActionResult UpdateExperience(Experience p)
        {
            experienceManager.TUpdate(p);
			var values = JsonConvert.SerializeObject(p);
			return Json(values);
        }
    }
}
