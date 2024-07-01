using System.Diagnostics;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private static int intCount = 0;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Drive()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult Counter()
		{
			intCount++;
			ViewData["Count"] = intCount;
			ViewBag.Count = intCount;
			return View();
		}

		[HttpGet] //Loading the Input form
		public IActionResult Input()
		{
			ViewData["Title"] = "Input Form";
			return View();
		}

		[HttpPost] //Saving the form
		public IActionResult Output(string FirstName, string LastName)
		{
			ViewBag.FN = FirstName;
			ViewBag.LN = LastName;
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}