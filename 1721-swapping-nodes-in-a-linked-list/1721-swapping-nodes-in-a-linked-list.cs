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

    public ListNode SwapNodes(ListNode head, int k)
    {
        int length = FindLength(head);

        // kth node from beginning
        ListNode first = head;

        for (int i = 1; i < k; i++)
        {
            first = first.next;
        }

        // kth node from end
        int k2 = length - k + 1;

        ListNode second = head;

        for (int i = 1; i < k2; i++)
        {
            second = second.next;
        }

        // Swap values
        int temp = first.val;
        first.val = second.val;
        second.val = temp;

        return head;
    }
}