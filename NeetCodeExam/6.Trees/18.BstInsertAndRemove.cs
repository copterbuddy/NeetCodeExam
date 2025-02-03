namespace NeetCodeExam.Trees;

public class BstInsertAndRemove {
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root is null)
        {
            return new TreeNode(val);
        }

        if (root.val < val)
        {
            root.right = InsertIntoBST(root.right, val);
            return root;
        }
        else
        {
            root.left = InsertIntoBST(root.left, val);
            return root;
        }
    }
    
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        return null;
    }
}