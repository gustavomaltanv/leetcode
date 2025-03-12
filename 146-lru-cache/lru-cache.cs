public class LRUCache {
    private int _capacity;
    private Dictionary<int, LinkedListNode<(int key, int value)>> _cache;
    private LinkedList<(int key, int value)> _access;

    public LRUCache(int capacity) {
        _capacity = capacity;
        _cache = new Dictionary<int, LinkedListNode<(int key, int value)>>(_capacity);
        _access = new LinkedList<(int key, int value)>();
    }

    public int Get(int key) {
        if (!_cache.ContainsKey(key)) return -1;

        LinkedListNode<(int key, int value)> node = _cache[key];
        _access.Remove(node);
        _access.AddFirst(node);

        return node.Value.value;
    }

    public void Put(int key, int value) {
        if (_cache.ContainsKey(key)) {
            LinkedListNode<(int key, int value)> node = _cache[key];
            node.Value = (key, value);
            _access.Remove(node);
            _access.AddFirst(node);
        } else {
            if (_cache.Count >= _capacity) {
                LinkedListNode<(int key, int value)> lruNode = _access.Last;
                _cache.Remove(lruNode.Value.key);
                _access.RemoveLast();
            }
            LinkedListNode<(int key, int value)> newNode = new LinkedListNode<(int key, int value)>((key, value));
            _access.AddFirst(newNode);
            _cache[key] = newNode;
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */