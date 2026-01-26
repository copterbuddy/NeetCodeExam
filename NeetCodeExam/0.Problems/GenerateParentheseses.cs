using System.Text;

namespace NeetCodeExam.Problems;

public class GenerateParentheseses
{
    public List<string> GenerateParenthesis(int n)
    {
        List<string> result = [];
        StringBuilder current = new();
        void Solve(int open, int close)
        {
            if(open == n && close == n)
            {
                result.Add(current.ToString());
                return;
            }

            if (open < n)
            {
                current.Append('(');
                Solve(open + 1, close);
                current.Length -= 1;
            }

            if (close < open) 
            {
                current.Append(')');
                Solve(open, close + 1);
                current.Length -= 1;
            }
        }

        Solve(0, 0);
        return result;
    }
}
