public class MyLinkedList {
    private LinkedList<int> list;

    public MyLinkedList() {
        list = new LinkedList<int>();
    }
    
    public int Get(int index) {
        if (index >= 0 && index < list.Count) {
            LinkedListNode<int> val = list.First; 
            for (int i = 0; i < index; i++) {
                val = val.Next;
            }
            return val.Value;
        }
        return -1;
    }
    
    public void AddAtHead(int val) {
        list.AddFirst(val);
    }
    
    public void AddAtTail(int val) {
        list.AddLast(val);
    }
    
    public void AddAtIndex(int index, int val) { 
        if (index >= 0 && index <= list.Count) {
            if (index == 0) {
                list.AddFirst(val);
            } else if (index == list.Count) {
                list.AddLast(val);
            } else {
                LinkedListNode<int> prev = list.First; 
                for (int i = 0; i < index - 1; i++) {
                    prev = prev.Next;
                }
                list.AddAfter(prev, val);
            }
        }
    }
    
    public void DeleteAtIndex(int index) {
        if (index >= 0 && index < list.Count) {
            LinkedListNode<int> rm = list.First; 
            for (int i = 0; i < index; i++) {
                rm = rm.Next;
            }
            list.Remove(rm);
        }
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */