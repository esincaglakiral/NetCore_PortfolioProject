using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Dashboard
{
	public class _DefaultToDoList : ViewComponent
	{
		ToDoListManager td = new ToDoListManager(new EFToDoListDal());
		Context context = new Context();
		public IViewComponentResult Invoke()
		{

			var values = context.ToDoLists.OrderByDescending(x => x.AddDate).ToList();
			return View(values);
		}
	}
}
