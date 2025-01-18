public class Solution {
    public string ReverseStr(string s, int k) {
        int i = 0;
        char[] answer = s.ToCharArray();
        while(i < answer.Length ) 
        {
          Array.Reverse(answer, i, Math.Min( k, s.Length - i ));
          i = i + k * 2;
        }
        return new string(answer);   
    }
}