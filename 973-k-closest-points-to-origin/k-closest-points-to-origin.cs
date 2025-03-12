public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double> minHeap = new PriorityQueue<int[], double>();
        foreach (var point in points) {
            minHeap.Enqueue(point, GetDistance(point));
        }
        int[][] result = new int[k][];
        for (int i = 0; i < k; i++) {
            result[i] = minHeap.Dequeue();
        }

        return result;
    }

    private double GetDistance(int[] point) {
        return Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
    }
}