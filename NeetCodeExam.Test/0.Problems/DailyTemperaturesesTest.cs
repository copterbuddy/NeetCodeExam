using System;

namespace NeetCodeExam.Problems;

public class DailyTemperaturesesTest
{
    DailyTemperatureses app = new();

    [Fact]
    public void TestDailyTemperatures_Success_Case1()
    {
        int[] temperatures = [30, 38, 30, 36, 35, 40, 28];
        int[] result = app.DailyTemperatures(temperatures);
        int[] want = [1, 4, 1, 2, 1, 0, 0];
        Assert.Equivalent(want, result);
    }

    [Fact]
    public void TestDailyTemperatures_Success_Case2()
    {
        int[] temperatures = [22, 21, 20];
        int[] result = app.DailyTemperatures(temperatures);
        int[] want = [0, 0, 0];
        Assert.Equivalent(want, result);
    }
}
