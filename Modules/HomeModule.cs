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
      Post["outputSentence"] = _ =>
      {
        string inputSentence = Request.Form("sentenceInput");
        string inputWordFind = Request.Form("wordInput");
        Counter newCounter = new Counter(inputSentence, inputWordFind);
        int outputSentence = newCounter.WordToNumber();
        return View["output.cshtml", output];
      };
    }
  }
}
