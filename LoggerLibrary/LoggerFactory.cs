namespace LoggerLibrary
{
	public class LoggerFactory : ILoggerFactory
	{
		public ILoggerService Create<T>() where T : class
		{
			return new LoggerService(typeof(T));
		}
	}
}