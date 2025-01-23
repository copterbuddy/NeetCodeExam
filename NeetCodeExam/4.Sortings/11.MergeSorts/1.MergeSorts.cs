namespace NeetCodeExam.Sortings.MergeSorts;

public class MergeSorts
{
    public int[] Sort(int[] input)
    {
        // return MergeSort(input, 0, input.Length);
        return MergeSort(input, 0, input.Length - 1);
    }

    private int[] MergeSort(int[] input, int left, int right)
    {
        if (left >= right) return input;
        
        int middle = (right + left) / 2;
    
        //sort left
        MergeSort(input, left, middle);
        //sort right
        MergeSort(input, middle + 1, right);
        //merge
        Merge(input, left, middle, right);

        return input;
    }
    
    private void Merge(int[] input, int left, int middle, int right)
    {
        int leftSize = (middle - left) + 1;
        int rightSize = right - middle;
    
        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];
        
        int leftIndex ,rightIndex;
    
        for (leftIndex = 0; leftIndex < leftSize; ++leftIndex)
        {
            leftArray[leftIndex] = input[left + leftIndex];
        }
    
        for (rightIndex = 0; rightIndex < rightSize; ++rightIndex)
        {
            rightArray[rightIndex] = input[middle + 1 + rightIndex];
        }
    
        leftIndex = 0;
        rightIndex = 0;
        int mergeIndex = left;
    
        while (leftIndex < leftSize && rightIndex < rightSize)
        {
            if (leftArray[leftIndex] < rightArray[rightIndex])
            {
                input[mergeIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                input[mergeIndex] = rightArray[rightIndex];
                rightIndex++;
            }
            mergeIndex++;
        }
    
        while (leftIndex < leftSize)
        {
            input[mergeIndex] = leftArray[leftIndex];
            leftIndex++;
            mergeIndex++;
        }
    
        while (rightIndex < rightSize)
        {
            input[mergeIndex] = rightArray[rightIndex];
            rightIndex++;
            mergeIndex++;
        }
    }
}
