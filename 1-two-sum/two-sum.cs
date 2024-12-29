public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var solution = new Dictionary<int, int>(); 
        for (int i = 0; i < nums.Length; i++) 
        { 
            int complement = target - nums[i]; 
            if (solution.ContainsKey(complement)) 
            { 
                return new int[] { solution[complement], i }; 
            } 
            solution[nums[i]] = i; 
        }
        return new int[0];
    }
}