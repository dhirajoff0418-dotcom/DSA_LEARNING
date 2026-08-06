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
    private ListNode Reverse(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        // Reverse both lists
        l1 = Reverse(l1);
        l2 = Reverse(l2);

        int carry = 0;

        ListNode dummy = new ListNode(-1);
        ListNode tail = dummy;

        while (l1 != null || l2 != null || carry != 0)
        {
            int sum = carry;

            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            carry = sum / 10;
            int digit = sum % 10;

            tail.next = new ListNode(digit);
            tail = tail.next;
        }

        // Reverse the result before returning
        return Reverse(dummy.next);
    }
}