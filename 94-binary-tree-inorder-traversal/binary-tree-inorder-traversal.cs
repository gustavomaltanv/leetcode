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
    List<int> inorder = new List<int>();

    public IList<int> InorderTraversal(TreeNode root) {
        Inorder(root);
        return inorder;
    }

    private void Inorder(TreeNode current) {
        if(current == null) return;

        Inorder(current.left);
        inorder.Add(current.val);
        Inorder(current.right);
    }
}