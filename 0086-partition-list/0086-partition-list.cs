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
    public ListNode Partition(ListNode head, int x) {
        ListNode smallDummy = new ListNode(0);
        ListNode largeDummy = new ListNode(0);
        ListNode smallT = smallDummy;
        ListNode largeT = largeDummy;
        ListNode curr = head;

        while (curr != null) {
            if (curr.val < x) {
                smallT.next = curr;
                smallT = smallT.next;
            } else {
                largeT.next = curr;
                largeT = largeT.next;
            }
            curr = curr.next;
        }

        largeT.next = null;
        smallT.next = largeDummy.next;

        return smallDummy.next;
    }
}