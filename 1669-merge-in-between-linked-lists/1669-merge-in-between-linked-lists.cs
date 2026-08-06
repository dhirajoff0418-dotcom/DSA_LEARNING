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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
    {
        ListNode curr = list1;
        int index = 0;

        // Find node before 'a'
        while (index < a - 1)
        {
            curr = curr.next;
            index++;
        }

        ListNode prevA = curr;

        // Find node at index 'b'
        while (index < b)
        {
            curr = curr.next;
            index++;
        }

        ListNode afterB = curr.next;

        // Connect prevA to list2
        prevA.next = list2;

        // Find tail of list2
        ListNode tail = list2;
        while (tail.next != null)
        {
            tail = tail.next;
        }

        // Connect tail to afterB
        tail.next = afterB;

        return list1;
    }
}