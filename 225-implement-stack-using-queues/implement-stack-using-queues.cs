public class MyStack {
    Queue<int> queue1;
    Queue<int> queue2;
    private int top;


    public MyStack() {
        queue1 = new Queue<int>();
        queue2 = new Queue<int>();       
    }
    
    public void Push(int x) {
        queue1.Enqueue(x);
        top = x;
    }
    
    public int Pop() {
        while (queue1.Count > 1) {
            top = queue1.Dequeue();
            queue2.Enqueue(top);
        }
        int element = queue1.Dequeue();
        Queue<int> temp = queue1;
        queue1 = queue2;
        queue2 = temp;
        return element;
    }
    
    public int Top() {
        return top;
    }
    
    public bool Empty() {
        return queue1.Count == 0;
    }

    // private method
    private int GetLast(Queue<int> deq, Queue<int> enq) {
        int aux = 0;
        while(deq.Any()) {
            aux = deq.Dequeue();
            if(deq.Any())
                enq.Enqueue(aux);
        }
        return aux;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */