public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int targetSum) {
        IList<IList<int>> result = new List<IList<int>>();
        Combinations(candidates, targetSum, 0, new List<int>(), result);
        return result;
    }

    public void Combinations(int[] candidates, int targetSum, int index, List<int> current, IList<IList<int>> result) {
        if(targetSum < 0 ) return;
        if(targetSum == 0 ) {
            result.Add(new List<int>(current));
            return;
        } 

        for(int i = index; i < candidates.Length; i++) {
            current.Add(candidates[i]);
            Combinations(candidates, targetSum - candidates[i], i, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}