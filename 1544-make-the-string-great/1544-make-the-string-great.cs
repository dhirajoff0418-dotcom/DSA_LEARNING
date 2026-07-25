public class Solution
{
    public string MakeGood(string s)
    {
        char[] arr = s.ToCharArray();
        int write = 0;

        for (int read = 0; read < arr.Length; read++)
        {
            if (write > 0 && Math.Abs(arr[read] - arr[write - 1]) == 32)
            {
                write--;
            }
            else
            {
                arr[write] = arr[read];
                write++;
            }
        }

        return new string(arr, 0, write);
    }
}