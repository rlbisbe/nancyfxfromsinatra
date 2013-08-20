using System;

namespace NancyFxSinatra
{
	public class SampleModule : Nancy.NancyModule
	{
		public SampleModule()
		{
			Get["/"] = _ => "Hello World!";

			Get ["/hola/{name}"] = _ => "Hola " + _.name;
		}
	}
}

