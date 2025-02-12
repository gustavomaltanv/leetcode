public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        int[] pointsX = new int[points.Length]; 
        for(int i = 0; i < points.Length; i++)
        {
            pointsX[i] = points[i][0];
        }
        Array.Sort(pointsX);

        int maxWidth = 0;
        for(int i = 0; i < pointsX.Length - 1; i++)
        {
            if (Math.Abs(pointsX[i] - pointsX[i + 1]) > maxWidth)
            {
                maxWidth = Math.Abs(pointsX[i] - pointsX[i + 1]);
            } 
        }
        return maxWidth;
    }
}