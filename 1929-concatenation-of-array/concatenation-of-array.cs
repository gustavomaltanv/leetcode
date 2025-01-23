public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int len = nums.Length;
        int[] answer = new int[len * 2];
        for(int i = 0; i < len; i++)
        {
            answer[i] = nums[i];
            answer[i + len] = nums[i];
        }
        return answer;
    }
}