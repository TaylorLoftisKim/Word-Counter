using Nancy;
using System.Collections.Generic;
using WordCounter.Objects;

namespace Words
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				return View["index.cshtml"];
			};
		}
	}
}
