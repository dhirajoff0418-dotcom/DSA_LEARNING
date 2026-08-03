/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null)
            return null;

        ListNode slow = head;
        ListNode fast = head;

        // Detect cycle
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
            {
                break;
            }
        }

        // No cycle
        if (fast == null || fast.next == null)
        {
            return null;
        }

        // Find cycle starting point
        ListNode p = head;

        while (p != slow)
        {
            p = p.next;
            slow = slow.next;
        }

        return p;
    }
}