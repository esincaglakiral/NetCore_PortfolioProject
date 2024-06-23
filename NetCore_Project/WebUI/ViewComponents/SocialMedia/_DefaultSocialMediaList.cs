using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.SocialMedia
{
	public class _DefaultSocialMediaList : ViewComponent
	{
		SocialMediaManager socialMediaManager = new SocialMediaManager(new EFSocialMediaDal());

		public IViewComponentResult Invoke()
		{
			var values = socialMediaManager.TGetlist();
			return View(values);
		}
	}
}
