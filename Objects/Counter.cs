using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCount.Objects
{
  public class Counter
  {
    private string _inputString;
    private string _stringToCount;
    private string _countedString;

    public Counter(string newInputString, string newStringToCount, string newCountedString)
    {
      _inputString = newInputString.ToLower();
      _stringToCount = newStringToCount.ToLower();
      _CountedtString = newCountedString.ToLower();
    }

    public string FindCount()
    {
      Regex regToCount = new Regex(_stringToCount);
      string outputString = regToCount.Replace(_inputString, _CountedString);
      return outputString;
    }
  }
}
