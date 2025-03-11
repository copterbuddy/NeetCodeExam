namespace NeetCodeExam.Problems;

public class GenerateParenthesesesTest
{
    GenerateParentheseses app = new();

    [Fact]
    public void TestGenerateParentheseses_Success_Case1()
    {
        List<string> result = app.GenerateParenthesis(1);
        List<string> want = ["()"];

        Assert.Equivalent(want, result);
        Assert.Single(result);
    }

    [Fact]
    public void TestGenerateParentheseses_Success_Case3()
    {
        List<string> result = app.GenerateParenthesis(3);
        List<string> want = ["((()))", "(()())", "(())()", "()(())", "()()()"];
        Assert.Equivalent(want, result);
        Assert.Equal(5, result.Count);
    }
}
