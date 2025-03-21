public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        int min = 999999;
        for(int i = 0; i < nums.Length; i++) {
            if( nums[i] == target)
            {
                min = Math.Min(min, Math.Abs(i - start));
            }
        }
        return min;
    }
}