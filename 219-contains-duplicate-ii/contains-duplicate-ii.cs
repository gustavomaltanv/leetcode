public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> numInd = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(numInd.ContainsKey(nums[i]))
            {
                if(Math.Abs(i - numInd[nums[i]]) <= k)
                {
                    return true;
                }
            }
            numInd[nums[i]] = i;
        }

        return false;
    }
}