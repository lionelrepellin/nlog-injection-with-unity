using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestInjectNlog.Logger
{
	public class LoggerService : ILogger
	{
		private readonly NLog.Logger _logger;
		public LoggerService(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");
			_logger = LogManager.GetCurrentClassLogger();
		}

		public string Name
		{
			get { return _logger.Name; }
		}

		public void Debug(string message)
		{
			_logger.Debug(message);
		}
	}
}