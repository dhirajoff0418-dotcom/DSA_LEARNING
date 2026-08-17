public class Solution {
    // public int[] NextGreaterElement(int[] nums1, int[] nums2) {
    //     int[] arr = new int[nums1.Length];

    //     for (int i = 0; i < nums1.Length; i++) {
    //         int j = 0;

    //         while (nums2[j] != nums1[i]) {
    //             j++;
    //         }

    //         arr[i] = -1;

    //         for (int k = j + 1; k < nums2.Length; k++) {
    //             if (nums2[k] > nums1[i]) {
    //                 arr[i] = nums2[k];
    //                 break;
    //             }
    //         }
    //     }

    //     return arr;
    // }

    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        Stack<int> stack = new Stack<int>();

        foreach (int num in nums2)
        {
            while (stack.Count > 0 && num > stack.Peek())
            {
                map[stack.Pop()] = num;
            }

            stack.Push(num);
        }

        while (stack.Count > 0)
        {
            map[stack.Pop()] = -1;
        }

        int[] result = new int[nums1.Length];

        for (int i = 0; i < nums1.Length; i++)
        {
            result[i] = map[nums1[i]];
        }

        return result;
    }
}