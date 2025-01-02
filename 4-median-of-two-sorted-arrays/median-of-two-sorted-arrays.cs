public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] arr = nums1.Concat(nums2).OrderBy(x => x).ToArray();
        int skip = ((arr.Length + (arr.Length % 2)) / 2) - 1;
        arr = arr.Skip(skip).Take(2 - (arr.Length % 2)).ToArray();

        return (double) arr.Sum() / arr.Length;
    }
}