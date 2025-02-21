namespace NeetCodeExam.Problems;

public class TopKFrequents
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> map = new();
        for (int i = 0; i < nums.Length; i++)
        {
            int value = nums[i];
            if (map.ContainsKey(value) == false)
            {
                map[value] = 1;
            }
            else
            {
                map[value]++;
            }
        }

        var mapSorted = map.Select(m => new { key = m.Key, value = m.Value }).ToArray();
        Array.Sort(mapSorted, (a, b) => b.value.CompareTo(a.value));
        return mapSorted.Take(k).Select(x => x.key).ToArray();
    }
}
