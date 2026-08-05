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
    public int[] NodesBetweenCriticalPoints(ListNode head)
    {
        List<int> criticalPoints = new List<int>();

        ListNode prev = head;
        ListNode curr = head.next;

        int index = 1;

        while (curr != null && curr.next != null)
        {
            if ((curr.val > prev.val && curr.val > curr.next.val) ||
                (curr.val < prev.val && curr.val < curr.next.val))
            {
                criticalPoints.Add(index);
            }

            prev = curr;
            curr = curr.next;
            index++;
        }

        if (criticalPoints.Count < 2)
        {
            return new int[] { -1, -1 };
        }

        int minDis = int.MaxValue;

        for (int i = 1; i < criticalPoints.Count; i++)
        {
            minDis = Math.Min(
                minDis,
                criticalPoints[i] - criticalPoints[i - 1]
            );
        }

        int maxDis = criticalPoints[criticalPoints.Count - 1]
                   - criticalPoints[0];

        return new int[] { minDis, maxDis };
    }
}