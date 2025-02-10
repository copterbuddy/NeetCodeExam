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

    public List<int> RightSideView(TreeNode root) 
    {
        List<int> result = new();
        if (root is null){
            return null;
        }

        Queue<TreeNode> q = new();
        q.Enqueue(root);

        while(q.Count > 0){
            List<int> Level = new();
            for (int i = q.Count;i > 0;i--){
                TreeNode node = q.Dequeue();
                if(node is not null){
                    Level.Add(node.val);
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }
            if(Level?.Count > 0){
                result.Add(Level.LastOrDefault());
            }
        }

        return result;
    }

    List<int> res = new List<int>();
    
    public List<int> RightSideView_DepthFirst(TreeNode root) {
        dfs(root, 0);
        return res;
    }
    
    private void dfs(TreeNode node, int depth) {
        if (node == null) {
            return;
        }
        
        if (res.Count == depth) {
            res.Add(node.val);
        }
        
        dfs(node.right, depth + 1);
        dfs(node.left, depth + 1);
    }
}