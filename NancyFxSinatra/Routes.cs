using System;
using Nancy;

namespace NancyFxSinatra
{
	public class Routes : NancyModule
	{
		public Routes ()
		{
			Get["/routes"] = _ => "Response with GET\n";
			Post["/routes"] = _ => "Response with POST\n";
			Put["/routes"] = _ => "Response with Put\n";

			Get ["/actions/ok"] = _ => 202;
			Get ["/actions/auth"] = _ => HttpStatusCode.Forbidden;
			Get ["/actions/text"] = _ => "Hello World";

			Get["/actions/error"] = _ => {
				Response res =  ((Response)"Error with message\n");
				res.StatusCode = HttpStatusCode.InternalServerError;
				return res;
			};

		}
	}
}

