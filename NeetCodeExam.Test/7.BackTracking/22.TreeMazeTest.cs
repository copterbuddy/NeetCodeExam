namespace NeetCodeExam.Trees;

public class TreeMazeTest
{
    private TreeMaze app = new();

    [Fact]
    public async Task Test_HasPathSum_Case1()
    {
        TreeNode input = new(val: 5,
            left: new(val: 4,
                left: new(val: 11,
                    left: new(val: 7),
                    right: new(val: 2))),
            right: new(val: 8,
                left: new(val: 13),
                right: new(val: 4,
                    right: new(val: 1))));

        bool result = app.HasPathSum(input, 22);
        Assert.Equivalent(true, result);
    }

    [Fact]
    public async Task Test_HasPathSum_Case2()
    {
        TreeNode input = new(val: 1,
            left: new(val: 2),
            right: new(val: 3));

        bool result = app.HasPathSum(input, 5);
        Assert.Equivalent(false, result);
    }

    [Fact]
    public async Task Test_HasPathSum_Case3()
    {
        TreeNode input = null;

        bool result = app.HasPathSum(input, 0);
        Assert.Equivalent(false, result);
    }
}
