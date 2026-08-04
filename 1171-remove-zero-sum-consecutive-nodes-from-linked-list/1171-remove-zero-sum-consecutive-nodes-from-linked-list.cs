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
    public ListNode RemoveZeroSumSublists(ListNode head)
    {
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        Dictionary<int, ListNode> map = new Dictionary<int, ListNode>();

        int sum = 0;
        ListNode curr = dummy;

        // First pass
        while (curr != null)
        {
            sum += curr.val;
            map[sum] = curr;
            curr = curr.next;
        }

        // Second pass
        sum = 0;
        curr = dummy;

        while (curr != null)
        {
            sum += curr.val;

            curr.next = map[sum].next;

            curr = curr.next;
        }

        return dummy.next;
    }
}