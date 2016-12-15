using System;

namespace WordCounter.Objects
{
  public class UserInput
  {
    private string _inputSentence
    private string _inputWordSearch
    private string _sentenceSplit

    public WordCounter(string inputSentence, string inputWordSearch)
    {
      _inputSentence = inputSentence.To.Upper();
      _userWordToSearch = inputWordSearch.To.Upper();
      SentenceSplit();
    }
    
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
