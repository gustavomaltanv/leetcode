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
        if (root == null) return new List<IList<int>>();

        List<IList<int>> levelList = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            int levelSize = queue.Count;
            List<int> levelNodes = new List<int>();

            for (int i = 0; i < levelSize; i++) {
                TreeNode curr = queue.Dequeue();
                levelNodes.Add(curr.val);
                
                if (curr.left != null)
                    queue.Enqueue(curr.left);
                if (curr.right != null)
                    queue.Enqueue(curr.right);
            }

            levelList.Add(levelNodes);
        }
        return levelList;
    }
}
