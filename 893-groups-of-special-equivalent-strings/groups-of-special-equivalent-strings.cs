public class Solution {
    public int NumSpecialEquivGroups(string[] words) {
        HashSet<string> groups = new HashSet<string>();
        foreach (string word in words) {
            groups.Add(GetSpecialEquivKey(word));
        }
        return groups.Count;
    }

    static string GetSpecialEquivKey(string word) {
        char[] even = new char[(word.Length + 1) / 2];
        char[] odd = new char[word.Length / 2];
        for (int i = 0; i < word.Length; i++) {
            if (i % 2 == 0) even[i / 2] = word[i];
            else odd[i / 2] = word[i];
        }
        Array.Sort(even);
        Array.Sort(odd);
        return new string(even) + new string(odd);
    }
}