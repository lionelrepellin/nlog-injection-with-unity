using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LoggerLibrary
{
	public class LoggerService : ILoggerService
	{
		public string Name => _logger.Name;

		private readonly ILogger _logger;

		public LoggerService(Type type)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));

			_logger = LogManager.GetLogger(type.FullName);
		}

		public void Debug(string message) => _logger.Debug(message);

		public void Info(string message) => _logger.Info(message);

		public void Trace(string message) => _logger.Trace(message);

		public void Error(Exception exception) => _logger.Error(exception);

		public void Error(Exception exception, string message) => _logger.Error(exception, message);

		public void Error(string message) => _logger.Error(message);

		public void Warn(string message) => _logger.Warn(message);		
	}
}