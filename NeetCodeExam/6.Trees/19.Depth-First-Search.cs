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
    
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder?.Length is null or 0 || inorder?.Length is null or 0)
        {
            return null;
        }
        
        int root = preorder[0];
        int mid = Array.IndexOf(inorder, root);
        TreeNode node = new TreeNode(root);
        node.left = BuildTree(preorder.Skip(1).Take(mid).ToArray(), inorder.Take(mid).ToArray());
        node.right = BuildTree(preorder.Skip(mid+1).ToArray(),inorder.Skip(mid+1).ToArray());
        
        return node;
    }
}