using LoggerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestInjectNlog.Controllers
{
	public class ValuesController : ApiController
	{
		private readonly ILoggerService _loggerService;

		public ValuesController(ILoggerFactory loggerFactory)
		{
			_loggerService = loggerFactory.Create<ValuesController>();
		}

		// GET api/values
		public IEnumerable<string> Get()
		{
			_loggerService.Debug("Message de l'ApiController");

			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}
