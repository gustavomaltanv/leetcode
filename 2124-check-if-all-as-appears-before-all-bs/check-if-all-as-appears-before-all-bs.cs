public class Solution {
    public bool CheckString(string s) {
        if(!s.Contains('a') || !s.Contains('b')) return true;
        int? aLastIndex = null, bFirstIndex =null;
        int len = s.Length - 1;

        for(int i = 0; i < s.Length; i++){
            if(!aLastIndex.HasValue && s[len - i] == 'a') aLastIndex = len - i;
            if(!bFirstIndex.HasValue && s[i] == 'b') bFirstIndex = i;

            if(aLastIndex.HasValue && bFirstIndex.HasValue) break;
        }

        return bFirstIndex > aLastIndex;
    }
}