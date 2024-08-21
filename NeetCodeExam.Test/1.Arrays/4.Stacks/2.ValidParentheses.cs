using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeExam.Test.Stacks.ValidParentheses;

public class ValidParentheses
{
    [Fact]
    public void TestValidParentheses_Success_Case1()
    {
        string give = "()";
        bool result = Program.ValidParentheses(give);
        Assert.True(result);
    }

    [Fact]
    public void TestValidParentheses_Success_Case2()
    {
        string give = "()[]{}";
        bool result = Program.ValidParentheses(give);
        Assert.True(result);
    }

    [Fact]
    public void TestValidParentheses_Failed_Case3()
    {
        string give = "[{}]";
        bool result = Program.ValidParentheses(give);
        Assert.True(result);
    }

    [Fact]
    public void TestValidParentheses_Failed_Case1()
    {
        string give = "(]";
        bool result = Program.ValidParentheses(give);
        Assert.False(result);
    }
}
