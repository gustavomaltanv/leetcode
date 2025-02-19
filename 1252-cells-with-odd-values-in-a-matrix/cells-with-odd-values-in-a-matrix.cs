public class Solution
{
    public int OddCells(int m, int n, int[][] indices)
    {
        int[,] matrix = new int[m, n];

        foreach (var index in indices)
        {
            int row = index[0];
            int col = index[1];

            for (int i = 0; i < n; i++)
            {
                matrix[row, i]++;
            }
            for (int i = 0; i < m; i++)
            {
                matrix[i, col]++;
            }
        }

        int oddCount = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] % 2 != 0)
                {
                    oddCount++;
                }
            }
        }

        return oddCount;
    }
}
