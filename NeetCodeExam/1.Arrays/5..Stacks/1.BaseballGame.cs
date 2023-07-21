using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeExam;
partial class Program
{
    public static int CalPoints(string[] operations) {
        int index = 0;
        string[] stacks = new string[operations.Length];
        foreach (var item in operations)
        {
            int number = 0;
            bool IsNumber = Int32.TryParse(item, out number);
            if (IsNumber)
            {
                stacks[index] = item;
            }
            else
            {
                if (item == "C")
                {
                    stacks[index-1] = null;
                    stacks[index] = null;
                }
            }
            index++;
        }
        
        int sum = 0;
        for (int i = 0; i < stacks.Length; i++)
        {
            if (int.TryParse(stacks[i], out int num))
            {
                sum += num;
            }
        }
        
        return sum;
    }
}