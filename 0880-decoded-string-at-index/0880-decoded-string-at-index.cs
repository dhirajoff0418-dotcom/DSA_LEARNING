// public class Solution
// {
//     public string DecodeAtIndex(string s, int k)
//     {
//         string result = "";

//         char[] chars = s.ToCharArray();

//         for (int i = 0; i < chars.Length; i++)
//         {
//             if (chars[i] >= 'a' && chars[i] <= 'z')
//             {
//                 result += chars[i];
//             }
//             else
//             {
//                 int d = chars[i] - '0';

//                 string temp = result;

//                 for (int j = 1; j < d; j++)
//                 {
//                     result += temp;
//                 }
//             }
//         }

//         return result[k - 1].ToString();
//     }
// }

public class Solution
{
    public string DecodeAtIndex(string s, int k)
    {
        long count = 0;

        // Step 1: Find total decoded length
        foreach (char ch in s)
        {
            if (char.IsLetter(ch))
            {
                count++;
            }
            else
            {
                int d = ch - '0';
                count *= d;
            }
        }

        // Step 2: Go backwards
        for (int i = s.Length - 1; i >= 0; i--)
        {
            char ch = s[i];

            if (char.IsDigit(ch))
            {
                int d = ch - '0';

                // Remove the repeated copies
                count /= d;

                // k belongs to the original tape
                k = (int)(k % count);

                if (k == 0)
                    k = (int)count;
            }
            else
            {
                // This letter represents position k
                if (k == count)
                    return ch.ToString();

                count--;
            }
        }

        return "";
    }
}