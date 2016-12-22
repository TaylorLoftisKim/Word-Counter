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
      Get["/"] = _ => View["index.cshtml"];
      Post["/count"] = _ =>{
        string inputSentence = Request.Form["sentenceInput"];
        string inputWordFind = Request.Form["wordInput"];
        Counter newCounter = new Counter(inputSentence, inputWordFind);
        int output = newCounter.WordCount();
        return View["output.cshtml", output];
      };
    }
  }
}
