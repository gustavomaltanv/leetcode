public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        for(int i = 1; i < words.Length; i++) {
        int comp = 0;
            while(comp < words[i].Length && comp < words[i-1].Length) {
                if(order.IndexOf(words[i][comp]) > order.IndexOf(words[i-1][comp])) break;
                else if(order.IndexOf(words[i][comp]) < order.IndexOf(words[i-1][comp])) return false;
                else comp++;
            }
            if((comp == words[i].Length || comp == words[i-1].Length) 
            && (words[i-1].Length > words[i].Length)) return false;
        }
        return true;
    }
}