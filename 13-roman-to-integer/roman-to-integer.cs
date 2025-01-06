public class Solution {
    public int RomanToInt(string s) {
        int value = 0;
        int last = 0;
        for(int i = s.Length - 1; i >= 0; i--) {
            if(last <= GetIntByValue(s[i]) ) {
                value += GetIntByValue(s[i]);
            } else {
                value -= GetIntByValue(s[i]);
            }
            last = GetIntByValue(s[i]);
        }
        return value;
    }

    public int GetIntByValue(char c) {
        switch(c) {
            case 'I': return 1; break;
            case 'V': return 5; break;
            case 'X': return 10; break;
            case 'L': return 50; break;
            case 'C': return 100; break;
            case 'D': return 500; break;
            case 'M': return 1000; break;
            default: return 0; break;
        }
    }
}