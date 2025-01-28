public class Solution {
    public bool IsValid(string word) {
        return word.Length >= 3 && Validation(word);
    }

    public bool Validation(string word) {
        bool vowel = false, consonant = false;
        foreach(char c in word) {
            if(Char.IsLetter(c)) {
                if( "aeiouAEIOU".IndexOf(c) >= 0 ) {vowel = true;}
                else {consonant = true;}
            }
            else if(!Char.IsNumber(c)) {
                return false;
            }
        }
        return vowel && consonant;
    }
}