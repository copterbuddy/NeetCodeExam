using System;

namespace NeetCodeExam.Problems;

public class EvaluateReversePolishNotationsTest
{
    EvaluateReversePolishNotations app = new();

    [Fact]
    public void TestEvaluateReversePolishNotations_Success_Case1()
    {
        string[] tokens = ["1", "2", "+", "3", "*", "4", "-"];
        int result = app.EvalRPN(tokens);

        Assert.Equivalent(5, result);
    }
}
