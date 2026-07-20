public class Solution {
    public bool WinnerOfGame(string colors) {
       int AliceMoves = 0;
       int BobMoves = 0;
       int i = 0;
       int n = colors.Length;
        while(i < n){

           int j = i;

            while(j < n && colors[j] == colors[i]){
                j++;
            }

           int runLength = j - i;

            if(colors[i] == 'A'){
                AliceMoves += Math.Max(0, runLength - 2);
            }else{
                BobMoves += Math.Max(0, runLength - 2);
            }

            i = j;
        }

        return AliceMoves > BobMoves;
}
}