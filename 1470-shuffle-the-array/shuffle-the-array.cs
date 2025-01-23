public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        List<int> numbs = new List<int>();
        for(int i = 0; i < n; i++)
        {
            numbs.Add(nums[i]);
            numbs.Add(nums[i + n]);
        }
        return numbs.ToArray();
    }
}