namespace NeetCodeExam.Sortings.MergeSorts;

public partial class MergeKLists
{
    
    public ListNode Sort(ListNode[] lists)
    {
        List<int> kList = new();
        foreach (var list in lists)
        {
            var tmpList = list;
            while (tmpList != null)
            {
                kList.Add(tmpList.val);
                tmpList = tmpList.next;
            }
        }

        int[] kArr = kList.ToArray();
        int[] merge = MergeSortKList2(kArr, 0, kArr.Length - 1);
        return ConvertArrayToListNode(merge);
    }
    
    public ListNode ConvertArrayToListNode(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return null;

        ListNode head = new ListNode(arr[0]);
        ListNode current = head;

        for (int i = 1; i < arr.Length; i++)
        {
            current.next = new ListNode(arr[i]);
            current = current.next;
        }

        return head;
    }
    
    public int[] Sort2(int[][] input)
    {
        int[] kList = GetKList(input);
        int[] result = MergeSortKList2(kList, 0, kList.Length - 1);
        return result;
    }

    private int[] MergeSortKList2(int[] input, int left, int right)
    {
        if (left >= right)
        {
            return input;
        }

        int mid = (left + right) / 2;
        
        //sort left
        MergeSortKList2(input, left, mid);
        
        //sort right
        MergeSortKList2(input, mid + 1, right);
        
        int[] result = Merge(input, left, mid, right);
        
        return result;
    }

    private int[] Merge(int[] input, int left, int mid, int right)
    {
        int leftLength = mid - left + 1;
        int rightLength = right - mid;
        
        int[] tmpLeft = new int[leftLength];
        int[] tmpRight = new int[rightLength];

        int leftIndex = 0;
        int rightIndex = 0;
        
        for (int i = leftIndex; i < leftLength; i++)
            tmpLeft[i] = input[left + i];
        
        for (int i = rightIndex; i < rightLength; i++) 
            tmpRight[i] = input[(mid + 1) + i];

        leftIndex = 0;
        rightIndex = 0;
        int tmpIndex = left;
        
        while (leftIndex < leftLength && rightIndex < rightLength)
        {
            if (tmpLeft[leftIndex] < tmpRight[rightIndex])
            {
                input[tmpIndex] = tmpLeft[leftIndex];
                leftIndex++;
            }
            else
            {
                input[tmpIndex] = tmpRight[rightIndex];
                rightIndex++;
            }

            tmpIndex++;
        }

        while (leftIndex < leftLength)
        {
            input[tmpIndex] = tmpLeft[leftIndex];
            leftIndex++;
            tmpIndex++;
        }

        while (rightIndex < rightLength)
        {
            input[tmpIndex] = tmpRight[rightIndex];
            rightIndex++;
            tmpIndex++;
        }

        return input;
    }

    private int[] GetKList(int[][] input)
    {
        int[] kList = new int[1];
        int kIndex = 0;
        
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input[i].Length; j++)
            {
                if (kList.Length <= kIndex)
                {
                    kList = KListIncreaseLength(kList);
                }
                
                kList[kIndex] = input[i][j];
                kIndex++;
            }
            
        }

        if (kList.Length > kIndex)
        {
            kList = KListTrimLength(kList, kIndex);
        }
        return kList;
    }

    private int[] KListIncreaseLength(int[] kList)
    {
        int newLength = kList.Length * 2;
        int[] tmpArr = new int[newLength];
        for (int k = 0; k < kList.Length; k++)
        {
            tmpArr[k] = kList[k];
        }
        kList = tmpArr;
        return kList;
    }
    
    private int[] KListTrimLength(int[] kList, int newLength)
    {
        int[] tmpArr = new int[newLength];
        for (int k = 0; k < newLength; k++)
        {
            tmpArr[k] = kList[k];
        }
        kList = tmpArr;
        return kList;
    }
}