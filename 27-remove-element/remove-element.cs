public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int last = 0;
        for(int actual = 0; actual < nums.Length; actual++)
        {
            if(nums[actual] != val)
            {
                nums[last] = nums[actual];
                last++;
            }
        }
        return last;
   }
}