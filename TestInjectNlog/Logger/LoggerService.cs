using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace TestInjectNlog.Logger
{
	public class LoggerService : ILoggerService
	{
		//private ILogger _logger;
		private static ILogger _logger = LogManager.GetCurrentClassLogger();

		public LoggerService()
		{

		}

		//public LoggerService(ILogger logger)
		//{
		//	_logger = logger;
		//}

		public void Debug(string message)
		{
			//var logger = GetLoggerInstance();
			//logger.Debug(message);			

			_logger.Debug(message);
		}

		//private ILogger GetLoggerInstance()
		//{
		//	var callingClassType =
		//	(
		//		from frame in new StackTrace().GetFrames()
		//		let type = frame.GetMethod().DeclaringType
		//		where type != typeof(LoggerService)
		//		select type
		//	)
		//	.First().ToString();

		//	_logger = LogManager.GetLogger(callingClassType);
			
		//	return _logger;
		//}
	}
}