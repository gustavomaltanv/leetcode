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
    int i = 0, result;
    
    public int KthSmallest(TreeNode root, int k) {
        InOrder(root, k);
        return result; 
    }

    private void InOrder(TreeNode current, int k) {
        if(current is null) return;

        InOrder(current.left, k);
        i++;
        if(i == k) {
            result = current.val;
        }
        InOrder(current.right, k);
    }
}