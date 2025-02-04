public class Solution {
    public void SortColors(int[] nums) {
        int[] bucket = new int[3];

        for(int n = 0; n < nums.Length; n++) {
            bucket[nums[n]] += 1;
        }

        int i = 0;
        for(int n = 0; n < bucket.Length; n++) {
            for(int j = 0; j < bucket[n]; j++) {
                nums[i] = n;
                i++;
            }
        }
    }
}