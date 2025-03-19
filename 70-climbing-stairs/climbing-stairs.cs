public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 2) return n;

        int[] dp = [1,2];
        int i = 2;
        while(i < n) {
            int aux = dp[1];
            dp[1] = dp[1] + dp[0];
            dp[0] = aux;
            i++;
        }
        return dp[1];
    }
}