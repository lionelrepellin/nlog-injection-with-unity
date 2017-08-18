using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestInjectNlog.Logger;

namespace TestInjectNlog.Controllers
{
	public class HomeController : Controller
	{
		//private readonly ILoggerService _loggerService;
		
		//public HomeController(ILoggerService loggerService)
		//{
		//	_loggerService = loggerService;
		//}
		

		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			//_loggerService.Debug("Message à la con...");

			return View();
		}
	}
}
