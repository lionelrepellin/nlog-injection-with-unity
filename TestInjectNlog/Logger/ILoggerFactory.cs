namespace TestInjectNlog.Logger
{
	public interface ILoggerFactory
	{
		ILogger Create<T>() where T : class;
	}
}