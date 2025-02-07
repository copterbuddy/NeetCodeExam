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
        if (root is null)
        {
            return null;
        }
        
        if (root.val < key)
        {
            root.right = DeleteNode(root.right, key);
            return root;
        }
        else if (root.val > key)
        {
            root.left = DeleteNode(root.left, key);
            return root;
        }
        else
        {
            if (root.left == null)
            {
                return root.right;
            }
            else if (root.right == null)
            {
                return root.left;
            }
            else
            {
                var minRight = MinValue(root.right);
                root.val = minRight.val;
                root.right = DeleteNode(root.right, minRight.val);
                return root;
            }
        }
    }

    public TreeNode MinValue(TreeNode root)
    {
        var tmp = root;
        while (root != null && root.left != null)
        {
            tmp = root.left;
        }
        return tmp;
    }
}