namespace NeetCodeExam.Trees;

public class BstInsertAndRemoveTest
{
    private BstInsertAndRemove app = new();
    
    [Fact]
    public async Task Test_Insert_Case1()
    {
        TreeNode input = new(4,
            new(2, 
                new(1),
                new(3)
            ),
            new(7)
        );
        int target = 5;
        
        TreeNode want = new(4,
            new(2, 
                new(1),
                new(3)
            ),
            new(7,
                new(5))
        );
        
        TreeNode result = app.InsertIntoBST(input, target);

        Assert.Equivalent(want, result);
    }
    
    [Fact]
    public async Task Test_Delete_Case1()
    {
        TreeNode input = new(5,
            new(3, 
                new(2),
                new(4)
            ),
            new(6,
                null,
                new(7)
                )
        );
        int target = 3;
        
        TreeNode want = new(val: 5,
            left: new(val: 4, 
                left: new(val: 2)
            ),
            right: new(6,
                left: null,
                right: new(val: 7)
                )
        );
        
        TreeNode result = app.InsertIntoBST(input, target);

        Assert.Equivalent(want, result);
    }
}