public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> hs = new HashSet<int>();
        HashSet<int> result = new HashSet<int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            hs.Add(nums1[i]);
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (hs.Contains(nums2[i]))
            {
                result.Add(nums2[i]);
            }
        }

        return result.ToArray();
    }
}