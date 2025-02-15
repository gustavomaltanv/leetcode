public class Solution {
    public int LenLongestFibSubseq(int[] arr) {
        int n = arr.Length;
        int maxLen = 0;

        Dictionary<int, int> index = new Dictionary<int, int>();
        for (int i = 0; i < n; i++) {
            index[arr[i]] = i;
        }

        Dictionary<(int, int), int> dp = new Dictionary<(int, int), int>();
        for (int k = 0; k < n; k++) {
            for (int j = 0; j < k; j++) {
                int i = index.GetValueOrDefault(arr[k] - arr[j], -1);
                if (i >= 0 && i < j) {
                    int len = dp.GetValueOrDefault((i, j), 2) + 1;
                    dp[(j, k)] = len;
                    maxLen = Math.Max(maxLen, len);
                }
            }
        }

        return maxLen >= 3 ? maxLen : 0;
    }
}
