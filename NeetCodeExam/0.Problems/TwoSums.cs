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
}
