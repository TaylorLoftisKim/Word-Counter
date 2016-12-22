using System;

namespace WordCounter.Objects
{
  public class Counter
  {
    private string _inputtedSentence;
    private string _inputtedWordFind;
    private string[] _sentenceSplit;

    public Counter(string inputSentence, string inputWordFind)
    {
      _inputtedSentence = inputSentence;
      _inputtedWordFind = inputWordFind;
      SetSentenceSplit();
    }

    public string GetInputtedSentence()
    {
      return _inputtedSentence;
    }

    public void SetInputtedSentence(string newSentence)
    {
      _inputtedSentence = newSentence;
    }

    public string GetInputtedWordFind()
    {
      return _inputtedWordFind;
    }

    public void SetInputtedWordFind(string newWordFind)
    {
      _inputtedWordFind = newWordFind;
    }

    public void SetSentenceSplit()
    {
      _sentenceSplit = _inputtedSentence.Split(' ');
    }

    public int WordCount()
    {
      int wordAmount = 0;

      for (int i = 0; i < _sentenceSplit.Length; i++)
      {
        if (_sentenceSplit[i] == _inputtedWordFind)
        {
          wordAmount += 1;
        }
      }
      return wordAmount;
    }
  }
}
