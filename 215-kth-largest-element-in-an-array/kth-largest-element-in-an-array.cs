public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // Usando QuickSort
        QuickSort(nums, 0, nums.Length - 1);
        return nums[nums.Length - k];
    }

    private static void QuickSort(int[] arr, int left, int right) {
        if(left < right) {
            int pivot = Partition(arr, left, right);
            QuickSort(arr, left, pivot-1);
            QuickSort(arr, pivot+1, right);
        }
    }

    private static int Partition(int[] arr, int left, int right) {
        int pivot = arr[right];
        int pointer = left;
        for(int i = left; i < right; i++) {
            if(pivot > arr[i]) {
                Swap(arr, i, pointer);
                pointer++;
            }
        }
        Swap(arr, pointer, right);
        return pointer;
    }

    private static void Swap(int[] arr, int left, int right) {
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
    }
}