public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int last = 0;
        for(int actual = 1; actual < nums.Length; actual++)
        {
            if( nums[last] != nums[actual] )
            {
                last++;
                nums[last] = nums[actual];
            }
        }
        return last + 1;
    }
}