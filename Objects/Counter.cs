using System;

namespace WordCounter.Objects
{
  public class Counter
  {
    private string _inputSentence;
    private string _inputWordFind;
    private string[] _sentenceSplit;

    public WordCounter(string inputSentence, string inputWordFind)
    {
      _userSentence = inputSentence.ToLower();
      _userWordToFind = inputWordFind.ToLower();
      SentenceSplit();
    }

    public string GetInputSentence()
    {
      return _inputSentence;
    }
    public void SetInputSentence(string newSentence)
    {
      _inputSentence = newSentence;
    }
    public string GetInputWordFind()
    {
      return _inputWordFind;
    }
    public void SetInputWordFind(string newWordFind)
    {
      _inputWordFind = newWordFind;
    }
    public string GetSentenceSplit()
    {
      _sentenceSplit = sentenceSplit;
    }
    public void SetSentenceSplit(string newSentenceSplit)
    {
      _sentenceSplit = _inputSentence.Split(' ');
    }

    public int GetWordCount()
    {
      int wordCount = 0;
      for (int 1 = 0; i < _sentenceSplit.Length; i++)
      {
        if (_sentenceSplit[i] == _inputWordFind)
        {
          wordCount =+ 1;
        }
      }
      return wordCount;
    }
  }
}
