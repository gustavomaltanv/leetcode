public class Solution {
    public int CountPrefixes(string[] words, string s) {
        int answer = 0;
        foreach(string word in words) {
            if( word.Length <= s.Length )
            {
                if( s.StartsWith(word) ) answer++;
            }
        }
        return answer;
    }
}