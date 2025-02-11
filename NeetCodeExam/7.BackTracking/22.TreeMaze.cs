namespace NeetCodeExam.Trees;

public class TreeMaze
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root is null)
        {
            return false;
        }

        if (root.left is null && root.right is null)
        {
            return targetSum == root.val;

        }

        if (HasPathSum(root.left, targetSum - root.val))
        {
            return true;
        }
        if (HasPathSum(root.right, targetSum - root.val))
        {
            return true;
        }

        return false;
    }
}
