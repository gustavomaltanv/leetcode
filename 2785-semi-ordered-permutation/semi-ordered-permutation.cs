public class Solution {
    public int SemiOrderedPermutation(int[] nums) {
        int permut = 0;
        if( Array.IndexOf(nums, 1) != 0 )
        {
            permut = Array.IndexOf(nums, 1);
        }
        if( Array.IndexOf(nums, nums.Length) != nums.Length-1 )
        {
            permut += nums.Length-1 - Array.IndexOf(nums, nums.Length);
        }
        if( Array.IndexOf(nums, 1) > Array.IndexOf(nums, nums.Length) )
        {
            permut = permut - 1;
        }
        return permut;
    }
}