using System;
using System.Collections.Generic;

public class Solution {
    public bool IsPossibleToSplit(int[] nums) {
        if (nums.Length % 2 != 0) return false;
        
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (freq.ContainsKey(num)) {
                freq[num]++;
            } else {
                freq[num] = 1;
            }
        }

        int maxFreq = 0;
        foreach (var count in freq.Values) {
            maxFreq = Math.Max(maxFreq, count);
        }

        return maxFreq <= 2;
    }
}

