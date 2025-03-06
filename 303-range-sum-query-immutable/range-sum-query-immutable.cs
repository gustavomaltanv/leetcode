public class NumArray {
    private static int[] array;
    public NumArray(int[] nums) {
        array = nums;
    }
    
    public int SumRange(int left, int right) {
        if(left > right) return -1;
        int sum = 0;
        for(int i = left; i <= right; i++) {
             sum += array[i];
        }
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */