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
    public ListNode ModifiedList(int[] nums, ListNode head) {
        HashSet<int> set = new HashSet<int>(nums);

        while (head != null && set.Contains(head.val)) {
            head = head.next;
        }

        if (head == null) return null;

        ListNode prev = head;
        ListNode curr = head.next;

        while (curr != null) {
            if (set.Contains(curr.val)) {
                prev.next = curr.next;
            }
            else {
                prev = curr;
            }

            curr = curr.next;
        }

        return head;
    }
}