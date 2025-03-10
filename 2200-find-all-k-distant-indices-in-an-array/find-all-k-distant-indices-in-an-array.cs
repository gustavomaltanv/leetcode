public class Solution {
    public IList<int> FindKDistantIndices(int[] nums, int key, int k) {
        List<int> result = new List<int>();

        List<int> keyIndices = new List<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == key) {
                keyIndices.Add(i);
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            foreach (int j in keyIndices) {
                if (Math.Abs(i - j) <= k) {
                    result.Add(i);
                    break; // No need to check further, as we found one valid j
                }
            }
        }

        result.Sort();
        return result;
    }
}