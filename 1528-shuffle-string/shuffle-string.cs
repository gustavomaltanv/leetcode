public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] charArray = s.ToCharArray();
        char aux;
        for (int i = 0; i < s.Length; i++)
        {
            while(indices[i] != i) {
                int targetIndex = indices[i];
                aux = charArray[targetIndex];
                charArray[targetIndex] = charArray[i];
                charArray[i] = aux;
                int temp = indices[targetIndex];
                indices[targetIndex] = indices[i];
                indices[i] = temp;
            }
        }
        return new string(charArray);
    }
}