namespace NeetCodeExam.Trees;

public class BinarySearchTreeTest
{
    private BinarySearchTree app = new();
    
    [Fact]
    public async Task Test_Case1()
    {
        TreeNode input = new(4,
            new(2, 
                new(1),
                new(3)
                ),
            new(7)
            );
        int target = 2;
        TreeNode want = new(2, 
            new(1), 
            new(3)
            );
        
        TreeNode result = app.SearchBST(input, target);

        Assert.Equivalent(want, result);
    }
    
    [Fact]
    public async Task Test_Case2()
    {
        TreeNode input = new(4,
            new(2, 
                new(1),
                new(3)
            ),
            new(7)
        );
        int target = 5;
        TreeNode want = null;
        
        TreeNode result = app.SearchBST(input, target);

        Assert.Equivalent(want, result);
    }
}