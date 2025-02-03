namespace NeetCodeExam.Sortings.QuickSort;

public class QuickSort {
    
    public int[] Sort(int[] input)
    {
        var result = SortArray(input, 0, input.Length - 1);
        return result;
    }

    public int[] SortArray(int[] input,int start,int end)
    {
        if (start >= end) return input;
        
        var pivotIndex = PartitionArray(input, start, end);
        
        input = SortArray(input, start, pivotIndex - 1);
        input = SortArray(input, pivotIndex + 1, end);
        
        return input;
    }

    private static int PartitionArray(int[] input, int start, int end)
    {
        int pv = input[end];
        int swapper = start - 1;
        for (int current = start; current < end; current++)
        {
            if (input[current] < pv)
            {
                swapper++;
                
                if (swapper < current)
                {
                    (input[current], input[swapper]) = (input[swapper], input[current]);
                }
            }
        }
        int pivotIndex = swapper + 1;
        (input[pivotIndex], input[end]) = (input[end], input[pivotIndex]);
        return pivotIndex;
    }

    public List<Pair> Sort(List<Pair> pairs)
    {
        return SortObject(pairs, 0, pairs.Count - 1);
    }
    
    public List<Pair> SortObject(List<Pair> pairs, int start, int end)
    {
        if (start >= end) return pairs;

        var pvIndex = PartitionObject(pairs, start, end);

        SortObject(pairs, start, pvIndex - 1);
        SortObject(pairs, pvIndex + 1, end);
        
        return pairs;
    }

    private int PartitionObject(List<Pair> pairs, int start, int end)
    {
        var pv = pairs[end];
        var swapper = start - 1;
        for (int current = start; current < end; current++)
        {
            if (pairs[current].Key < pv.Key)
            {
                swapper++;

                if (swapper < current)
                {
                    (pairs[swapper], pairs[current]) = (pairs[current], pairs[swapper]);
                }
            }
        }
        
        var pvIndex = swapper + 1;
        (pairs[pvIndex], pairs[end]) = (pairs[end], pairs[pvIndex]);
        return pvIndex;
    }
}