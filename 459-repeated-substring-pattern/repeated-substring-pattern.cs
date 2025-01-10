public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        String substring = "";
        for(int i = 0; i < s.Length-1; i++)
        {
            substring += s[i];
            if( s.Replace(substring, "") == "" ) return true;
        }

        return false;
    }
}