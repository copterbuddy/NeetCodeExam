using System;

namespace NeetCodeExam.Problems;

public class TrappingRainWatersTest
{
    TrappingRainWaters app = new();

    [Fact]
    public void TestTwosums_Success_Case1()
    {
        int result = app.Trap([0, 2, 0, 3, 1, 0, 1, 3, 2, 1]);
        Assert.Equivalent(9, result);
    }
}
