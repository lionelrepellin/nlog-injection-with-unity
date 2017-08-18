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
		private readonly ILoggerService _loggerService;

		public HomeController(ILoggerFactory loggerFactory)
		{
			_loggerService = loggerFactory.Create<HomeController>();
		}

		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			_loggerService.Debug("Message du Controller MVC");

			return View();
		}
	}
}
