namespace NeetCodeExam.Trees;

public class Depth_First_SearchTest
{
    private Depth_First_Search app = new();
    
    [Fact]
    public async Task Test_Insert_Case1()
    {
        TreeNode input = new(val: 1,
            right: new(val : 2,
                left: new (val: 3))
        );

        List<int> want = new() { 1, 3, 2 };
        
        IList<int> result = app.InorderTraversal(input);

        Assert.Equivalent(want, result);
    }
    
    [Fact]
    public async Task Test_KthSmallest_Case1()
    {
        TreeNode input = new(val: 2,
            left: new(val: 1),
            right: new(val : 3)
        );
        int target = 1;
        int want = 1;
        
        int result = app.KthSmallest(input, target);

        Assert.Equivalent(want, result);
    }
}