namespace NeetCodeExam.Trees;

public class Breadth_First_Search {
    
    public List<List<int>> LevelOrder(TreeNode root)
    {
        List<List<int>> result = new();
        if (root is null)
        {
            return result;
        }
        
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        
        while (q.Count > 0)
        {
            List<int> level = new();
            for (int i = q.Count; i > 0; i--)
            {
                TreeNode node = q.Dequeue();
                if (node is not null)
                {
                    level.Add(node.val);
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }

            if (level.Count() > 0)
            {
                result.Add(level);
            }
        }

        return result;
    }
}