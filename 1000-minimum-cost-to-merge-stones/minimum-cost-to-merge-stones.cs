public class Solution {
    public int MergeStones(int[] stones, int k) {
        int n = stones.Length;
        if((n - 1) % (k - 1) != 0) return -1;

        int[][] dp = new int[n][];
        for(int i = 0; i < n; i++) {
            dp[i] = new int[n];
            Array.Fill(dp[i], int.MaxValue);
        }
        
        int[] prefixSum = new int[n + 1];
        for(int i = 0; i < n; i++) {
            prefixSum[i + 1] = prefixSum[i] + stones[i];
        }
        
        for(int i = 0; i < n; i++) {
            dp[i][i] = 0;
        }

        for(int len = 2; len <= n; len++) {
            for(int i = 0; i <= n - len; i++) {
                int j = i + len - 1;
                for(int m = i; m < j; m += k - 1) {
                    dp[i][j] = Math.Min(dp[i][j], dp[i][m] + dp[m + 1][j]);
                }
                if((j - i) % (k - 1) == 0) {
                    dp[i][j] += prefixSum[j + 1] - prefixSum[i];
                }
            }
        }

        return dp[0][n - 1];
    }
}
