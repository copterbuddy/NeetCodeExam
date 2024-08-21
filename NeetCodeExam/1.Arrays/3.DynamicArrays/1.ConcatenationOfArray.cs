using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeExam;
partial class Program
{
    public static int[] GetConcatenation(int[] nums)
    {
        int[] newnums = new int[nums.Length*2];

        for (int i = 0; i < nums.Length * 2; i++)
        {
            int index = i;
            if (i > nums.Length-1)
            {
                index = i - (nums.Length);
            }

            newnums[i] = nums[index];
        }

        return newnums;
    }
}
