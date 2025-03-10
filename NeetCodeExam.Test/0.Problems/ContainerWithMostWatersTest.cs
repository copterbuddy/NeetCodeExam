using System;

namespace NeetCodeExam.Problems;

public class ContainerWithMostWatersTest
{
    ContainerWithMostWaters app = new();

    [Fact]
    public void TestCContainerWithMostWaters_Success_Case1()
    {
        int[] height = [1, 7, 2, 5, 4, 7, 3, 6];
        int result = app.MaxArea(height);
        Assert.Equal(36, result);
    }

    [Fact]
    public void TestContainerWithMostWaters_Success_Case2()
    {
        int[] height = [2, 2, 2];
        int result = app.MaxArea(height);
        Assert.Equal(4, result);
    }

}
