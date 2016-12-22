using Xunit;
using WordCounter.Objects;

namespace WordCounterTests
{
  public class CounterTests
  {
    [Theory]

    [InlineData("t", "t", 1)]

    [InlineData("taylor", "taylor", 1)]

    [InlineData("taylor codes", "taylor", 1)]

    [InlineData("Taylor writes code and he learns how to code", "code", 2)]

    public void Test_TestRepeatCounter_True(string inputSentence, string inputWordFind, int wordFound)
    {
      Counter wordCounted = new Counter(inputSentence, inputWordFind);
      int testWord = wordCounted.WordCount();

      Assert.Equal(testWord, wordFound);
    }
  }
}
