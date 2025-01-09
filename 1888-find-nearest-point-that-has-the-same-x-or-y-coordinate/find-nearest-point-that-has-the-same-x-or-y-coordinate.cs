public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {
        int minDistance = int.MaxValue;
        int index = -1;

        for(int i = 0; i < points.Length; i++)
        {
            if(points[i][0] == x || points[i][1] == y)
            {
                int distance = GetManhattanDistance(x, y, points[i]);
                if(distance < minDistance)
                {
                    minDistance = distance;
                    index = i;
                }
            }
        }

        return index;

    }

    public int GetManhattanDistance(int x, int y, int[] point) {
        return Math.Abs(x - point[0]) + Math.Abs(y - point[1]);
    }
}