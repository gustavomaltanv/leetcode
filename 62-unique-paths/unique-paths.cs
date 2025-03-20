public class Solution {
    public int UniquePaths(int m, int n) {
        int[] prevRow = new int[n];
        int[] curRow = new int[n];

        for(int i = 0; i < n; i++)
        {
            prevRow[i] = 1;
            curRow[i] = 1;
        }
        for(int r = 1; r < m; r++)
        {
            for(int c = 1; c < n; c++)
            {
            curRow[c] = curRow[c-1] + prevRow[c];
            }
            (curRow, prevRow) = (prevRow, curRow);
        }

        return prevRow[n-1];
    }
}