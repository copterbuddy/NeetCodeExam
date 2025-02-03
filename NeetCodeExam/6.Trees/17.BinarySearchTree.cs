namespace NeetCodeExam.Trees;

public class BinarySearchTree
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root is null)
            return null;

        if (val > root.val)
            return SearchBST(root.right, val);
        else if (val < root.val)
            return SearchBST(root.left, val);
        else
            return root;
    }
}