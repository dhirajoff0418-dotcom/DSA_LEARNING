public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        int maxCoin=0;
        int A=piles.Length-1;
        int M=piles.Length-2;
        int B=0;

        while( M > B){
            maxCoin +=piles[M];
            B++;
            M=M-2;
            A=A-2;
        }
        return maxCoin;
    }
}