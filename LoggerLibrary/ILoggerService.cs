using System;

namespace LoggerLibrary
{
	public interface ILoggerService
	{
		string Name { get; }

		void Info(string message);
		void Debug(string message);
		void Trace(string message);
		void Error(Exception exception);
		void Error(string message);
		void Error(Exception exception, string message);
		void Warn(string message);		
	}
}