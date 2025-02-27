using System;

namespace NeetCodeExam.Problems;

public class TwoSums
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
            {
                return new int[] { map[nums[i]], i };
            }
            int tmp = target - nums[i];
            map[tmp] = i;
        }

        return new int[] { };
    }

    public int[] TwoSum2(int[] numbers, int target)
    {
        int[] result = new int[2];
        for (int n = 0; n < numbers.Length; n++)
        {
            for (int m = 0; m < numbers.Length; m++)
            {
                if (numbers[n] == numbers[m])
                {
                    continue;
                }

                if (numbers[n] + numbers[m] == target)
                {
                    result[0] = n + 1;
                    result[1] = m + 1;
                    return result;
                }
            }
        }

        return result;
    }
}
