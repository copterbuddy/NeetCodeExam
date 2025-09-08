using NeetCodeExam.Exercise;

namespace NeetCodeExam.Test.Exercise;

public class LeetCode286WallsAndGatesTest
{
    private LeetCode286WallsAndGates app = new();

    [Fact]
    public async Task Test_Case1()
    {
        int maxInt = 2_147_483_647;
        int[][] give = [
                      [maxInt, -1,0,maxInt],
                      [maxInt,maxInt,maxInt,-1],
                      [maxInt,-1,maxInt,-1],
                      [0,-1,maxInt,maxInt]
                    ];
        app.islandsAndTreasure(give);
        int[][] want = [
                      [3,-1,0,1],
                      [2,2,1,-1],
                      [1,-1,2,-1],
                      [0,-1,3,4]
                    ];
        Assert.Equal(want, give);
    }
}
