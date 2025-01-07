public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n <= 0) return false;
        
        string binary = Convert.ToString(n, 2);
        int digitCount = binary.Count(x => x == '1');

        if(digitCount == 1) return true;

        return false;
    }
}