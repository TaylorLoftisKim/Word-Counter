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
				Dictionary <string, string> model = new Dictionary <string, string>
				{

				};
				return View["index.cshtml"];
			};
		}
	}
}
