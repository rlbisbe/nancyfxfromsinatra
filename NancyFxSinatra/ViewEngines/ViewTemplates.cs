using System;

namespace NancyFxSinatra
{
	public class ViewTemplates : Nancy.NancyModule
	{
		public ViewTemplates ()
		{
			Get["/ViewEngines/Empty"] = _ => View["ViewEngines/EmptyTemplate.html"];

			Get ["/ViewEngines/WithData"] = _ => {
				var model = new { 
					Name = "John Smith", 
					Children = new []{"Mike", "Bob", "James"}
				};

				return View["ViewEngines/TemplateWithData.html", model];
			};
		}
	}
}

