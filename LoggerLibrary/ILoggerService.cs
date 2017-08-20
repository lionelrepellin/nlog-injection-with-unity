using System;

namespace LoggerLibrary
{
	public interface ILoggerService
	{
		string Name { get; }
		void Debug(string message);
		void Error(Exception exception);
	}
}