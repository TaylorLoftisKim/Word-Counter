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
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["output"] = _ =>{
        string inputSentence = Request.Form("sentenceInput");
        string inputWordFind = Request.Form("wordInput");
        Counter newCounter = new Counter(inputSentence, inputWordFind);
        int output = newCounter.WordToNumber();
        return View["output.cshtml", output];
      };
    }
  }
}
