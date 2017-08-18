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
		private readonly ILoggerFactory _loggerFactory;

		public HomeController(ILoggerFactory loggerFactory)
		{
			_loggerFactory = loggerFactory;
		}

		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			var logger = _loggerFactory.Create<HomeController>();
			logger.Debug("Message du Controller MVC");

			return View();
		}
	}
}
