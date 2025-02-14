public class Solution {
    public int MinimumLines(int[][] stockPrices) {
        if (stockPrices.Length <= 1) return 0;

        int lines = 1;
        Array.Sort(stockPrices, (a,b) => a[0]-b[0] );
        for (int i = 2; i < stockPrices.Length; i++) {
            if (!IsCollinear(stockPrices[i - 2], stockPrices[i - 1], stockPrices[i])) {
                lines++;
            }
        }

        return lines;
    }

    private bool IsCollinear(int[] p1, int[] p2, int[] p3) {
        return (p2[1] - p1[1]) * (p3[0] - p2[0]) == (p3[1] - p2[1]) * (p2[0] - p1[0]);
    }
}