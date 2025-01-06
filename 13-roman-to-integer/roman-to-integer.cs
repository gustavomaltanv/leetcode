public class Solution {
    public int RomanToInt(string s) {
        int value = 0;
        Dictionary<char,int> romans = RomanValues();
        int last = 0;
        for(int i = s.Length - 1; i >= 0; i--) {
            if(last <= romans[s[i]] ) {
                value += romans[s[i]];
            } else {
                value -= romans[s[i]];
            }
            last = romans[s[i]];
        }
        return value;
    }

    public Dictionary<char, int> RomanValues() {
        var roman = new Dictionary<char, int>();
        roman.Add(char.Parse("I"), 1);
        roman.Add(char.Parse("V"), 5);
        roman.Add(char.Parse("X"), 10);
        roman.Add(char.Parse("L"), 50);
        roman.Add(char.Parse("C"), 100);
        roman.Add(char.Parse("D"), 500);
        roman.Add(char.Parse("M"), 1000);
        return roman;
    }
}