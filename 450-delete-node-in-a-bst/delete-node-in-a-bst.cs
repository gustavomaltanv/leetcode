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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root == null) return null;

        if(key > root.val) root.right = DeleteNode(root.right, key);
        else if(key < root.val) root.left = DeleteNode(root.left, key);
        else {
            if(root.left == null) return root.right;
            else if (root.right == null) return root.left;
            else {
                TreeNode min = FindMin(root.right);
                root.val = min.val;
                root.right = DeleteNode(root.right, min.val);
            }
        }
        return root;
    }

    private TreeNode FindMin(TreeNode root) {
        while(root != null && root.left != null) {
            root = root.left;
        }
        return root;
    }
}