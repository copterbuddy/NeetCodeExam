namespace NeetCodeExam.Trees;

public class Depth_First_Search {
    IList<int> result = new List<int>();
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null)
        {
            return result;
        }
        
        InorderTraversal(root.left);
        result.Add(root.val);
        InorderTraversal(root.right);
        
        return result;
    }
    
    public int KthSmallest(TreeNode root, int k)
    {
        List<int> sorted = new();
        InOrderK(root, sorted);
        return sorted[k-1];
    }

    public void InOrderK(TreeNode root, List<int> sorted)
    {
        if (root == null)
        {
            return;
        }
        
        InOrderK(root.left, sorted);
        sorted.Add(root.val);
        InOrderK(root.right, sorted);
    }
}