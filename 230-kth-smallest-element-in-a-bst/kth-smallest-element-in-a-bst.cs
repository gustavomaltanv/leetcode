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
    int[] res = new int[10000];
    int index = 0;
    
    public int KthSmallest(TreeNode root, int k) {
        InOrder(root);

        return res[k-1];
    }

    private void InOrder(TreeNode current) {
        if(current == null) return;
        
        InOrder(current.left);
        res[index] = current.val;
        index++;
        InOrder(current.right);
    }
}