public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) return nums[0];
        
        int[] dp = [0, 0];
        
        foreach (int num in nums) {
            int temp = dp[0];
            dp[0] = Math.Max(dp[0], dp[1] + num);
            dp[1] = temp;
        }
        
        return dp[0];
    }
}