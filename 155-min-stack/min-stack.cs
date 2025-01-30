public class MinStack {
    List<int> stack;
    int actual = 0;

    public MinStack() {
        stack = new List<int>();
    }
    
    public void Push(int val) {
        stack.Add(val);
        actual++;
    }
    
    public void Pop() {
        if(actual > 0) {
            actual--;
            stack.RemoveAt(actual);
        }
    }
    
    public int Top() {
        return stack[actual-1];
    }
    
    public int GetMin() {
        return stack.Min();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */