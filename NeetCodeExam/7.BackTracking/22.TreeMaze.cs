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

    public List<List<int>> Subsets(int[] nums)
    {
        List<List<int>> result = new();
        List<int> subset = new();

        void dfs(int i)
        {
            if (i >= nums.Length)
            {
                result.Add(new(subset));
                return;
            }

            subset.Add(nums[i]);
            dfs(i + 1);
            subset.RemoveAt(subset.Count - 1);
            dfs(i + 1);
        }

        dfs(0);
        return result;
    }
}
