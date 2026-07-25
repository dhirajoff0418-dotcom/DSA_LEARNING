public class Solution
{
    public string CountAndSay(int n)
    {
        if (n == 1)
            return "1";

        string say = CountAndSay(n - 1);

        string result = "";

        for (int i = 0; i < say.Length; i++)
        {
            char ch = say[i];
            int count = 1;

            while (i < say.Length - 1 && say[i] == say[i + 1])
            {
                count++;
                i++;
            }

            result += count.ToString();
            result += ch;
        }

        return result;
    }
}