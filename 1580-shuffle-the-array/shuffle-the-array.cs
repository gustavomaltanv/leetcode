public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] numb = new int[n*2];
        for(int i = 0; i < n; i++)
        {
            numb[i*2] = nums[i];
            numb[i*2 +1] = nums[n+i];
        }
        return numb;
    }
}