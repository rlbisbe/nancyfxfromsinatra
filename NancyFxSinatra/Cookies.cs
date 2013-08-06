using System;
using Nancy;
using Nancy.Cookies;

namespace NancyFxSinatra
{
	public class Cookies : NancyModule
	{
		public Cookies ()
		{
			Get ["/cookies/list"] = parameters => {
				return Request.Cookies.Count;
			};

			Get ["/cookies/add"] = parameters => {
				return ((Response)"Hello world").AddCookie(new NancyCookie("foo", "bart"));
			};

			Get ["/cookies/show"] = parameters => {
					return Request.Cookies["foo"];
			};

		}
	}
}

