using Xunit;
using WordCounter.Objects;

namespace WordCounter
{
  public class CounterTests
  {
    [Fact]
    public void GetWordCount_ForSingleWord_1()
    {
      Assert.Equal(1, UserInput.GetWordCount("coding", "coding"));
    }
    [Fact]
    public void GetWordCount_ForStringOfWords_2()
    {
      Assert.Equal(2, UserInput.GetWordCount("java java", "java"));
    }
    [Fact]
    public void GetWordCount_ForMatchedWord_1()
    {
      Assert.Equal(1, UserInput.GetWordCount("coding", "coding"));
    }
    [Fact]
    public void GetWordCount_ForNoMatchedWord_0()
    {
      Assert.Equal(0, UserInput.GetWordCount("code", "programming"));
    }
  }
}
