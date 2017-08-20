namespace LoggerLibrary
{
	public interface ILoggerFactory
	{
		ILoggerService Create<T>() where T : class;
	}
}