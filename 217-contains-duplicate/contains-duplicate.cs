public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int,int> map = nums.GroupBy(x => x).ToDictionary(n => n.Key, n => n.Count());

        foreach (var count in map.Values) 
        { 
            if (count > 1) 
            { 
                return true; 
            } 
        } 
        return false;
    }
}