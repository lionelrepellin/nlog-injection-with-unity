using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoggerLibrary
{
	public class LoggerService : ILoggerService
	{
        public string Name => _logger.Name;
        
        private readonly NLog.Logger _logger;

		public LoggerService(Type type)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));

			_logger = LogManager.GetLogger(type.FullName);
		}

        public void Debug(string message) => _logger.Debug(message);
		
        public void Info(string message) => _logger.Info(message);


        public void Error(Exception exception) => _logger.Error(exception);
        
        public void Error(Exception exception, string message) => _logger.Error(exception, message); 
        

        public void Warn(string message) => _logger.Warn(message); 

        public void Warn(Exception exception, string message) => _logger.Warn(exception, message); 
	}
}