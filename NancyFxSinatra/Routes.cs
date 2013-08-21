using System;
using Nancy;

namespace NancyFxSinatra
{
	public class Routes : NancyModule
	{
		public Routes ()
		{
			Get["/routes"] = _ => "Respuesta usando GET\n";
			Post["/routes"] = _ => "Respuesta usando POST\n";

			Get ["/actions/ok"] = _ => 202;
			Get ["/actions/auth"] = _ => HttpStatusCode.Forbidden;
			Get ["/actions/text"] = _ => "Hola Mundo";

			Get["/actions/error"] = _ => {
				Response res =  ((Response)"Error con mensaje\n");
				res.StatusCode = HttpStatusCode.InternalServerError;
				return res;
			};

		}
	}
}

