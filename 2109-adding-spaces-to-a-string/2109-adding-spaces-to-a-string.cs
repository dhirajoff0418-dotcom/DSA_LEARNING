using System.Text;

public class Solution
{
    public string AddSpaces(string s, int[] spaces)
    {
        StringBuilder sb = new StringBuilder();

        int j = 0;

        foreach (int space in spaces)
        {
            while (j < space)
            {
                sb.Append(s[j]);
                j++;
            }

            sb.Append(' ');
        }

        while (j < s.Length)
        {
            sb.Append(s[j]);
            j++;
        }

        return sb.ToString();
    }
}