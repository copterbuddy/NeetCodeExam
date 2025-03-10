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
        int[] result = app.TwoSum2_Fixed([1, 2, 3, 4], 3);
        int[] want = [1, 2];
        Assert.Equivalent(want, result);
    }

    [Fact]
    public void TestThreesums3_Success_Case1()
    {
        List<List<int>> result = app.ThreeSum([-1, 0, 1, 2, -1, -4]);
        List<List<int>> want = [[-1, -1, 2], [-1, 0, 1]];
        Assert.Equivalent(want, result);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void TestThreesums3_Success_Case2()
    {
        List<List<int>> result = app.ThreeSum([0, 1, 1]);
        List<List<int>> want = [];
        Assert.Equivalent(want, result);
    }

    [Fact]
    public void TestThreesums3_Success_Case3()
    {
        List<List<int>> result = app.ThreeSum([0, 0, 0]);
        List<List<int>> want = [[0, 0, 0]];
        Assert.Equivalent(want, result);
    }

    [Fact]
    public void TestThreesums3_Success_Case4()
    {
        List<List<int>> result = app.ThreeSum([0, 0, 0, 0]);
        List<List<int>> want = [[0, 0, 0]];
        Assert.Equivalent(want, result);
    }

    [Fact]
    public void TestThreesums3_Success_Case5()
    {
        List<List<int>> result = app.ThreeSum([1, 2, -2, -1]);
        List<List<int>> want = [];
        Assert.Equivalent(want, result);
        Assert.Empty(result);
    }
}
