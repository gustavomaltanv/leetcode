public class Solution {
    public bool CheckZeroOnes(string s) {
        int maxOne = 0, maxZero = 0, curOne = 0, curZero = 0;
        foreach(char c in s)
        {
            if( c == '1' ) {
                curOne++;
                curZero = 0;
            }
            if( c == '0' ) {
                curZero++;
                curOne = 0;
            }
            maxOne = Math.Max(maxOne, curOne);
            maxZero = Math.Max(maxZero, curZero);
        }
        return maxOne > maxZero;
    }
}