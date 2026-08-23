public class Solution
{
    public string WinningPlayer(int x, int y)
    {
        int allowedX = x; 
        int allowedY = y / 4;
        int min = Math.Min(allowedX, allowedY);

        if (min % 2 == 1)
            return "Alice";
        else
            return "Bob";
    }
}