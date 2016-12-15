using Nancy;
using System;
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
				return View["index.cshtml"];
			};
			Post["/output"] = _ =>
			{
				string inputSentence = Request.Form["sentenceInput"];
				string inputWordFind = Request.Form["wordInput"];
				WordCount newWordCount = new WordCount(inputSentence, inputWordFind);
				return View["output.cshtml", output];
			};
		}
	}
}
