using System;

namespace WordCounter.Objects
{
  public class UserInput
  {
    public static int GetWordCount(string readString, string readWord)
    {
      int wordCount = 0;
      string[] readWords = readString.Split();

      foreach (string word in readWords)
      {
        if (word.ToUpper() == readWord.ToUpper())
        {
          wordCount++;
        }
      }
      return wordCount;
    }
  }
}
