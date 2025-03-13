public class Solution {
    int rows;
    int cols;

    public int MaxAreaOfIsland(int[][] grid) {
        rows = grid.Length;
        cols = grid[0].Length;
        int maxArea = 0;
        
        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == 1) {
                    int currentArea = DFS(grid, r, c);
                    maxArea = Math.Max(maxArea, currentArea);
                }
            }
        }
        
        return maxArea;
    }

    private int DFS(int[][] grid, int r, int c) {
        if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == 0) return 0;
        
        grid[r][c] = 0;
        
        return 1 + DFS(grid, r + 1, c)
                 + DFS(grid, r - 1, c)
                 + DFS(grid, r, c + 1)
                 + DFS(grid, r, c - 1);
    }
}