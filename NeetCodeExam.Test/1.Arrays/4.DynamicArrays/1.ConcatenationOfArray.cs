using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeExam.Test.DynamicArrays.Arrays;
public class ConcatenationOfArray
{
    [Fact]
    public void TestConcatenationOfArray_Success_Case1()
    {
        int[] nums = new int[] { 1, 2, 1 };
        int[] result = Program.GetConcatenation(nums);
        Assert.Equal(new int[] { 1, 2, 1, 1, 2, 1 }, result);
    }

    [Fact]
    public void TestConcatenationOfArray_Success_Case2()
    {
        int[] nums = new int[] { 1, 3, 2, 1 };
        int[] result = Program.GetConcatenation(nums);
        Assert.Equal(new int[] { 1, 3, 2, 1, 1, 3, 2, 1 }, result);
    }
}
