public class Solution {
    public string ReverseOnlyLetters(string s) {
        char[] arr = s.ToCharArray();
        int i = 0 , j = s.Length -1;
        while( i < j ) {
            if(!IsLetter(arr[i])) {
                i++;
            }
            else if(!IsLetter(arr[j])) {
                j--;
            }
            else {
                char aux = arr[i];
                arr[i] = arr[j];
                arr[j] = aux;
                i++;
                j--;
            }
        }
        return new string(arr);
    }

    public bool IsLetter(char c)
    {
        if( ((int) c >= 65 && (int) c <= 90) || ((int) c >= 97 && (int) c <= 122) ) return true;
        return false;
    }
}