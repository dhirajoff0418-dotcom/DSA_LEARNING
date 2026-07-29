public class Solution
{
    public string ProcessStr(string s)
    {
        string result = "";
        char[] chars = s.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] >= 'a' && chars[i] <= 'z')
            {
                result += chars[i];
            }
            else if (chars[i] == '*')
            {
                if (result.Length > 0)
                {
                    result = result.Substring(0, result.Length - 1);
                }
            }
            else if (chars[i] == '#')
            {
                result += result;
            }
            else if (chars[i] == '%')
            {
                char[] temp = result.ToCharArray();
                Array.Reverse(temp);
                result = new string(temp);
            }
        }

        return result;
    }
}