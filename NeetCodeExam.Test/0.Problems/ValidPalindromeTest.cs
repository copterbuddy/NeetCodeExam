using System;

namespace NeetCodeExam.Problems;

public class ValidPalindromeTest
{
    ValidPalindrome app = new();

    [Fact]
    public void TestIsAnagram_Want_True_Success_Case1()
    {
        string s = "Was it a car or a cat I saw?";
        bool result = app.IsPalindrome(s);
        Assert.True(result);
    }

    [Fact]
    public void TestIsAnagram_Want_True_Success_Case2()
    {
        string s = "No lemon, no melon";
        bool result = app.IsPalindrome(s);
        Assert.True(result);
    }

    [Fact]
    public void TestIsAnagram_Want_True_Fail_Case1()
    {
        string s = "tab a cat";
        bool result = app.IsPalindrome(s);
        Assert.False(result);
    }
}
