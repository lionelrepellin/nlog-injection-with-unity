using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestInjectNlog.Logger
{
	public class LoggerService : ILoggerService
	{
		private readonly ILogger _logger;

		public LoggerService(ILogger logger)
		{
			_logger = logger;
		}

		public void Debug(string message)
		{
			_logger.Debug(message);
		}
	}
}