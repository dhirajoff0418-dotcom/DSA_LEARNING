public class Solution {
    public int BagOfTokensScore(int[] tokens, int power) {
        int score=0;
        Array.Sort(tokens);
        int maxScore=0;
        int i=0 ;
        int j=tokens.Length-1;
        while (i <= j)
        {
            if (power >= tokens[i])
            {
                power -= tokens[i];
                score++;
                maxScore = Math.Max(maxScore, score);
                i++;
            }
            else if (score > 0)
            {
                power += tokens[j];
                score--;
                j--;
            }
            else
            {
                break;
            }
        }
        return maxScore;
    }
}