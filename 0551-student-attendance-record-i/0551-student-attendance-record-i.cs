public class Solution
{
    public bool CheckRecord(string s)
    {
        int Av = 0;
        int Lv = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'P')
            {
                Lv = 0;
            }
            else if (s[i] == 'A')
            {
                Av++;
                Lv = 0;

                if (Av >= 2)
                    return false;
            }
            else if (s[i] == 'L')
            {
                Lv++;

                if (Lv >= 3)
                    return false;
            }
        }

        return true;
    }
}