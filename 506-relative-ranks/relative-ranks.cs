public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        int[] scoreOrdered = score.OrderByDescending(x => x).ToArray();

        string[] answer = new string[score.Length];
        for(int i = 0; i < score.Length; i++)
        {
            var index = Array.IndexOf(score, scoreOrdered[ i ] );
            answer[ index ] = (i + 1).ToString();

            if(i == 0) answer[ index ] = "Gold Medal";
            if(i == 1) answer[ index ] = "Silver Medal";
            if(i == 2) answer[ index ] = "Bronze Medal";
        }
        return answer;
    }
}