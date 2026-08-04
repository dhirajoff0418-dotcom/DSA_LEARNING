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
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
            return null;

        ListNode result = lists[0];

        for (int i = 1; i < lists.Length; i++)
        {
            result = MergeTwo(result, lists[i]);
        }

        return result;
    }

    public ListNode MergeTwo(ListNode L1, ListNode L2)
    {
        if (L1 == null)
            return L2;

        if (L2 == null)
            return L1;

        if (L1.val < L2.val)
        {
            L1.next = MergeTwo(L1.next, L2);
            return L1;
        }
        else
        {
            L2.next = MergeTwo(L1, L2.next);
            return L2;
        }
    }
}