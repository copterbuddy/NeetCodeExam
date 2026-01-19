using System.Text;

namespace NeetCodeExam.Problems;

public class GenerateParentheseses
{
    public List<string> GenerateParenthesis(int n)
    {
        List<string> result = [];
        StringBuilder current = new();
        void Solve(List<string> r,StringBuilder c,int open, int close, int nn)
        {
            if(nn == open && open == close)
            {
                r.Add(c.ToString());
                return;
            }

            if(open < nn)
            {
                c.Append('(');
                Solve(r, c, open + 1, close, nn);
                c.Length--;
            }

            if (close < open)
            {
                c.Append(')');
                Solve(r, c, open, close + 1, nn);
                c.Length--;
            }
        }
        Solve(result, current, 0, 0, n);
        return result;
    }
}
