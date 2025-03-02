/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int[] NextLargerNodes(ListNode head) {
        List<int> values = new List<int>();
        while (head != null) {
            values.Add(head.val);
            head = head.next;
        }

        int[] result = new int[values.Count];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < values.Count; i++) {
            while (stack.Count > 0 && values[stack.Peek()] < values[i]) {
                result[stack.Pop()] = values[i];
            }
            stack.Push(i);
        }

        while (stack.Count > 0) {
            result[stack.Pop()] = 0;
        }

        return result;
    }
}
