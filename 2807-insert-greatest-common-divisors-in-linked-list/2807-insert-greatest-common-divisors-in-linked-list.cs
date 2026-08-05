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
    public int CalGCD(int val1, int val2)
        {
            while (val2 != 0)
            {
                int temp = val2;
                val2 = val1 % val2;
                val1 = temp;
            }

            return val1;
        }
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        if(head ==null || head.next ==null)
        return head;
        ListNode slow=head;
        ListNode fast=head.next;
        while (fast != null){
            ListNode gcdNode = new ListNode(CalGCD(slow.val, fast.val));
            slow.next=gcdNode;
            gcdNode.next=fast;
            slow=fast;
            fast=fast.next;
        }
       return head;
    }
}