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
    public ListNode RemoveNodes(ListNode head)
    {
        if (head == null)
            return null;

        Stack<int> st = new Stack<int>();

        ListNode curr = head;
        while (curr != null)
        {
            st.Push(curr.val);
            curr = curr.next;
        }

        int currMax = int.MinValue;
        ListNode newHead = null;

        while (st.Count > 0)
        {
            int currVal = st.Pop();

            if (currVal >= currMax)
            {
                currMax = currVal;

                // Insert at front
                newHead = new ListNode(currVal, newHead);
            }
        }

        return newHead;
    }
}