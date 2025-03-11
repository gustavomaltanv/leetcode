public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {   
        IList<IList<int>> result = new List<IList<int>>();
        Subsets(nums, 0, new List<int>(), result);
        return result;
    }

    public void Subsets(int[] nums, int index, List<int> current, IList<IList<int>> result) {
        result.Add(new List<int>(current));

        for(int i = index; i < nums.Length; i++) {
            current.Add(nums[i]);
            Subsets(nums, i+1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}