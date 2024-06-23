﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Areas.Writer.Models;

namespace WebUI.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Route("Writer/[controller]/[action]")]
	public class ProfileController : Controller
	{
		private readonly UserManager<WriterUser> _userManager;

		public ProfileController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel model = new UserEditViewModel();
			model.Name = values.Name;
			model.Surname = values.Surname;
			model.PictureURL = values.ImageUrl;
			return View(model);
		}


		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel p)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);

			if (p.Picture != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension = Path.GetExtension(p.Picture.FileName);
				var imagename = ($"{Guid.NewGuid()}{extension}");
				var savelocation = ($"{resource}/wwwroot/userimage/{imagename}");
				var stream = new FileStream(savelocation, FileMode.Create);
				await p.Picture.CopyToAsync(stream);
				user.ImageUrl = imagename;
			}
			user.Name = p.Name;
			user.Surname = p.Surname;
			user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);  //şifre güncelleme
			var result = await _userManager.UpdateAsync(user); //identity 'e bağlı user tablosunda ad soyad ve şifre günceller
			if (result.Succeeded)
			{
				return RedirectToAction("Index", "Login");
			}
			return View();
		}
	}
}
