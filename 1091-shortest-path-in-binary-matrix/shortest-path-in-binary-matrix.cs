public class Solution {
    int rows;
    int cols;
    (int, int)[] directions = new (int, int)[] { (0,1), (1,1), (1,0), (1,-1), (0,-1), (-1,-1), (-1,0), (-1,1) };

    public int ShortestPathBinaryMatrix(int[][] grid) {
        rows = grid.Length;
        cols = grid[0].Length;
        if(grid[0][0] == 1) return -1;
        HashSet<(int,int)> visited = new HashSet<(int, int)>();
        Queue<(int,int)> queue = new Queue<(int,int)>();
        queue.Enqueue((0,0));
        visited.Add((0,0));
        int path = 0;
        while(queue.Count > 0) {
            path++;
            int size = queue.Count;
            for(var i = 0; i < size; i++) {
                (int r, int c) = queue.Dequeue();
                if(r == rows-1 && c == cols-1) return path;

                foreach(var (dr,dc) in directions) {
                    int nr = r + dr, nc = c + dc;
                    if (nr >= 0 && nc >= 0 
                    && nr < rows && nc < cols 
                    && grid[nr][nc] == 0 
                    && !visited.Contains((nr, nc))) 
                    {
                        queue.Enqueue((nr, nc));
                        visited.Add((nr, nc));
                    }
                }
            }
        }
        return -1;
    }
}