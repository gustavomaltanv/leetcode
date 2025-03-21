public class Solution {
    public int[] CountBits(int n) {
        int[] ans = new int[n+1];
        for(int i = 0; i < n+1; i++) {
            ans[i] = Count(i);
        }
        return ans;
    }

    private int Count(int i) {
        int count = 0;
        while(i > 0) {
            if((i & 1) == 1) count++;
            i = i >> 1;
        }
        return count;
    }
}