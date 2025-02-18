using System;

namespace NeetCodeExam.Problems;

public class LongestConsecutiveSequenceTest
{
    LongestConsecutiveSequence app = new();

    [Fact]
    public void TestLongestConsecutive_Success_Case1()
    {
        int[] nums = [2, 20, 4, 10, 3, 4, 5];
        int result = app.LongestConsecutive(nums);
        Assert.Equivalent(4, result);
    }

    [Fact]
    public void TestLongestConsecutive_Success_Case2()
    {
        int[] nums = [0, 3, 2, 5, 4, 6, 1, 1];
        int result = app.LongestConsecutive(nums);
        Assert.Equivalent(7, result);
    }
}
