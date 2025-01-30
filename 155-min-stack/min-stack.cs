public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (minStack.Count == 0 || val <= minStack.Peek()) {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if (stack.Count > 0) {
            if (stack.Peek() == minStack.Peek()) {
                minStack.Pop();
            }
            stack.Pop();
        }
    }
    
    public int Top() {
        if (stack.Count > 0) {
            return stack.Peek();
        }
        throw new InvalidOperationException();
    }
    
    public int GetMin() {
        if (minStack.Count > 0) {
            return minStack.Peek();
        }
        throw new InvalidOperationException();
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