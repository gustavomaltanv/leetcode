public class Solution {
    public bool CheckAlmostEquivalent(string word1, string word2) {
        Dictionary<char, int> charCount1 = CharCount(word1);
        Dictionary<char, int> charCount2 = CharCount(word2);

        foreach (var kvp in charCount1) {
            char c = kvp.Key;
            int count1 = kvp.Value;
            int count2 = charCount2.ContainsKey(c) ? charCount2[c] : 0;

            if (Math.Abs(count1 - count2) > 3) {
                return false;
            }
        }

        foreach (var kvp in charCount2) {
            char c = kvp.Key;
            int count1 = charCount1.ContainsKey(c) ? charCount1[c] : 0;
            int count2 = kvp.Value;

            if (Math.Abs(count1 - count2) > 3) {
                return false;
            }
        }

        return true;
    }

    public Dictionary<char, int> CharCount(string word) {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach(char c in word)
        {
            if(!charCount.ContainsKey(c)) {
                charCount.Add(c, 1);
            }
            else {
                charCount[c]++;
            }
        }
        return charCount;
    }
}