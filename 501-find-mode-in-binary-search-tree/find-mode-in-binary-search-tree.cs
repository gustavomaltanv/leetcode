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
    public int[] FindMode(TreeNode root) {
        Dictionary<int, int> valRep = new Dictionary<int,int>();
        GetKeyValue(root, valRep);
        int max = valRep.Max(x => x.Value);
        List<int> modes = valRep.Where(x => x.Value == max).Select(x => x.Key).ToList();
        return modes.ToArray();
    }

    public void GetKeyValue(TreeNode root, Dictionary<int,int> dict) {
        if(root != null)
        {
            GetKeyValue(root.left, dict);
            
            if(!dict.ContainsKey(root.val)){
                dict[root.val] = 1;
            }
            if(dict.ContainsKey(root.val)){
                dict[root.val]++;
            }
            
            GetKeyValue(root.right, dict);
        }
    }
}