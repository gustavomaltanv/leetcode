using System.Collections.Generic;

public class Solution {
    public int FindLatestStep(int[] arr, int m) {
        int[] length = new int[arr.Length + 2];
        int[] count = new int[arr.Length + 1];
        int answer = -1;

        for (int i = 0; i < arr.Length; i++) {
            int pos = arr[i];
            int left = length[pos - 1];
            int right = length[pos + 1];
            int total = left + right + 1;

            length[pos] = total;
            length[pos - left] = total;
            length[pos + right] = total;

            count[left]--;
            count[right]--;
            count[total]++;

            if (count[m] > 0) {
                answer = i + 1;
            }
        }

        return answer;
    }
}
