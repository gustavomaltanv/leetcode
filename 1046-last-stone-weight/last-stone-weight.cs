public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        foreach (var stone in stones) {
            maxHeap.Enqueue(stone, 0 - stone);
        }
        
        while(maxHeap.Count > 1) {
            int crash = Math.Abs(maxHeap.Dequeue() - maxHeap.Dequeue());
            maxHeap.Enqueue(crash, 0 - crash);
        }

        return maxHeap.Dequeue();
    }
}