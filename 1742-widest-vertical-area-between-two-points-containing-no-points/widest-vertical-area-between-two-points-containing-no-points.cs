public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        points = points.OrderBy(a => a[0]).ToArray();

        int maxWidth = 0;

        for(int i = 1; i < points.Length; i++)
        {
            int width = points[i][0] - points[i-1][0];
            if (width > maxWidth) maxWidth = width;
        }

        return maxWidth;
    }
}