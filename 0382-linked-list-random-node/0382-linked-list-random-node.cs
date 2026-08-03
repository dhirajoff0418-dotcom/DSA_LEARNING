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
    private List<int> arr;
    private Random random;

    public Solution(ListNode head)
    {
        arr = new List<int>();
        random = new Random();

        ListNode temp = head;

        while (temp != null)
        {
            arr.Add(temp.val);
            temp = temp.next;
        }
    }

    public int GetRandom()
    {
        int n = arr.Count;
        int randomIndex = random.Next(n);

        return arr[randomIndex];
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */