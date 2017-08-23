using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLibrary.Tests
{
	public class FakeService
	{
		private readonly ILoggerService _loggerService;

		public FakeService(ILoggerFactory loggerFactory)
		{
			_loggerService = loggerFactory.Create<FakeService>();
		}

		public void DoSomething()
		{
			_loggerService.Debug("debug message");
		}

		public void DoSomethingElse()
		{
			_loggerService.Warn("warning message");
		}

		public void DoEverythingYouWant()
		{
			_loggerService.Info("info message");
		}

		public void MakeTraceInTheDesert()
		{
			_loggerService.Trace("trace message");
		}

		public void Foo()
		{
			var ageOfCaptain = 72;

			try
			{
				var result = ageOfCaptain / 0;
			}
			catch (DivideByZeroException e)
			{
				_loggerService.Error(e);
			}
		}

		public void Bar()
		{
			var ageOfCaptain = 72;

			try
			{
				var result = ageOfCaptain / 0;
			}
			catch (DivideByZeroException e)
			{
				_loggerService.Error(e, "an error has occurred");
			}
		}

		public void ErrorWithMessageOnly()
		{
			_loggerService.Error("another error has occurred");
		}
	}
}
