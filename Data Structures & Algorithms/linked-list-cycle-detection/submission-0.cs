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
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> hs = new HashSet<ListNode>();
        while (head != null && head.next != null) {
            if (!hs.Contains(head)) {
                hs.Add(head);
                head = head.next;
            } else {
                return true;
            }
        }
        return false;
    }
}
