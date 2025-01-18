public class Solution {
    public string ReverseStr(string s, int k) {
        string answer = "";
        for(int i = 0; i*k < s.Length; i++) 
        {
            if(i % 2 == 0)
            {
                int length = Math.Min(k, s.Length - i * k);
                answer += ReverseSubstring(s.Substring(i*k , length)); 
            }
            if(i % 2 == 1)
            {
                int length = Math.Min(k, s.Length - i * k);
                answer += s.Substring(i*k, length);
            }
        }
        return answer;
        
    }

    public string ReverseSubstring(string s) {
        char[] reverse = s.ToCharArray();
        Array.Reverse(reverse);
        return new string(reverse);
    }
}