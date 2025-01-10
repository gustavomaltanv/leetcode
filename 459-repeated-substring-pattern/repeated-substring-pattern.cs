public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        string doubled = s + s;

        string reduced = doubled.Substring(1, doubled.Length - 2);

        return reduced.Contains(s);
    }
}