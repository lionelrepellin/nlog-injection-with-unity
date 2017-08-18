namespace TestInjectNlog.Logger
{
	public interface ILogger
	{
		string Name { get; }
		void Debug(string message);

	}
}