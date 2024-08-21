using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeExam.Test.Arrays.StaticArray;
public class RemoveDuplicateTest
{
    [Fact]
    public void TestRemoveDuplicate_Success_Case1()
    {
        int[] nums = new int[] { 1, 1, 2 };
        int result = Program.RemoveDuplicate(nums);
        Assert.Equal(2, result);
    }

    [Fact]
    public void TestRemoveDuplicate_Success_Case2()
    {
        int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int result = Program.RemoveDuplicate(nums);
        Assert.Equal(5, result);
    }
}
