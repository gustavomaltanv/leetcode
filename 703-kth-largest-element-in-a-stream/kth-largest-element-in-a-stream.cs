public class KthLargest {
    private List<int> minHeap;
    private int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        minHeap = new List<int>();
        foreach(var num in nums) Add(num);
    }
    
    public int Add(int val) {
        Push(minHeap, val);
        if (minHeap.Count > k) {
            Pop(minHeap);
        }
        return minHeap[0];
    }

    private void Push(List<int> heap, int val) {
		heap.Add(val);
        int i = heap.Count - 1;
		
		while(i > 0 && heap[i] < heap[ (i - 1) / 2 ]  ) {
            int temp = heap[i];
            heap[i] = heap[ (i - 1) / 2 ];
            heap[ (i - 1) / 2 ] = temp;
            i = (i-1) / 2;
		}
    }

    private int Pop(List<int> heap) {
		int minValue = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);
        int i = 0;
		while(true) {
			int left = 2 * i + 1;
			int right = 2 * i + 2;
            int smallest = i;
            if (left < heap.Count && heap[left] < heap[smallest]) {
                smallest = left;
            }
            if (right < heap.Count && heap[right] < heap[smallest]) {
                smallest = right;
            }
            if (smallest == i) {
                break;
            }
            int temp = heap[i];
            heap[i] = heap[smallest];
            heap[smallest] = temp;
            i = smallest;
        }
        return minValue;
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */