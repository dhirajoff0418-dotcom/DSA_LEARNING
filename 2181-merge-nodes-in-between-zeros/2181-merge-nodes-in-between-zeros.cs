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
    public ListNode MergeNodes(ListNode head) {
        if (head == null || head.next == null) return head;

        ListNode dummy = new ListNode(0);
        ListNode result = dummy;

        ListNode curr = head.next;
        int currSum = 0;

        while (curr != null) {
            if (curr.val != 0) {
                currSum += curr.val;
            }
            else {
                result.next = new ListNode(currSum);
                result = result.next;
                currSum = 0;
            }

            curr = curr.next;
        }

        return dummy.next;
    }
}