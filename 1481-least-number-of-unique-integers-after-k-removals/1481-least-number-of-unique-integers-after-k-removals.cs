public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        //dict me hmne frequency ko store kiye key value me
        for (int i = 0; i < arr.Length; i++)
        {
            if (freq.ContainsKey(arr[i]))
                freq[arr[i]]++;
            else
                freq[arr[i]] = 1;
        }

        // Store frequencies in a listthen dic se frequency array me freqyency store kiya
        List<int> frequencies = new List<int>(freq.Values);

        // Unko sort kiya
        frequencies.Sort();

        int unique = freq.Count;

        // Remove least frequent elements first
        for (int i = 0; i < frequencies.Count; i++)
        {
            if (k >= frequencies[i])
            {
                k -= frequencies[i];
                unique--;
            }
            else
            {
                break;
            }
        }

        return unique;
    }
}