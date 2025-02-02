public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);
        return nums; 
    }

    private void MergeSort(int[] arr, int s, int e) {
        if(s < e) {
            int m = (s+e)/2;
            MergeSort(arr, s, m);
            MergeSort(arr, m+1, e);

            Merge(arr, s, m, e);
        }
    }

    private void Merge(int[] arr, int s, int m, int e) {
        int n1 = m - s + 1;
        int n2 = e - m;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for(int i = 0; i < n1; i++) {
            leftArray[i] = arr[i + s];
        }
        for(int j = 0; j < n2; j++) {
            rightArray[j] = arr[j + m + 1];
        }

        int leftIndex = 0, rightIndex = 0;
        int k = s;
        while(leftIndex < n1 && rightIndex < n2) {
            if(leftArray[leftIndex] <= rightArray[rightIndex]) {
                arr[k] = leftArray[leftIndex];
                leftIndex++;
            } else {
                arr[k] = rightArray[rightIndex];
                rightIndex++;
            }
            k++;
        }

        while(leftIndex < n1) {
            arr[k] = leftArray[leftIndex];
            leftIndex++;
            k++; 
        }

        while(rightIndex < n2) {
            arr[k] = rightArray[rightIndex];
            rightIndex++;
            k++; 
        }
    }
}