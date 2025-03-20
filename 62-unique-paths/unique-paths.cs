public class Solution {
    public int UniquePaths(int m, int n) {
        int[] prevRow = Enumerable.Repeat(0, n).ToArray();

        for(int r = m-1; r >= 0; r--) {
            int[] curRow = Enumerable.Repeat(0, n).ToArray();
            curRow[n-1] = 1;
            for(int c = n-2; c >= 0; c--) {
                curRow[c] = curRow[c+1] + prevRow[c];
            }
            prevRow = curRow;
        }

        return prevRow[0];
    }
}