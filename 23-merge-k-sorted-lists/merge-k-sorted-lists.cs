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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) return null;

        while(lists.Length > 1) {
            List<ListNode> mergedLists = new List<ListNode>();
            
            for(int i = 0; i < lists.Length; i += 2) {
                if(i+1 < lists.Length) {
                    mergedLists.Add(Merge(lists[i], lists[i+1]));
                } else {
                    mergedLists.Add(lists[i]);
                }
            }
            lists = mergedLists.ToArray();
        }
        
        return lists[0];
    }

    private ListNode Merge(ListNode left, ListNode right) {
        ListNode dummy = new ListNode();
        ListNode current = dummy;
        while(left != null && right != null) {
            if( left.val <= right.val ) {
                current.next = left;
                left = left.next;
            } else {
                current.next = right;
                right = right.next;
            }
            current = current.next;
        }
        if(left != null) {
            current.next = left;
        } else if(right != null) {
            current.next = right;
        }

        return dummy.next;
    }

    
}