namespace NeetCodeExam.Problems;

public class ValidAnagramTest
{
    ValidAnagram app = new();

    [Fact]
    public void TestIsAnagram_Want_True_Success_Case1()
    {
        string s = "anagram";
        string t = "nagaram";
        bool result = app.IsAnagram(s, t);
        Assert.True(result);
    }

    [Fact]
    public void TestIsAnagram_Want_False_Success_Case1()
    {
        string s = "rat";
        string t = "car";
        bool result = app.IsAnagram(s, t);
        Assert.False(result);
    }

    [Fact]
    public void TestIsAnagram_Improved_Want_True_Success_Case1()
    {
        string s = "anagram";
        string t = "nagaram";
        bool result = app.IsAnagram_improved(s, t);
        Assert.True(result);
    }

    [Fact]
    public void TestIsAnagram_Improved_Want_False_Success_Case1()
    {
        string s = "rat";
        string t = "car";
        bool result = app.IsAnagram_improved(s, t);
        Assert.False(result);
    }
}
