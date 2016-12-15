using System;

namespace WordCounter.Objects
{
  public class UserInput
  {
    private string _inputSentence
    private string _inputWordFind
    private string _sentenceSplit

    public WordCounter(string inputSentence, string inputWordFind)
    {
      _inputSentence = inputSentence.To.Upper();
      _userWordToFind = inputWordFind.To.Upper();
      SentenceSplit();
    }
    
    //Gets and Sets
    public string GetInputSentence()
    {
      return _inputSentence;
    }
    public void SetInputSentence(string newSentence)
    {
      _inputSentence = newinputSentence;
    }
    public string GetInputWordFind()
    {
      return _inputWordFind;
    }
    public void SetInputWordFind(string newWordFind)
    {
      _inputWordFind = newinputWordFind;
    }
    public string GetSentenceSplit()
    {
      _sentenceSplit = sentenceSplit;
    }
    public void SetSentenceSplit(string newSentenceSplit)
    {
      _sentenceSplit = newsentenceSplit(" ");//Adding a space between each word
    }

    //Counter Method Begins
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
