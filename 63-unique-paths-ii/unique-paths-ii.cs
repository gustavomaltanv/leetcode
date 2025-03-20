public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;

        if (obstacleGrid[m - 1][n - 1] == 1) return 0;

        int[,] dp = new int[m, n];
        dp[m - 1, n - 1] = 1;

        for (int r = m - 1; r >= 0; r--) {
            for (int c = n - 1; c >= 0; c--) {
                if (obstacleGrid[r][c] == 1) {
                    dp[r, c] = 0;
                } else {
                    if (r + 1 < m) dp[r, c] += dp[r + 1, c];
                    if (c + 1 < n) dp[r, c] += dp[r, c + 1]; 
                }
            }
        }
        return dp[0, 0];
    }
}