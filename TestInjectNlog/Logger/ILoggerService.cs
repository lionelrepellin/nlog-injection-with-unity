namespace TestInjectNlog.Logger
{
	public interface ILoggerService
	{
		string Name { get; }
		void Debug(string message);
	}
}