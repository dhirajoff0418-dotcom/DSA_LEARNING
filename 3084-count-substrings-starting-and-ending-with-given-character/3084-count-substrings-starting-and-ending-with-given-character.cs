// public class Solution
// {
//     public long CountSubstrings(string s, char c)
//     {
//         long count = 0;
//         long subCount = 0;

//         for (int i = 0; i < s.Length; i++)
//         {
//             if (s[i] == c)
//             {
//                 count++;
//                 subCount += count;
//             }
//         }

//         return subCount;
//     }
// }

public class Solution
{
    public long CountSubstrings(string s, char c)
    {
        long count = 0;

        foreach (char ch in s)
        {
            if (ch == c)
            {
                count++;
            }
        }

        // C(count, 2) + C(count, 1)
        return (count * (count - 1) / 2) + count;
    }
}