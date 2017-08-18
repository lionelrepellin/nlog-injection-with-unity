namespace TestInjectNlog.Logger
{
	public class LoggerFactory : ILoggerFactory
	{
		public ILogger Create<T>() where T : class
		{
			return new LoggerService(typeof(T));
		}
	}
}