public class Solution {
    public bool IsLongPressedName(string name, string typed) {
        int i = 0, j = 0;
        while (j < typed.Length) {
            if( i < name.Length && name[i] == typed[j]) i++;
            else if ( j == 0 || typed[j] != typed[ j - 1]) return false;
            j++;
        }
        return i == name.Length;
    }
}