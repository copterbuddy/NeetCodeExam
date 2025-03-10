using System;
using System.Collections.Immutable;

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

    public int[] TwoSum2_Fixed(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int sum = numbers[left] + numbers[right];
            if (sum == target)
            {
                return new int[] { left + 1, right + 1 };
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return new int[] { -1, -1 };
    }

    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> res = new();
        var sNums = nums.OrderBy(x => x).ToArray();
        int i = 0;
        while (i < sNums.Length - 1)
        {
            if (i > 0 && sNums[i] == sNums[i - 1])
            {
                i++;
                continue;
            }

            int l = i + 1;
            int r = sNums.Length - 1;
            while (l < r)
            {

                int sum = sNums[i] + sNums[l] + sNums[r];
                if (sum < 0)
                {
                    l++;
                }
                else if (sum > 0)
                {
                    r--;
                }
                else
                {
                    res.Add(new List<int>() { sNums[i], sNums[l], sNums[r] });
                    l++;

                    while (sNums[l] == sNums[l - 1] && l < r)
                    {
                        l++;
                    }
                }
            }
            i++;
        }

        return res;
    }
}
