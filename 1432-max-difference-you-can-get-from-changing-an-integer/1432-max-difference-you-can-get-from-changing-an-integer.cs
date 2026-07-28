public class Solution
{
    public int MaxDiff(int num)
    {
        string s = num.ToString();

        // Maximum
        char[] maxArr = s.ToCharArray();
        char replaceMax = '\0';

        for (int i = 0; i < maxArr.Length; i++)
        {
            if (maxArr[i] != '9')
            {
                replaceMax = maxArr[i];
                break;
            }
        }

        if (replaceMax != '\0')
        {
            for (int i = 0; i < maxArr.Length; i++)
            {
                if (maxArr[i] == replaceMax)
                    maxArr[i] = '9';
            }
        }

        int max = int.Parse(new string(maxArr));

        // Minimum
        char[] minArr = s.ToCharArray();

        if (minArr[0] != '1')
        {
            char replaceMin = minArr[0];

            for (int i = 0; i < minArr.Length; i++)
            {
                if (minArr[i] == replaceMin)
                    minArr[i] = '1';
            }
        }
        else
        {
            char replaceMin = '\0';

            for (int i = 1; i < minArr.Length; i++)
            {
                if (minArr[i] != '0' && minArr[i] != '1')
                {
                    replaceMin = minArr[i];
                    break;
                }
            }

            if (replaceMin != '\0')
            {
                for (int i = 0; i < minArr.Length; i++)
                {
                    if (minArr[i] == replaceMin)
                        minArr[i] = '0';
                }
            }
        }

        int min = int.Parse(new string(minArr));

        return max - min;
    }
}