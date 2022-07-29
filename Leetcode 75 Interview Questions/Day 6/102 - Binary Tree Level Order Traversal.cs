/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        if (root != null) q.Enqueue (root);
        
        while (q.Count > 0) {
            int levelSize = q.Count;
            List<int> level = new List<int>(levelSize);
            for (int i = 0; i < levelSize; i++) {
                TreeNode cur = q.Dequeue();
                if (cur.left != null) q.Enqueue (cur.left);
                if (cur.right != null) q.Enqueue (cur.right);
                level.Add(cur.val);
            }
            res.Add(level);
        }
        
        return res;
    }
}