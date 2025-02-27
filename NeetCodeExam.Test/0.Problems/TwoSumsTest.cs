using System;

namespace NeetCodeExam.Problems;

public class TwoSumsTest
{
    TwoSums app = new();

    [Fact]
    public void TestTwosums_Success_Case1()
    {
        int[] result = app.TwoSum([3, 4, 5, 6], 7);
        int[] want = [0, 1];
        Assert.Equivalent(want, result);
    }

    [Fact]
    public void TestTwosums2_Success_Case1()
    {
        int[] result = app.TwoSum2([1, 2, 3, 4], 3);
        int[] want = [1, 2];
        Assert.Equivalent(want, result);
    }
}
