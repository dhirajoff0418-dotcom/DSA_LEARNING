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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode prev = dummy;
        ListNode curr = head;

        while (curr != null) {
            if (curr.next != null && curr.val == curr.next.val) {
                int duplicate = curr.val;

                while (curr != null && curr.val == duplicate) {
                    curr = curr.next;
                }

                prev.next = curr;
            }
            else {
                prev = curr;
                curr = curr.next;
            }
        }

        return dummy.next;
    }
}