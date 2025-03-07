public class Solution {
    public bool CheckTwoChessboards(string coordinate1, string coordinate2) {
        int x1 = (int) coordinate1[0], y1 = coordinate1[1];
        int x2 = (int) coordinate2[0], y2 = coordinate2[1]; 
        return (IsWhiteTile(x1, y1) && IsWhiteTile(x2, y2)) 
        || (!IsWhiteTile(x1, y1) && !IsWhiteTile(x2, y2));
    }

    private static bool IsWhiteTile (int x, int y) {
        return (x + y) % 2 == 1; 
    }
}