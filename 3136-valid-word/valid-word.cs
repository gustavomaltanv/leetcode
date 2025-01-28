public class Solution {
    public bool IsValid(string word) {
        return word.Length >= 3 && hasVowel(word) && hasConsonant(word) && !hasSpecialChar(word);
    }

    public bool hasVowel(string word) {
        foreach (char c in word) {
            if( "aeiouAEIOU".IndexOf(c) >= 0 )
                return true; 
        }
        return false;
    }

    public bool hasConsonant(string word) {
        foreach (char c in word) {
            if( Char.IsLetter(c) && "aeiouAEIOU".IndexOf(c) < 0 )
                return true; 
        }
        return false;
    }

    public bool hasSpecialChar(string word) {
        foreach (char c in word) {
            if(!Char.IsLetter(c) && !Char.IsNumber(c) ) {
                return true;
            }
        }
        return false;
    }


}