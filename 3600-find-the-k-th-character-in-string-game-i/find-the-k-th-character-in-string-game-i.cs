public class Solution {
    public char KthCharacter(int k) {
        StringBuilder word = new StringBuilder("a");
        while(word.Length < k)
        {
            int length = word.Length;
            for(int i = 0; i < length; i++)
            {
                word.Append(IncrementChar(word[i]));
            }
        }
        return word[k-1];
    }

    public char IncrementChar(char c) {
        return (c == 'z'? 'a' : (char) (c + 1));
    }
}