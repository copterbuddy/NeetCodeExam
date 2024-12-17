namespace NeetCodeExam.LinkedLists.Queues;

public class NumberOfStudentsUnableToEatLunch
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        int cnt = 0;
        while (cnt < students.Length && sandwiches.Length != 0)
        {
            var student = Peek(students);
            var sandwitch = Peek(sandwiches);
            if (student != sandwitch)
            {
                Enqueue(ref students, Dequeue(ref students));
                cnt++;
                continue;
            }
            Dequeue(ref students);
            Dequeue(ref sandwiches);
            cnt = 0;
        }

        return sandwiches.Length;
    }
    public int Peek(int[] arr)
    {
        return arr[0];
    }

    public int Dequeue(ref int[] arr)
    {
        int result = arr[0];
        int[] newArr = new int[arr.Length -1];
        for (int i = 0; i < newArr.Length; i++)
        {
            newArr[i] = arr[i +1];
        }

        arr = newArr;

        return result;
    }

    public void Enqueue(ref int[] arr, int value)
    {
        int[] newArr = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];
        }
        newArr[^1] = value;
        arr = newArr;
    }
}