public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        int n = s.Length / 2;
        System.Text.StringBuilder substring = new StringBuilder("", n);
        for(int i = 0; i < n; i++)
        {
            substring.Append( s[i] );
            if( s.Replace(substring.ToString(), "") == "" ) return true;
        }

        return false;
    }
}