public class BrowserHistory {
    private static LinkedList<string> browser;
    private static LinkedListNode<string> current;


    public BrowserHistory(string homepage) {
        browser = new LinkedList<string>();
        browser.AddFirst(homepage);
        current = browser.First;
    }
    
    public void Visit(string url) {
        while (browser.Last != current) {
            browser.RemoveLast();
        }
        browser.AddLast(url);
        current = current.Next;
    }
    
    public string Back(int steps) {
        for(int i = 0; i < steps; i++) {
            if(current != browser.First) {
                current = current.Previous;
            }
        }
        return current.Value;
    }
    
    public string Forward(int steps) {
        for(int i = 0; i < steps; i++) {
            if(current != browser.Last) {
                current = current.Next;
            }
        }
        return current.Value;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */