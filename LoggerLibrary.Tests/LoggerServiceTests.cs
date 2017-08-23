using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLibrary.Tests
{
	[TestFixture]
	public class LoggerServiceTests
	{
		private Mock<ILoggerService> _serviceMock;
		private FakeService _fakeService;

		[SetUp]
		public void Initialize()
		{
			_serviceMock = new Mock<ILoggerService>();

			var factoryMock = new Mock<ILoggerFactory>();
			factoryMock.Setup(f => f.Create<FakeService>()).Returns(_serviceMock.Object);

			_fakeService = new FakeService(factoryMock.Object);
		}

		[Test]
		public void Debug_WhenDoSomethingIsCalled_ItCallsDebug()
		{
			_serviceMock.Setup(s => s.Debug("debug message"));

			_fakeService.DoSomething();

			_serviceMock.VerifyAll();
		}

		[Test]
		public void Warn_WhenDoSomethingElseIsCalled_ItCallsWarn()
		{
			_serviceMock.Setup(s => s.Warn("warning message"));

			_fakeService.DoSomethingElse();

			_serviceMock.VerifyAll();
		}

		[Test]
		public void Info_WhenDoSomethingIsCalled_ItCallsDebug()
		{
			_serviceMock.Setup(s => s.Info("info message"));

			_fakeService.DoEverythingYouWant();

			_serviceMock.VerifyAll();
		}

		[Test]
		public void Trace_WhenMakeTraceInTheDesertIsCalled_ItCallsTrace()
		{
			_serviceMock.Setup(s => s.Trace("trace message"));

			_fakeService.MakeTraceInTheDesert();

			_serviceMock.VerifyAll();
		}

		[Test]
		public void Error_WhenFooIsCalled_ItCallsErrorWithException()
		{
			_serviceMock.Setup(s => s.Error(It.IsAny<DivideByZeroException>()));

			_fakeService.Foo();

			_serviceMock.VerifyAll();
		}

		[Test]
		public void Error_WhenBarIsCalled_ItCallsErrorWithExceptionAndMessage()
		{
			_serviceMock.Setup(s => s.Error(It.IsAny<DivideByZeroException>(), "an error has occurred"));

			_fakeService.Bar();

			_serviceMock.VerifyAll();
		}

		[Test]
		public void Error_WhenErrorWithMessageOnlyIsCalled_ItCallsErrorWithMessage()
		{
			_serviceMock.Setup(s => s.Error("another error has occurred"));

			_fakeService.ErrorWithMessageOnly();

			_serviceMock.VerifyAll();
		}
	}
}
