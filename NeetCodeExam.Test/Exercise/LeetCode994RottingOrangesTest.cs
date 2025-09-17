using NeetCodeExam.Exercise;

namespace NeetCodeExam.Test.Exercise;

public class LeetCode994RottingOrangesTest
{
    private LeetCode994RottingOranges app = new();

    [Fact]
    public async Task Test_Sucess_Case1()
    {
        int[][] give = [[2, 1, 1], [1, 1, 0], [0, 1, 1]];
        var result = app.OrangesRotting(give);
        Assert.Equal(4, result);
    }

    [Fact]
    public async Task Test_Failed_Case2()
    {
        int[][] give = [[2, 1, 1], [0, 1, 1], [1, 0, 1]];
        var result = app.OrangesRotting(give);
        Assert.Equal(-1, result);
    }

    [Fact]
    public async Task Test_Sucess_Case2()
    {
        int[][] give = [[0, 2]];
        var result = app.OrangesRotting(give);
        Assert.Equal(0, result);
    }
}
