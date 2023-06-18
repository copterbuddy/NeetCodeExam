using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeExam;
partial class Program
{
    public static int RemoveElement(int[] nums, int val)
    {
        int[] newnums = new int[nums.Length];
        int l = 0;

        for (int r = 0; r < nums.Length; r++)
        {
            if (nums[r] == val)
            {
                continue;
            }

            nums[l++] = nums[r];
        }

        return l;
    }
}
