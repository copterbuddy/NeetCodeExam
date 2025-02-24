using System;

namespace NeetCodeExam.Problems;

public class ProductExceptSelfs
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];
        Array.Fill(result, 1);

        int prev = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            prev = prev * nums[i];
            if (i + 1 > nums.Length - 1)
            {
                continue;
            }

            result[i + 1] = prev * result[i + 1];
        }

        int post = 1;
        for (int i = nums.Length - 1; i > 0; i--)
        {
            post = post * nums[i];
            if (i < 0)
            {
                continue;
            }

            result[i - 1] = post * result[i - 1];
        }

        return result;
    }
}
