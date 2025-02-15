namespace NeetCodeExam.Problems;

public class ContainDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, byte> result = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (result.ContainsKey(nums[i]) == false)
            {
                result.Add(nums[i], byte.MinValue);
                continue;
            }

            return true;
        }
        return false;
    }
}
