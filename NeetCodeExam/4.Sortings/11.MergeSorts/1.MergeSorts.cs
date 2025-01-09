

namespace NeetCodeExam.Sortings;

public class MergeSorts
{
    public int[] Sort(int[] input)
    {
        MergeSort(input, 0, input.Length);
        return input;
    }

    private void MergeSort(int[] input, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        int middle = (right + left) / 2;

        //sort right
        MergeSort(input, middle + 1, right);

        //sort left
        MergeSort(input, left, middle);

        //merge
        Merge(input, left, middle, right);
    }

    private void Merge(int[] input, int left, int middle, int right)
    {
        throw new NotImplementedException();
    }
}
