using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestInjectNlog.Logger
{
	public class LoggerService : ILoggerService
	{
		private readonly NLog.Logger _logger;

		public LoggerService(Type type)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));
			_logger = LogManager.GetLogger(type.FullName);
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