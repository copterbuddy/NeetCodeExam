namespace NeetCodeExam.BinarySearch;

public class SearchArray {
    
/*
    |
    
   1. want 8
   
    s       m          e
    1,2,3,4,5,6,7,8,9,10
    
    2. length /2
    want 8
    s   m    e
    6,7,8,9,10
    
    3. got value
    return 8
*/
    
    public int GetNumber(int[] input, int want)
    {
        int start = 0;
        int end = input.Length - 1;
        int mid;
        
        while (start <= end)
        {
            mid = (start + end) / 2;
            
            if (input[mid] < want)
            {
                start = mid + 1;
            }
            else if(input[mid] > want)
            {
                end = mid - 1;
            }
            else
            {
                return mid;
            }
        }

        return -1;
    }
}