using NUnit.Framework;
using System;
using System.Text;
using Nancy;
using Nancy.Testing;

namespace NancyFxSinatraTests
{
	/// <summary>
	/// https://github.com/NancyFx/Nancy/wiki/Testing-your-application
	/// </summary>

	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestPut ()
		{
			var bootstrapper = new DefaultNancyBootstrapper();
			var browser = new Browser(bootstrapper);

			var result = browser.Put("/routes", with => {
				with.HttpRequest();
			});

			Assert.AreEqual (HttpStatusCode.OK, result.StatusCode);
			Assert.AreEqual ("Response with Put\n", result.Body.AsString());
		}

		[Test ()]
		public void TestNotFound ()
		{
			var bootstrapper = new DefaultNancyBootstrapper();
			var browser = new Browser(bootstrapper);

			var result = browser.Delete("/routes", with => {
				with.HttpRequest();
			});

			Assert.AreEqual (HttpStatusCode.MethodNotAllowed, result.StatusCode);
		}
	}
}

