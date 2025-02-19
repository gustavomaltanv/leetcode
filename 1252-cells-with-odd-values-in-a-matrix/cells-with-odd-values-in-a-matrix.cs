public class Solution
{
    public int OddCells(int m, int n, int[][] indices)
    {
        int[] rowIncrements = new int[m];
        int[] colIncrements = new int[n];

        foreach (var index in indices)
        {
            rowIncrements[index[0]]++;
            colIncrements[index[1]]++;
        }

        int oddRows = 0;
        int oddCols = 0;
        for (int i = 0; i < m; i++)
        {
            if (rowIncrements[i] % 2 != 0)
            {
                oddRows++;
            }
        }
        for (int j = 0; j < n; j++)
        {
            if (colIncrements[j] % 2 != 0)
            {
                oddCols++;
            }
        }

        int evenRows = m - oddRows;
        int evenCols = n - oddCols;

        return (oddRows * evenCols) + (oddCols * evenRows);
    }
}
