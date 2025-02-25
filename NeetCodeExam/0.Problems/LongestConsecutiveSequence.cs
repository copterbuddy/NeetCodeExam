namespace NeetCodeExam.Problems;

public class LongestConsecutiveSequence
{
    public int LongestConsecutive(int[] nums)
    {
        Dictionary<int, int> map = nums.Distinct().ToDictionary((k) => k, (v) => v);
        Dictionary<int, int> result = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int length = 0;
            int prev = nums[i];
            while (map.ContainsKey(prev))
            {
                length++;
                prev++;
                result[nums[i]] = length;
            }
        }

        var arrResult = result.Select(x => new { key = x.Key, value = x.Value }).ToArray();
        var arrSorted = arrResult.OrderByDescending(x => x.value).ToArray();
        var maxData = arrSorted.FirstOrDefault().value;
        return maxData;
    }
}
