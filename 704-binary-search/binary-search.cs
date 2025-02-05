public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        while(left <= right) {   
            int search = left + (right - left) / 2;
            if(nums[search] == target) return search;
            if(nums[search] < target) left = search + 1;
            if(nums[search] > target) right = search - 1;
        }
        return -1;
    }
}