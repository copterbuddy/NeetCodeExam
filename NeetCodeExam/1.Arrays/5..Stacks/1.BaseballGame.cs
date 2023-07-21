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
        foreach (var item in operations)
        {
            int number = 0;
            bool IsNumber = Int32.TryParse(item, out number);
            if (IsNumber)
            {
                operations[index] = item;
            }
            else
            {
                if (item == "C")
                {
                    operations[index-1] = null;
                    operations[index] = null;
                }
            }
            index++;
        }
        
        int sum = 0;
        for (int i = 0; i < operations.Length; i++)
        {
            if (int.TryParse(operations[i], out int num))
            {
                sum += num;
            }
        }
        
        return sum;
    }
}