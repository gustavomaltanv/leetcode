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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return BuildSubTree(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
    }

    private TreeNode BuildSubTree(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd) {
        if (preStart > preEnd || inStart > inEnd) return null;

        int rootVal = preorder[preStart];
        TreeNode root = new TreeNode(rootVal);
        
        int rootIndex = Array.IndexOf(inorder, rootVal, inStart, inEnd - inStart + 1);

        int leftTreeSize = rootIndex - inStart;

        root.left = BuildSubTree(preorder, preStart + 1, preStart + leftTreeSize, inorder, inStart, rootIndex - 1);
        root.right = BuildSubTree(preorder, preStart + leftTreeSize + 1, preEnd, inorder, rootIndex + 1, inEnd);

        return root;
    }
}