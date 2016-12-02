using Nancy;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				{
					Dictionary <string, string> model = new Dictionary <string, string>();
					model["HasResponse"] = false;
					return View["index.cshtml", model];
				};
				Post["/"] = _ =>
				{
					Dictionary<string, string> model = new Dictionary<string, string>();
					model["HasResponse"] = true;
					return View["index.cshtml" model];
				}
			};
		}
	}
}
