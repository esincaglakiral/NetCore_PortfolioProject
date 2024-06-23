using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Areas.Writer.Models;

namespace WebUI.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Route("Writer/[controller]/[action]")]
    [AllowAnonymous]
	public class RegisterController : Controller
	{
		private readonly UserManager<WriterUser> _userManager;

		public RegisterController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel model)
        {
            WriterUser writer = new WriterUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Mail,
                UserName = model.UserName,
                ImageUrl = model.ImageUrl
            };

            if (model.Password == model.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(writer, model.Password);  // Hesap oluşturma metodu

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(model);
        }
    }
}

//Tüm şifreler: 12345aA.