public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] arr = nums1.Concat(nums2).OrderBy(x => x).ToArray();
        int length = arr.Length;
        if ( length % 2 == 0) 
        {
            return (arr[ (length / 2) - 1 ] + arr[ length / 2 ]) / 2.0; 
            
        }
        return (double)  arr[length/2];
    }
}