public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;

        for (int i = 0; i <= n; i++) {
            int count = 0;
            foreach (int num in nums) {
                if (num >= i) count++;
            }
            if (count == i) return i;
        }

        return -1;
    }
}