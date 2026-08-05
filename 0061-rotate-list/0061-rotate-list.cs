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

public class Solution
{
    public int FindLength(ListNode head)
    {
        int count = 0;
        ListNode curr = head;

        while (curr != null)
        {
            count++;
            curr = curr.next;
        }

        return count;
    }

    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0)
            return head;

        int length = FindLength(head);

        k = k % length;

        if (k == 0)
            return head;

        // Find the last node
        ListNode tail = head;

        while (tail.next != null)
        {
            tail = tail.next;
        }

        // Make the list circular
        tail.next = head;

        // Find new tail
        ListNode newTail = head;

        for (int i = 1; i < length - k; i++)
        {
            newTail = newTail.next;
        }

        // New head is next of new tail
        ListNode newHead = newTail.next;

        // Break the circle
        newTail.next = null;

        return newHead;
    }
}