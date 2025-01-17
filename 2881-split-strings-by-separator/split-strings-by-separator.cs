public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
        List<string> answer = new List<string>();

        for(int i= 0; i < words.Count; i++)
        {
            foreach( string word in words[i].Split(separator) )
            {
                if(word != "") answer.Add(word);
            }
        }
        return answer;
    }
}