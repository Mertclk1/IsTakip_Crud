using Microsoft.AspNetCore.Mvc;

namespace IsTakip.UI.Controllers
{
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult PratikSoru()
		{
			return View();
		}
	}
}
