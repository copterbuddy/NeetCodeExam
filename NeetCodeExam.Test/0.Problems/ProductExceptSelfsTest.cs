using System;

namespace NeetCodeExam.Problems;

public class ProductExceptSelfsTest
{
    ProductExceptSelfs app = new();

    [Fact]
    public void TestLongestConsecutive_Success_Case1()
    {
        int[] nums = [1, 2, 4, 6];
        int[] result = app.ProductExceptSelf(nums);
        int[] want = [48, 24, 12, 8];
        Assert.Equivalent(want, result);
    }

    [Fact]
    public void TestLongestConsecutive_Success_Case2()
    {
        int[] nums = [-1, 0, 1, 2, 3];
        int[] result = app.ProductExceptSelf(nums);
        int[] want = [0, -6, 0, 0, 0];
        Assert.Equivalent(want, result);
    }
}
