public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        for(int i = 0; i < nums.Length-1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == nums[i] && j !=i)
                {
                    if( j - i <= k ) 
                    {
                        return true;
                    }
                }   
            }
        }

        return false;
    }
}