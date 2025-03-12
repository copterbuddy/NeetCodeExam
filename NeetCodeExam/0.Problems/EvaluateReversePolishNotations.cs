namespace NeetCodeExam.Problems;

public class EvaluateReversePolishNotations
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new();
        foreach (var token in tokens)
        {
            int sum;
            int a;
            int b;
            switch (token)
            {
                case "+":
                    sum = stack.Pop() + stack.Pop();
                    stack.Push(sum);
                    break;
                case "-":
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(b - a);
                    break;
                case "*":
                    sum = stack.Pop() * stack.Pop();
                    stack.Push(sum);
                    break;
                case "/":
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(b / a);
                    break;
                default:
                    stack.Push(Convert.ToInt16(token));
                    break;
            }
        }

        return stack.Pop();
    }
}
