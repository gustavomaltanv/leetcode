public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> answer = new List<string>();
        for(int i = 0; i < n; i++) 
        {
            answer.Add( GetString(i+1) );
        }
        return answer;
    }

    public string GetString(int test) {
        string answer = "";
        if(test % 3 == 0)
        {
            answer += "Fizz";
        }
        if(test % 5 == 0)
        {
            answer += "Buzz";
        }
        return answer == "" ? test.ToString() : answer;
    }
}