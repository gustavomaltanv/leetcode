public class Solution {
    public int CountPrefixes(string[] words, string s) {
        int answer = 0;
        foreach(string word in words) {
            if( word.Length <= s.Length && s.Substring(0, word.Length) == word )
            {
                answer++;
            }
        }
        return answer;
    }
}