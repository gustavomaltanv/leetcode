public class Solution {
    public int FindPermutationDifference(string s, string t) {
        int answer = 0;
        for( int i = 0; i < s.Length; i++ )
        {
            answer +=  (Math.Abs( i - t.IndexOf(s[i]) )); 
        }
        return answer;
    }
}