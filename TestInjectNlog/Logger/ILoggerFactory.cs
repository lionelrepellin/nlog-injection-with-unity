namespace TestInjectNlog.Logger
{
	public interface ILoggerFactory
	{
		ILoggerService Create<T>() where T : class;
	}
}