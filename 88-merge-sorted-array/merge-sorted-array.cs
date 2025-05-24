public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        Copy(nums1, m, nums2, n);
        if(m + n < 2) return;

        MergeSort(nums1, 0, m+n-1);
    }

    private static void Copy(int[] nums1, int m, int[] nums2, int n)
    {
        for(int i = 0; i < n; i++)
        {
            nums1[m+i] = nums2[i];
        }
    }


    private static void MergeSort(int[] numbers, int left, int right)
    {
        if (left >= right) return;

        int mid = left + (right - left) / 2;
        MergeSort(numbers, left, mid);
        MergeSort(numbers, mid + 1, right);
        Merge(numbers, left, mid, right);
    }

    private static void Merge(int[] numbers, int left, int mid, int right)
    {
        int[] leftArr = numbers[left..(mid + 1)];
        int[] rightArr = numbers[(mid + 1)..(right + 1)];

        int i = 0, j = 0, k = left;

        while (i < leftArr.Length && j < rightArr.Length)
        {
            numbers[k++] = leftArr[i] <= rightArr[j] ? leftArr[i++] : rightArr[j++];
        }

        while (i < leftArr.Length) numbers[k++] = leftArr[i++];
        while (j < rightArr.Length) numbers[k++] = rightArr[j++];
    }
}