public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int targetSum) {
        IList<IList<int>> result = new List<IList<int>>();
        Combinations(candidates, targetSum, 0, new List<int>(), result);
        return result;
    }

    public void Combinations(int[] candidates, int targetSum, int index, List<int> current, IList<IList<int>> result) {
        if(current.Sum(x => Convert.ToInt32(x)) > targetSum) return;
        if(current.Sum(x => Convert.ToInt32(x)) == targetSum) result.Add(new List<int>(current));

        for(int i = index; i < candidates.Length; i++) {
            current.Add(candidates[i]);
            Combinations(candidates, targetSum, i, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}