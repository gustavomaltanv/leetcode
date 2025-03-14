public class Solution {
    int n;
    int[] dr = {-1, -1, -1, 0,  0, 1, 1,  1};
    int[] dc = {-1,  0,  1, -1, 1, -1, 0, 1};

    public int ShortestPathBinaryMatrix(int[][] grid) {
        n = grid.Length;
        if(grid[0][0] == 1 || grid[n-1][n-1] == 1) return -1;

        HashSet<(int,int)> visited = new HashSet<(int, int)>();
        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
        queue.Enqueue((0,0,1));
        grid[0][0] = 1;
        int path = 0;
        while(queue.Count > 0) {
            var (r, c, pathLength) = queue.Dequeue();
            
            if(r == n-1 && c == n-1) return pathLength;

            for(int i = 0; i < 8; i++)
            {
                int nr = r + dr[i];
                int nc = c + dc[i];
                if(nr >= 0 && nc >= 0 && nr < n && nc < n && grid[nr][nc] == 0)
                {
                    queue.Enqueue((nr, nc, pathLength + 1));
                    grid[nr][nc] = 1;
                }
            }
        }
        return -1;
    }
}