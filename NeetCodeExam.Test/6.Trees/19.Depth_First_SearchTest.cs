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

    [Fact]
    public async Task Test_BuildTree_Case1()
    {
        int[] preorder = [ 1, 2, 3, 4 ];
        int[] inorder = [ 2, 1, 3, 4 ];
        TreeNode want = new(val: 1,
            left: new (val: 2),
            right: new (val: 3,
                right: new (val: 4)));
        
        TreeNode result = app.BuildTree(preorder, inorder);
        Assert.Equivalent(want, result);
    }
    
    [Fact]
    public async Task Test_BuildTree_Case2()
    {
        int[] preorder = [ 1 ];
        int[] inorder = [ 1 ];
        TreeNode want = new(val: 1);
        
        TreeNode result = app.BuildTree(preorder, inorder);
        Assert.Equivalent(want, result);
    }
}