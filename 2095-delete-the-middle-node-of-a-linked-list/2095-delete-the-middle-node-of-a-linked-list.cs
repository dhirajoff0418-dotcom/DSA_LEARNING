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
    public ListNode DeleteMiddle(ListNode head)
    {
        int n = FindLength(head);

        if (n == 1)
            return null;

        ListNode curr = head;

       
        for (int i = 0; i < n / 2 - 1; i++)
        {
            curr = curr.next;
        }

        curr.next = curr.next.next;

        return head;
    }

    public int FindLength(ListNode node)
    {
        int count = 0;

        ListNode curr = node;

        while (curr != null)
        {
            count++;
            curr = curr.next;
        }

        return count;
    }
}