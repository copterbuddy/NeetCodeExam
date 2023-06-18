using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeExam.Test.StaticArray;
public class RemoveElementTest
{
    [Fact]
    public void TestRemoveElementTest_Success_Case1()
    {
        int[] nums = new int[] { 3, 2, 2, 3 };
        int val = 3;
        int result = Program.RemoveElement(nums, val);
        Assert.Equal(2, result);
    }
    [Fact]
    public void TestRemoveElementTest_Success_Case2()
    {
        int[] nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;
        int result = Program.RemoveElement(nums, val);
        Assert.Equal(5, result);
    }
}
