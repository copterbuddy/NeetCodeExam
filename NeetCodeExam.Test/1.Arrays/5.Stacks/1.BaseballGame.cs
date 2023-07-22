using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeExam.Test.Stacks.BaseballGame;

public class BaseballGame
{
    [Fact]
    public void TestBaseballGame_Success_Case1()
    {
        string[] input = new string[] { "1", "C" };
        int result = Program.CalPoints(input);
        Assert.Equal(0, result);
    }
    [Fact]
    public void TestBaseballGame_Success_Case2()
    {
        string[] input = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };
        int result = Program.CalPoints(input);
        Assert.Equal(27, result);
    }

    [Fact]
    public void TestBaseballGame_Success_Case3()
    {
        string[] input = new string[] { "5", "2", "C", "D", "+" };
        int result = Program.CalPoints(input);
        Assert.Equal(30, result);
    }
}
