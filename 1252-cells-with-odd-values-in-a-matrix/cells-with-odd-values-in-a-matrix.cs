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

        int oddCount = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int cellValue = rowIncrements[i] + colIncrements[j];
                if (cellValue % 2 != 0)
                {
                    oddCount++;
                }
            }
        }
        return oddCount;
    }
}