public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null)
            return true;

        Stack<int> st = new Stack<int>();

        ListNode curr = head;

        // Push all values
        while (curr != null)
        {
            st.Push(curr.val);
            curr = curr.next;
        }

      
        curr = head;

        while (curr != null)
        {
            if (curr.val != st.Pop())
            {
                return false;
            }

            curr = curr.next;
        }

        return true;
    }
}