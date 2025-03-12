using System;

namespace NeetCodeExam.Problems;

public class DailyTemperatureses
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        Stack<int> tmpStack = new();
        int[] res = new int[temperatures.Length];
        int resCount = 0;
        for (int i = 0; i < temperatures.Length; i++)
        {
            var nxt = i + 1;
            var curr = i;
            tmpStack.Push(temperatures[curr]);
            while (tmpStack.Count > 0 && nxt <= temperatures.Length - 1 && temperatures[nxt] > temperatures[curr])
            {
                if (res[curr] != 0)
                {
                    curr--;
                    continue;
                }

                tmpStack.Pop();
                int sum = nxt - curr;
                res[curr] = sum;
                resCount++;
                curr--;
            }
        }

        return res;
    }
}
