public class Solution {
    public int MinOperations(string[] logs) {
        int folder = 0;
        for(int i = 0; i < logs.Length; i++) {
            if(logs[i] == "../") {
                folder = folder > 0 ? folder - 1 : 0; 
            } 
            else if(logs[i] != "./") folder++;
        }

        return folder;
    }
}