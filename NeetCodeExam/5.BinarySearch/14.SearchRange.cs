namespace NeetCodeExam.BinarySearch;

public class SearchRange {
    public int LowerBound(int[] input, int target)
    {
        int start = 0;
        int end = input.Length - 1;
        int mid;

        while (start <= end)
        {
            mid = start + (end - start) / 2;
            if (input[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return start;
    }

    public int UpperBound(int[] input, int target)
    {
        int start = 0;
        int end = input.Length - 1;
        int mid;

        while (start <= end)
        {
            mid = start + (end - start) / 2;
            if (input[mid] <= target)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        
        return start;
    }
}