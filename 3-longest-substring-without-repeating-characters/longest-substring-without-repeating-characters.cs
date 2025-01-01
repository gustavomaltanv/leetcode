public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;
        
        Dictionary<char, int> charIndex = new Dictionary<char, int>();
        int longestLength = 0;
        int startSubstring = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if(charIndex.ContainsKey(s[i]))
            {
                startSubstring = Math.Max(startSubstring, charIndex[s[i]] + 1);    
            }
            charIndex[s[i]] = i;
            longestLength = Math.Max(longestLength, i - startSubstring + 1);    
        }

        return longestLength;
    }
}