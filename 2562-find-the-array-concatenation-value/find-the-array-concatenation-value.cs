public class Solution {
    public long FindTheArrayConcVal(int[] nums) {
        long answer = 0;
        int len = nums.Length;
        for(int i = 0; i < len/2 ; i++)
        {
            answer += Concat(nums[i], nums[len - 1 - i]);
        }
        if(len % 2 == 1) {
            answer += nums[len/2]; 
        }
        return answer;
    }

    public long Concat(int n1, int n2) {
        string concat = n1.ToString() + n2.ToString();
        return long.Parse(concat);
    }
}