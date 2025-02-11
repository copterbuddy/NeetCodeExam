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

    [Fact]
    public async Task Test_Subsets_Case1()
    {
        int[] input = [1, 2, 3];
        List<List<int>> want = [[1, 2, 3], [1, 2], [1, 3], [1], [2, 3], [2], [3], []];

        List<List<int>> result = app.Subsets(input);
        Assert.Equivalent(want, result);
    }

    [Fact]
    public async Task Test_Subsets_Case2()
    {
        int[] input = [7];
        List<List<int>> want = [[7], []];

        List<List<int>> result = app.Subsets(input);
        Assert.Equivalent(want, result);
    }
}
