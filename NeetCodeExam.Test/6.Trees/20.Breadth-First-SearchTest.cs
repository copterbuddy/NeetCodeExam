namespace NeetCodeExam.Trees;

public class Breadth_First_SearchTest
{
    private Breadth_First_Search app = new();
    
    [Fact]
    public async Task Test_LevelOrderTraversal_Case1()
    {
        TreeNode input = new(val: 1,
            left: new(val: 2,
                left: new(val: 4),
                right: new(val: 5)),
            right: new (val: 3,
                left: new(val: 6),
                right: new(val: 7)));

        List<List<int>> want = [[1], [2, 3], [4, 5, 6, 7]];
        
        List<List<int>> result = app.LevelOrder(input);
        Assert.Equivalent(want, result);
    }

    [Fact]
    public async Task Test_RightSideView_Case1()
    {
        TreeNode input = new(val: 1,
            left: new(val: 2),
            right: new (val: 3));

        List<int> want = [1,3];
        
        List<int> result = app.RightSideView(input);
        Assert.Equivalent(want, result);
    }

    [Fact]
    public async Task Test_RightSideView_DepthFirst_Case1()
    {
        TreeNode input = new(val: 1,
            left: new(val: 2),
            right: new (val: 3));

        List<int> want = [1,3];
        
        List<int> result = app.RightSideView_DepthFirst(input);
        Assert.Equivalent(want, result);
    }

    [Fact]
    public async Task Test_RightSideView_DepthFirst_Case2()
    {
        TreeNode input = new(val: 1,
            left: new(val: 2,
                left: new(val: 4),
                right: new(val: 5)),
            right: new (val: 3,
                left: new(val: 6),
                right: new(val: 7)));

        List<int> want = [1,3,7];
        
        List<int> result = app.RightSideView_DepthFirst(input);
        Assert.Equivalent(want, result);
    }
}