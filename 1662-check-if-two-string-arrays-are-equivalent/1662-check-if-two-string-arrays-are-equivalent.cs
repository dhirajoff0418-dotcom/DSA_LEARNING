public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string wordF1 = "";
        string wordF2 = "";

        foreach (string s in word1)
            wordF1 += s;

        foreach (string s in word2)
            wordF2 += s;

        return wordF1 == wordF2;
    }
}